using AutoMapper;
using FitAirlines.Model;
using FitAirlines.Model.Requests;
using FitAirlines.WebAPI.Database;
using FitAirlines.WebAPI.Exceptions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FitAirlines.WebAPI.Services
{
    public class UsersService : IUsersService
    {
        private readonly FitAirlinesContext _context;
        
        private readonly IMapper _mapper;

        public UsersService(FitAirlinesContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Model.Users> Get()
        {
            var query = _context.Users.AsQueryable();
            var list = query
                .Include(x => x.UserRole)
                .Include(x => x.MembershipType)
                .ToList();
            return _mapper.Map<List<Model.Users>>(list);
        }

        public Model.Users GetById(int id)
        {
            var entity = _context.Users
                .Where(x => x.UserId == id)
                .Include(x => x.UserRole)
                .Include(x => x.MembershipType)
                .FirstOrDefault();
            return _mapper.Map<Model.Users>(entity);
        }

        public Model.Users Insert(UsersInsertRequest request)
        {
            var entity = _mapper.Map<Database.Users>(request);
            if (request.Password != request.PasswordConfirmation)
            {
                throw new UserException("Passwords do not match");
            }
            if (CheckUsernameExists(request.Username))
            {
                throw new UserException("Username is already taken.");
            }
            if (CheckEmailExists(request.Email))
            {
                throw new UserException("Email is already taken.");
            }

            entity.PasswordSalt = GenerateSalt();
            entity.PasswordHash = GenerateHash(entity.PasswordSalt, request.Password);
            entity.StartDate = DateTime.Now;

            _context.Users.Add(entity);
            _context.SaveChanges();

            return _mapper.Map<Model.Users>(entity);
        }

        // TODO: JR move to password helper

        public static string GenerateSalt()
        {
            var buf = new byte[16];
            (new RNGCryptoServiceProvider()).GetBytes(buf);
            return Convert.ToBase64String(buf);
        }

        public static string GenerateHash(string salt, string password)
        {
            byte[] src = Convert.FromBase64String(salt);
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] dst = new byte[src.Length + bytes.Length];

            System.Buffer.BlockCopy(src, 0, dst, 0, src.Length);
            System.Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);

            HashAlgorithm algorithm = HashAlgorithm.Create("SHA1");
            byte[] inArray = algorithm.ComputeHash(dst);
            return Convert.ToBase64String(inArray);
        }

        public bool CheckUsernameExists(string username)
        {
            return _context.Users.Any(x => x.Username == username);
        }
        public bool CheckEmailExists(string email)
        {
            return _context.Users.Any(x => x.Email == email);
        }
    }
}
