using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace FitAirlines.WebAPI.Database
{
    
    public partial class FitAirlinesContext
    {
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Countries>().HasData(new Countries()
            {
                CountryId = 1,
                CountryName = "Bosnia and Herzegovina",
                Picture = File.ReadAllBytes("Assets/countrytest.png")
                
            });

            // TODO: JR
            //modelBuilder.Entity<Cities>().HasData(new Cities()
            //{
            //    CountryId = 1,
            //    CountryName = "Bosnia and Herzegovina"
            //});
        }
    }
}
