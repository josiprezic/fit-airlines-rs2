using Microsoft.EntityFrameworkCore;

namespace FitAirlines.WebAPI.Database
{
    
    public partial class FitAirlinesContext
    {
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder)
        {

            // Countries
            modelBuilder.Entity<Countries>().HasData(new Countries() { CountryId = 20, CountryName = "Canada", ShortInfo = "The expanse of Canadas natural beauty, from mountains and glaciers to secluded lakes and forests, is almost unparalleled worldwide. But Canadas allure is not just the great outdoors." });
            modelBuilder.Entity<Countries>().HasData(new Countries() { CountryId = 21, CountryName = "Vietnam", ShortInfo = "Holidaymakers from these four countries will be permitted entry for up to 15 days without having to acquire documentation, while an e-visa will be necessary for for trips of up to 30 days." });
            modelBuilder.Entity<Countries>().HasData(new Countries() { CountryId = 22, CountryName = "Indonesia", ShortInfo = "Their itinerary has included rafting down the Ayung River and visiting the Jatiluwih rice terraces, after which they are expected to visit Jakarta, the Indonesian capital. Here are 15 reasons to follow them to the vast archipelago.   " });
            modelBuilder.Entity<Countries>().HasData(new Countries() { CountryId = 23, CountryName = "Ireland", ShortInfo = "With its scene-stealing natural beauty and multitude of things to see and do, Ireland is a dream tourist destination." });
            modelBuilder.Entity<Countries>().HasData(new Countries() { CountryId = 24, CountryName = "Sri Lanka", ShortInfo = "Dive with blue whales in season or watch spinner dolphins leap about in Kalpitiya. Sri Lanka also has 5,800 wild elephants ambling about and the biggest concentration of leopards in the world." });
            modelBuilder.Entity<Countries>().HasData(new Countries() { CountryId = 25, CountryName = "Kenya", ShortInfo = "Long after you have left Kenya, there are some things that will stay with you forever – little treasures, both tangible and intangible." });
            modelBuilder.Entity<Countries>().HasData(new Countries() { CountryId = 26, CountryName = "Albania", ShortInfo = "Currently becoming one of the world’s most sought-after travel destinations, Albania is growing fast to accommodate visitors but also staying true to its strong rural culture. From beautiful nature to the more modern urban attractions, there’s so much to discover." });
            modelBuilder.Entity<Countries>().HasData(new Countries() { CountryId = 27, CountryName = "India", ShortInfo = "According to the biennial World Economic Forum (WEF) Travel and Tourism Competitiveness Report, India ranks 10th best for “price competitiveness”. Luxurious accommodation is relatively affordable, eating out cost very little indeed, and you can get around the country by train for peanuts." });
            modelBuilder.Entity<Countries>().HasData(new Countries() { CountryId = 28, CountryName = "Wales", ShortInfo = "If you love hearty food, a distinct culture, the outdoors, cosy pubs, fascinating traditions and breathtaking scenery then Wales is for you. It’s never easy to sum up a whole country but if you’re considering a visit to the land of song, here are the top 12 reasons why you should go ahead and do it." });
            modelBuilder.Entity<Countries>().HasData(new Countries() { CountryId = 29, CountryName = "Morocco", ShortInfo = "North Africa’s Morocco is a popular destination, attracting culture lovers, backpackers, adventure travelers, couples, families, foodies, and more." });
            modelBuilder.Entity<Countries>().HasData(new Countries() { CountryId = 30, CountryName = "Netherlands", ShortInfo = "Finding an excuse to visit the Netherlands is rarely difficult, thanks to the nation’s charming cities, beautiful countryside, and world-leading cultural attractions. For some additional motivation, we’ve put together the following list of top reasons to visit the Netherlands at least once." });
            modelBuilder.Entity<Countries>().HasData(new Countries() { CountryId = 31, CountryName = "Colombia", ShortInfo = "You do not need to be a huge expert in the sociopolitical history of Latin America in the last half-century to know that Colombia has not always been a country you would consider as a holiday option." });
            modelBuilder.Entity<Countries>().HasData(new Countries() { CountryId = 32, CountryName = "Philippines", ShortInfo = "The Philippines will never fail to amaze you. The stunning sights above and under the sea, the culture, the hospitality, the food, and of course, the friendly people willing to welcome visitors wherever and whenever." });


            
            

            //modelBuilder.Entity<Countries>().HasData(new Countries()
            //{
            //    CountryId = 2,
            //    CountryName = "Poland",
            //    Picture = File.ReadAllBytes("Assets/countrytest.png")
            //});



            // TODO: JR
            //modelBuilder.Entity<Cities>().HasData(new Cities()
            //{
            //    CountryId = 1,
            //    CountryName = "Bosnia and Herzegovina"
            //});
        }
    }
}
