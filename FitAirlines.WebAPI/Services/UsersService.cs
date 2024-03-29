﻿using AutoMapper;
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
        public Model.Users CurrentUser { get; set; }

        public UsersService(FitAirlinesContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Model.Users> Get(UsersSearchRequest request)
        {
            var query = _context.Users.AsQueryable();
            if (!string.IsNullOrEmpty(request.Name))
            {
                query = query.Where(x => (x.FirstName + " " + x.LastName).Contains(request.Name));
            }

            if (!string.IsNullOrEmpty(request.Gender))
            {
                query = query.Where(x => x.Gender == request.Gender);
            }

            if (request.MembershipTypeId != 0)
            {
                query = query.Where(x => x.MembershipTypeId == request.MembershipTypeId);
            }

            if (request.ShowOnlyActive)
            {
                query = query.Where(x => x.IsActive == true);
            }

            var list = query
                .Include(x => x.UserRole)
                .Include(x => x.MembershipType)
                .Select(x => new Database.Users
                {
                    BirthDate = x.BirthDate,
                    ContactNumber = x.ContactNumber,
                    Credit = x.Credit,
                    Email = x.Email,
                    FirstName = x.FirstName,
                    LastName = x.LastName,
                    Gender = x.Gender,
                    IsActive = x.IsActive,
                    MembershipType = x.MembershipType,
                    MembershipTypeId = x.MembershipTypeId,
                    UserRole = x.UserRole,
                    UserRoleId = x.UserRoleId,
                    StartDate = x.StartDate,
                    UserId = x.UserId
                })
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

        public Model.Users Update(int id, UsersUpdateRequest request)
        {
            var entity = _context.Users.Find(id);

            byte[] OldPicture = entity.Picture;
            if (request.Picture == null || request.Picture.Length == 0)
                request.Picture = OldPicture;

            _context.Users.Attach(entity);
            _context.Users.Update(entity);
            if (!string.IsNullOrWhiteSpace(request.Password))
            {
                if (request.Password != request.PasswordConfirmation)
                {
                    throw new UserException("Passwords do not match.");
                }

                entity.PasswordSalt = GenerateSalt();
                entity.PasswordHash = GenerateHash(entity.PasswordSalt, request.Password);
            }
            if (entity.Email != request.Email && CheckEmailExists(request.Email))
            {
                throw new UserException("Email is already taken.");
            }
            _mapper.Map(request, entity);
            _context.SaveChanges();
            return _mapper.Map<Model.Users>(entity);
        }


        public bool UpdatePassword(UsersUpdatePasswordRequest request)
        {
            var user = _context.Users.Find(CurrentUser.UserId);
            var oldHash = GenerateHash(user.PasswordSalt, request.OldPassword);

            if (oldHash != user.PasswordHash)
                throw new UserException("Old password is incorrect.");

            _context.Users.Attach(user);
            _context.Users.Update(user);

            user.PasswordSalt = GenerateSalt();
            user.PasswordHash = GenerateHash(user.PasswordSalt, request.NewPassword);

            _context.SaveChanges();
            return true;
        }

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

        public bool CheckEmailExists(string email)
        {
            return _context.Users.Any(x => x.Email == email);
        }

        public Model.Users MyProfile()
        {
            var query = _context.Users.AsQueryable();

            query = query.Where(x => x.UserId == CurrentUser.UserId);

            query = query.Include(x => x.UserRole);
            query = query.Include(x => x.MembershipType);

            var entity = query.FirstOrDefault();

            return _mapper.Map<Model.Users>(entity);
        }

        public async Task<Model.Users> Authenticate(string email, string pass)
        {
            var user = await _context.Users
                        .Include(x => x.UserRole)
                        .Include(x => x.MembershipType)
                        .FirstOrDefaultAsync(x => x.Email == email);

            if (user != null)
            {
                var newHash = GenerateHash(user.PasswordSalt, pass);

                if (newHash == user.PasswordHash)
                {
                    return _mapper.Map<Model.Users>(user);
                }
            }
            return null;
        }

        public double AddCredits(UsersAddCreditsRequest request)
        {
            var query = _context.Users.AsQueryable();

            query = query.Where(x => x.UserId == CurrentUser.UserId);

            var entity = query.FirstOrDefault();

            if (request.AddCredits > 0)
            {
                entity.Credit += request.AddCredits;
                _context.SaveChanges();
            }

            return entity.Credit;
        }
    }
}
