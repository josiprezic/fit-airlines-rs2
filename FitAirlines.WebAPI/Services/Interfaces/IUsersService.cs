using FitAirlines.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitAirlines.WebAPI.Services
{
    public interface IUsersService
    {
        List<Model.Users> Get(Model.Requests.UsersSearchRequest request);
        Model.Users GetById(int id);

        Model.Users Insert(Model.Requests.UsersInsertRequest request);
        Model.Users Update(int id, Model.Requests.UsersUpdateRequest request);

        Model.Users MyProfile();
        Task<Model.Users> Authenticate(string username, string pass);
        bool UpdatePassword(Model.Requests.UsersUpdatePasswordRequest request);

        Model.Users CurrentUser { get; set; }

        double AddCredits(UsersAddCreditsRequest request);
    }
}
