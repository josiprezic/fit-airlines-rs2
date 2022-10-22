using AutoMapper;
using FitAirlines.Model.Requests;
using FitAirlines.WebAPI.Database;
using FitAirlines.WebAPI.Exceptions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace FitAirlines.WebAPI.Services
{
    public class OffersService : IOffersService
    {
        private readonly FitAirlinesContext _context;

        private readonly IMapper _mapper;

        public OffersService(FitAirlinesContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Model.Offers> Get(OffersSearchRequest request)
        {
            var query = _context.Offers.AsQueryable();
            if (!string.IsNullOrEmpty(request.Name))
            {
                query = query.Where(x => x.OfferName.ToLower().Contains(request.Name.ToLower()));
            }

            if (request.Date != null)
            {
                query = query.Where(x => x.StartDate <= request.Date && request.Date <= x.EndDate);
            }

            if (request.ShowOnlyActive)
            {
                query = query.Where(x => x.IsActive == true);
            }

            var list = query
                .Include(x => x.OfferType)
                .Select(x => new Offers
                {
                    DateAdded = x.DateAdded,
                    EndDate = x.EndDate,
                    IsActive = x.IsActive,
                    OfferId = x.OfferId,
                    OfferName = x.OfferName,
                    OfferType = x.OfferType,
                    OfferTypeId = x.OfferTypeId,
                    ShortInfo = x.ShortInfo,
                    StartDate = x.StartDate,
                    Picture = request.LoadPictures ? x.Picture : new byte[0]
                })
                .ToList();

            var mappedList = _mapper.Map<List<Model.Offers>>(list);
            foreach (var item in mappedList)
            {
                item.NumberOfDestinations = _context.Flights.Count(x => x.OfferId == item.OfferId && x.IsActive == request.ShowOnlyActive);
            }

            return mappedList;
        }

        public Model.Offers GetById(int id)
        {
            var entity = _context.Offers
                .Where(x => x.OfferId == id)
                .Include(x => x.OfferType)
                .FirstOrDefault();
            return _mapper.Map<Model.Offers>(entity);
        }

        public Model.Offers Insert(OffersInsertRequest request)
        {
            var entity = _mapper.Map<Database.Offers>(request);
            entity.DateAdded = DateTime.Now;
            _context.Offers.Add(entity);
            _context.SaveChanges();
            return _mapper.Map<Model.Offers>(entity);
        }

        public Model.Offers Update(int id, OffersInsertRequest request)
        {
            var entity = _context.Offers.Find(id);

            byte[] OldPicture = entity.Picture;
            if (request.Picture == null || request.Picture.Length == 0)
                request.Picture = OldPicture;

            _context.Offers.Attach(entity);
            _context.Offers.Update(entity);
            _mapper.Map(request, entity);
            _context.SaveChanges();
            return _mapper.Map<Model.Offers>(entity);
        }
    }
}
