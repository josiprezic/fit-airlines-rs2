using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitAirlines.WebAPI.Mapper
{
    public class Mapper : Profile
    {
    
        public Mapper()
        {
            CreateMap<Database.Airports, Model.Airports>();
            CreateMap<Database.Cities, Model.Cities>();
            CreateMap<Database.Countries, Model.Countries>();
            CreateMap<Database.Flights, Model.Flights>();
            CreateMap<Database.MembershipTypes, Model.MembershipTypes>();
            CreateMap<Database.Offers, Model.Offers>();
            CreateMap<Database.OfferTypes, Model.OfferTypes>();
            CreateMap<Database.Planes, Model.Planes>();
            CreateMap<Database.Ratings, Model.Ratings>();
            CreateMap<Database.Reservations, Model.Reservations>();
            CreateMap<Database.ReservedSeats, Model.ReservedSeats>();
            CreateMap<Database.UserRoles, Model.UserRoles>();
            CreateMap<Database.Users, Model.Users>();

            CreateMap<Database.Users, Model.Requests.UsersInsertRequest>().ReverseMap();
            CreateMap<Database.Users, Model.Requests.UsersUpdateRequest>().ReverseMap();
            CreateMap<Database.Offers, Model.Requests.OffersInsertRequest>().ReverseMap();

            CreateMap<Database.Flights, Model.Requests.FlightsInsertRequest>().ReverseMap();
        }
    }
}
