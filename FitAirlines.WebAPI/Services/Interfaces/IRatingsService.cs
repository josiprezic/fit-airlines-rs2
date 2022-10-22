using FitAirlines.Model;
using FitAirlines.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitAirlines.WebAPI.Services.Interfaces
{
    public interface IRatingsService
    {
        List<Ratings> Get(Model.Requests.RatingsSearchRequest request);
        Ratings RateFlight(RatingsInsertRequest request);
        List<Ratings> GetAllRatings(RatingsSearchRequest request);
    }
}
