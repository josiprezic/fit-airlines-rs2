﻿using Microsoft.EntityFrameworkCore;
using System.IO;

namespace FitAirlines.WebAPI.Database
{
    
    public partial class FitAirlinesContext
    {
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder)
        {
            // Countries
            modelBuilder.Entity<Countries>().HasData(new Countries() { CountryId = 1, CountryName = "Poland", ShortInfo = "Poland may not be an obvious holiday destination, but it has a lot to offer. It’s the perfect place for a weekend getaway, a skiing trip, or a peaceful beach escape. From impressive natural beauty, to rich history and mouthwatering food, here is why Poland should be number one on your travel wish list." });
            modelBuilder.Entity<Countries>().HasData(new Countries() { CountryId = 2, CountryName = "Croatia", ShortInfo = "Thanks in part to that dazzling World Cup run, Croatia is buzzier than ever, although each year increasing numbers of travelers seek out this idyllic haven on the Adriatic, known for its richly historic and evocative cities, exceptional food and wine, and heavenly sailing waters." });
            modelBuilder.Entity<Countries>().HasData(new Countries() { CountryId = 3, CountryName = "New Zeland", ShortInfo = "New Zealand is a tiny country. Made up of two rather remote islands (and many smaller ones) and with a population of just over four million people, it is not the most acessible place in the world to visit. Yet it remains one of the world greatest tourist destinations." });
            modelBuilder.Entity<Countries>().HasData(new Countries() { CountryId = 4, CountryName = "Australia", ShortInfo = "One of the most popular reasons to visit Australia is the snorkelling and scuba diving around the Great Barrier Reef. It’s the world’s largest living organism (so big that it has its own post box), and the entire Reef is bigger than the United Kingdom, Holland and Switzerland combined!" });
            modelBuilder.Entity<Countries>().HasData(new Countries() { CountryId = 5, CountryName = "Japan", ShortInfo = "All the beautiful ancient Buddhist temples and Shinto shrines are reason enough to visit Japan. One of the best-preserved cities in Japan, Kyoto offers something like 2,000 Buddhist temples and shrines within the limits of the Kansai Region city, while Nara is home to no less than 8 UNESCO World Heritage Sites." });
            modelBuilder.Entity<Countries>().HasData(new Countries() { CountryId = 6, CountryName = "Thailand", ShortInfo = "Whether visitors are staying in the Land of Smiles for one day or one month, Thai food is so delicious and diverse that visitors should never have to eat the same dish twice. Visitors will even find that the cuisine changes as their location does, keeping their food options interesting as they venture from one city to the next." });
            modelBuilder.Entity<Countries>().HasData(new Countries() { CountryId = 7, CountryName = "Nepal", ShortInfo = "Nepal still evades travellers’ bucket lists, and we for one can’t understand why: the views are stunning (you have jungle, lakes, and mountains), the people are friendly, it’s home to once-in-a-lifetime treks and it’s safe and affordable. So what are you waiting for? Here are our 17 reasons to visit Nepal in 2019." });
            modelBuilder.Entity<Countries>().HasData(new Countries() { CountryId = 8, CountryName = "Botswana", ShortInfo = "Botswana is rich in culture and wildlife, and here Botswana Holidays gives us not one, but six reasons that will definitely inspire you to visit this amazing country!" });
            modelBuilder.Entity<Countries>().HasData(new Countries() { CountryId = 9, CountryName = "Latvia", ShortInfo = "Also known to be the pearl of Baltic States, Latvia is located in the Baltic region in Northern Europe. It has an enchanting history, long and well established traditions and rich culture." });
            modelBuilder.Entity<Countries>().HasData(new Countries() { CountryId = 10, CountryName = "Germany", ShortInfo = "There’s no way around it: Germany has firmly established itself as a first rate travel destination, not just for the well-informed few but for the happy-go-lucky crowds of tourists from all over the world too; in case anyone wonders why: this country has much more to it than meets the eye (no rhyme intended)." });
            modelBuilder.Entity<Countries>().HasData(new Countries() { CountryId = 11, CountryName = "France", ShortInfo = "I do not need to convince you to come over to visit or live in France. France is still the top holiday’s destination in the world. Everyone seems to dream about coming to France and everyone is fascinated by France & French people and language of course." });
            modelBuilder.Entity<Countries>().HasData(new Countries() { CountryId = 12, CountryName = "Spain", ShortInfo = "Spain really does have it all, from incredible landscapes and beaches, to world-famous cuisine and rich history – not to mention fantastic museums and striking architecture." });
            modelBuilder.Entity<Countries>().HasData(new Countries() { CountryId = 13, CountryName = "Portugal", ShortInfo = "I bet you’ve probably checked most European destinations off your travel bucket list by now: the UK, France, Spain, Italy, Germany, Ireland, Austria, Switzerland… Have I missed any? Oh yeah! You should visit Portugal." });
            modelBuilder.Entity<Countries>().HasData(new Countries() { CountryId = 14, CountryName = "Italy", ShortInfo = "Italy isn’t just for travelers who crave the world’s best pizzas, pastas and wines. The food (and wine) in this uniquely boot-shaped country is one reason to add it to your bucket list, but the historic cities, snow-capped mountains, pristine coastlines and endless museums will assure you that one visit is not enough." });
            modelBuilder.Entity<Countries>().HasData(new Countries() { CountryId = 15, CountryName = "Greece", ShortInfo = "Want to visit Greece? Good choice! It’s a fantastic country that offers everything from beaches and islands to culture and history as well as delicious food and friendly locals." });
            modelBuilder.Entity<Countries>().HasData(new Countries() { CountryId = 16, CountryName = "Switzerland", ShortInfo = "Switzerland may seem relatively small as compared to other European nations but that certainly does not mean that it has less to offer. Rather, it has set itself apart from the rest of Europe – its unparalleled landscapes, peaceful environments and cosmopolitan cities." });
            modelBuilder.Entity<Countries>().HasData(new Countries() { CountryId = 17, CountryName = "United Kingdom", ShortInfo = "The United Kingdom is a great place to visit. In fact, England, Scotland, Wales and the Offshore Islands all offer great vacation and holiday destinations with something for everyone—singles, couples, and families." });
            modelBuilder.Entity<Countries>().HasData(new Countries() { CountryId = 18, CountryName = "Uruguay", ShortInfo = "Uruguay’s entire southeast coast is littered with beaches. The Río de la Plata River, the widest in the world, makes up the beaches in the south. As you go eastwards, you’ll see how the river water gradually mixes with the Atlantic Ocean, creating more blue and green beaches with bigger waves." });
            modelBuilder.Entity<Countries>().HasData(new Countries() { CountryId = 19, CountryName = "Mexico", ShortInfo = "Mexico is one of the year’s hottest destinations, what with its secret island escapes, Caribbean coastline and cosmopolitan capital city, as well as its thriving restaurant scene and quirky colonial towns that are ideal for day trips. " });
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

            // Cities
            modelBuilder.Entity<Cities>().HasData(new Cities { CityId = 1, CityName = "Kielce", ShortInfo = "First impressions of Kielce (kyel-tseh) are not likely to be positive. The town is ringed by postwar housing projects that on a rainy day, or any day, can look downright dispiriting. But dig a little deeper and you’ll find a lively city with a surprisingly elegant core.", Picture = File.ReadAllBytes("Assets/kielce.jpg"), CountryId = 1 });
            modelBuilder.Entity<Cities>().HasData(new Cities() { CityId = 2, CityName = "Wroclaw", ShortInfo = "Are you wondering where to go during your next trip to Europe? Next, to its most famous cities, such as London, Paris or Barcelona, there are some that few have heard of. One of them is Wroclaw.", Picture = File.ReadAllBytes("Assets/wroclaw.jpg"), CountryId = 1 });
            modelBuilder.Entity<Cities>().HasData(new Cities() { CityId = 3, CityName = "Krakow", ShortInfo = "From a booming café culture to wild nightlife, fascinating historical spots to pretty parks, there are plenty of reasons why a visit to Krakow should be on the menu this year.", Picture = File.ReadAllBytes("Assets/krakow.jpg"), CountryId = 1 });
            modelBuilder.Entity<Cities>().HasData(new Cities() { CityId = 4, CityName = "Gdansk", ShortInfo = "Poland’s Baltic seaside city of Gdansk has sat in the background for years as one of the most underrated cities in Europe.", Picture = File.ReadAllBytes("Assets/gdansk.jpg"), CountryId = 1 });
            modelBuilder.Entity<Cities>().HasData(new Cities() { CityId = 5, CityName = "Warsaw", ShortInfo = "Warsaw has undergone some rapid changes in the last 20 years since the fall of communism. It has developed into a city for new business, turned into a tourist hub and really proved why this is the true capital city, ahead of previous capitals Gniezno and Kraków", Picture = File.ReadAllBytes("Assets/warsaw.jpg"), CountryId = 1 });
            modelBuilder.Entity<Cities>().HasData(new Cities() { CityId = 6, CityName = "Lodz", ShortInfo = "What makes Lodz such a fascinating destination in Poland is how wildly different it is to other major attractions.", Picture = File.ReadAllBytes("Assets/lodz.jpg"), CountryId = 1 });
            modelBuilder.Entity<Cities>().HasData(new Cities() { CityId = 7, CityName = "Gdynia", ShortInfo = "You might argue that modern Gdynia is a history lesson in itself, created as it was ... such as the Emigration Museum is improving the choice of places to visit.", Picture = File.ReadAllBytes("Assets/gdynia.jpg"), CountryId = 1 });
            modelBuilder.Entity<Cities>().HasData(new Cities() { CityId = 8, CityName = "Katowice", ShortInfo = "Katowice - the most underrated and misunderstood city in Poland, with a bright future ahead.", Picture = File.ReadAllBytes("Assets/katowice.jpg"), CountryId = 1 });
            modelBuilder.Entity<Cities>().HasData(new Cities() { CityId = 9, CityName = "Gliwice", ShortInfo = "Gliwice comes as a real surprise for those to determined to pay it a visit. From wooden towers to leafy gardens to historic churches, this is a city full of suprises.", Picture = File.ReadAllBytes("Assets/gliwice.jpg"), CountryId = 1 });
            modelBuilder.Entity<Cities>().HasData(new Cities() { CityId = 10, CityName = "Bialystok", ShortInfo = "When trying to figure out how to get between Lithuania and Poland, I came across the option to travel to the city of Bialystok in far eastern", Picture = File.ReadAllBytes("Assets/bialystok.jpg"), CountryId = 1 });
            modelBuilder.Entity<Cities>().HasData(new Cities() { CityId = 11, CityName = "Zagreb", ShortInfo = "As the inland capital of a country famous for its dazzling island-speckled coastline, Zagreb is often overlooked by travellers.", Picture = File.ReadAllBytes("Assets/zagreb.jpg"), CountryId = 2 });
            modelBuilder.Entity<Cities>().HasData(new Cities() { CityId = 12, CityName = "Split", ShortInfo = "No longer just a launchpad to Dalmatia’s islands, Split has successfully shaken off its one-time image as an industrial backwater, reinventing itself as a city where antiquity and urban life fully intersect.", Picture = File.ReadAllBytes("Assets/split.jpg"), CountryId = 2 });
            modelBuilder.Entity<Cities>().HasData(new Cities() { CityId = 13, CityName = "Dubrovnik", ShortInfo = "Should there even be a specific reason to visit Dubrovnik? To gaze upon the Pearl of the Adriatic, a historic jewel set within pristine City Walls, is almost reason alone.", Picture = File.ReadAllBytes("Assets/dubrovnik.jpg"), CountryId = 2 });
            modelBuilder.Entity<Cities>().HasData(new Cities() { CityId = 14, CityName = "Rijeka", ShortInfo = "Check out what Rijeka’s history, culture, heritage, nature have to offer… what is worth a visit while you’re here and what you will remember Rijeka by.", Picture = File.ReadAllBytes("Assets/rijeka.jpg"), CountryId = 2 });
            modelBuilder.Entity<Cities>().HasData(new Cities() { CityId = 15, CityName = "Hvar", ShortInfo = "The island of Hvar has a reputation of being one of the most beautiful in Croatia and has been named by some travel magazines one of the most beautiful places in the World.", Picture = File.ReadAllBytes("Assets/hvar.jpg"), CountryId = 2 });
            modelBuilder.Entity<Cities>().HasData(new Cities() { CityId = 16, CityName = "Osijek", ShortInfo = "Visit Osijek, Croatia in the Slavonia region for both city and nature experiences - and exceptional local cuisine and wine.", Picture = File.ReadAllBytes("Assets/osijek.jpg"), CountryId = 2 });
            modelBuilder.Entity<Cities>().HasData(new Cities() { CityId = 17, CityName = "Makarska", ShortInfo = "Makarska has always been the center of the surrounding region known as Makarska Riviera, one of the most famous tourist destinations on the Croatian coast.", Picture = File.ReadAllBytes("Assets/makarska.jpg"), CountryId = 2 });
            modelBuilder.Entity<Cities>().HasData(new Cities() { CityId = 18, CityName = "Zadar", ShortInfo = "I always love thinking of the hundreds of generations of people who walked the same route when I visit towns like Zadar, the weight of history etc.", Picture = File.ReadAllBytes("Assets/zadar.jpg"), CountryId = 2 });
            modelBuilder.Entity<Cities>().HasData(new Cities() { CityId = 19, CityName = "Auckland", ShortInfo = "It’s no secret that Auckland is New Zealand’s largest city both population and landmass-wise. In fact, Auckland has a larger population than the whole South Island!", Picture = File.ReadAllBytes("Assets/auckland.jpg"), CountryId = 3 });
            modelBuilder.Entity<Cities>().HasData(new Cities() { CityId = 20, CityName = "Wellington", ShortInfo = "Wellington is a popular choice for backpackers to stay a while.", Picture = File.ReadAllBytes("Assets/wellington.jpg"), CountryId = 3 });
            modelBuilder.Entity<Cities>().HasData(new Cities() { CityId = 21, CityName = "Christchurch", ShortInfo = "The South Island’s largest city is not only teaming with work opportunities for backpackers, but the art work, views from the Port Hills, and surf beaches entice many to explore.", Picture = File.ReadAllBytes("Assets/christchurch.jpg"), CountryId = 3 });
            modelBuilder.Entity<Cities>().HasData(new Cities() { CityId = 22, CityName = "Hamilton", ShortInfo = "Situated on the banks of the might Waikato River, Hamilton is the centre of the Waikato region.", Picture = File.ReadAllBytes("Assets/hamilton.jpg"), CountryId = 3 });
            modelBuilder.Entity<Cities>().HasData(new Cities() { CityId = 23, CityName = "Gold Coast", ShortInfo = "As the closest thing Australia has to Miami, Gold Coast is a glitzy strip of modern high-rises built on 90 miles of sunshine-soaked coastline.", Picture = File.ReadAllBytes("Assets/goldcoast.jpg"), CountryId = 4 });
            modelBuilder.Entity<Cities>().HasData(new Cities() { CityId = 24, CityName = "Cairns", ShortInfo = "Everything is the opposite Down Under. Winter is summer and the further north you go, the hotter it gets.", Picture = File.ReadAllBytes("Assets/cairns.jpg"), CountryId = 4 });
            modelBuilder.Entity<Cities>().HasData(new Cities() { CityId = 25, CityName = "Darwin", ShortInfo = "The most laid-back city in a famously laid-back country, Darwin’s far northern location has it closer to Indonesia and Papua New Guinea than Sydney or Melbourne.", Picture = File.ReadAllBytes("Assets/darwin.jpg"), CountryId = 4 });
            modelBuilder.Entity<Cities>().HasData(new Cities() { CityId = 26, CityName = "Adelaide", ShortInfo = "Probably Australia’s most overlooked of the country’s five cities with populations over one million.", Picture = File.ReadAllBytes("Assets/adelaide.jpg"), CountryId = 4 });
            modelBuilder.Entity<Cities>().HasData(new Cities() { CityId = 27, CityName = "Hobart", ShortInfo = "Hobart is a beautiful and underrated city in the equally overlooked and misunderstood island of Tasmania.", Picture = File.ReadAllBytes("Assets/hobart.jpg"), CountryId = 4 });
            modelBuilder.Entity<Cities>().HasData(new Cities() { CityId = 28, CityName = "Tokyo", ShortInfo = "The Tokyo Metropolis is made up of 23 Special Wards, home to upwards of 35 million people.", Picture = File.ReadAllBytes("Assets/tokyo.jpg"), CountryId = 5 });
            modelBuilder.Entity<Cities>().HasData(new Cities() { CityId = 29, CityName = "Yokohama", ShortInfo = "It is known for being Japan’s first port that officially opened to foreign trade in 1859. It’s not a stretch to say that international influences have shaped Yokohama’s character, from the city’s signature brick architecture.", Picture = File.ReadAllBytes("Assets/yokohama.jpg"), CountryId = 5 });
            modelBuilder.Entity<Cities>().HasData(new Cities() { CityId = 30, CityName = "Nagoya", ShortInfo = "Nagoya has long been the center of Japan’s automotive and aviation manufacturing, as well as a technological hub with a growing robotics industry.", Picture = File.ReadAllBytes("Assets/nagoya.jpg"), CountryId = 5 });
            modelBuilder.Entity<Cities>().HasData(new Cities() { CityId = 31, CityName = "Kyoto", ShortInfo = "Kyoto was the official capital of Japan for over 1,000 years and remains one of the foremost destinations to experience traditional Japanese culture.", Picture = File.ReadAllBytes("Assets/kyoto.jpg"), CountryId = 5 });

            // Airports
            modelBuilder.Entity<Airports>().HasData(new Airports() { AirportId = 1, AirportName = "Kielce Lotnisko Glowne", IsAvailable = true, CityId = 1 });
            modelBuilder.Entity<Airports>().HasData(new Airports() { AirportId = 2, AirportName = "Kielce-Cminsk Lotnisko", IsAvailable = true, CityId = 1 });
            modelBuilder.Entity<Airports>().HasData(new Airports() { AirportId = 3, AirportName = "Kielce Lotnisko Narodowe", IsAvailable = true, CityId = 1 });
            modelBuilder.Entity<Airports>().HasData(new Airports() { AirportId = 4, AirportName = "Wroclaw Lotnisko Biskupin", IsAvailable = true, CityId = 2 });
            modelBuilder.Entity<Airports>().HasData(new Airports() { AirportId = 5, AirportName = "Lotnisko Morskie Oko", IsAvailable = true, CityId = 2 });
            modelBuilder.Entity<Airports>().HasData(new Airports() { AirportId = 6, AirportName = "Lotnisko Hala Stulecia", IsAvailable = true, CityId = 2 });
            modelBuilder.Entity<Airports>().HasData(new Airports() { AirportId = 7, AirportName = "Krakow Lotnisko Narodowe", IsAvailable = true, CityId = 3 });
            modelBuilder.Entity<Airports>().HasData(new Airports() { AirportId = 8, AirportName = "Gdansk Lotnisko", IsAvailable = true, CityId = 4 });
            modelBuilder.Entity<Airports>().HasData(new Airports() { AirportId = 9, AirportName = "Warsaw Lotnisko Glowne Narodowe", IsAvailable = true, CityId = 5 });
            modelBuilder.Entity<Airports>().HasData(new Airports() { AirportId = 10, AirportName = "Lodz Airport", IsAvailable = true, CityId = 6 });
            modelBuilder.Entity<Airports>().HasData(new Airports() { AirportId = 11, AirportName = "Gdynia Airport", IsAvailable = true, CityId = 7 });
            modelBuilder.Entity<Airports>().HasData(new Airports() { AirportId = 12, AirportName = "Katowice Airport", IsAvailable = true, CityId = 8 });
            modelBuilder.Entity<Airports>().HasData(new Airports() { AirportId = 13, AirportName = "Gliwice Airport", IsAvailable = true, CityId = 9 });
            modelBuilder.Entity<Airports>().HasData(new Airports() { AirportId = 14, AirportName = "Bialystok Airport", IsAvailable = true, CityId = 10 });
            modelBuilder.Entity<Airports>().HasData(new Airports() { AirportId = 15, AirportName = "Zagreb Main Airport", IsAvailable = true, CityId = 11 });
            modelBuilder.Entity<Airports>().HasData(new Airports() { AirportId = 16, AirportName = "Dubrava Airport", IsAvailable = true, CityId = 11 });
            modelBuilder.Entity<Airports>().HasData(new Airports() { AirportId = 17, AirportName = "Jelacic Airport", IsAvailable = true, CityId = 11 });
            modelBuilder.Entity<Airports>().HasData(new Airports() { AirportId = 18, AirportName = "Split Airport", IsAvailable = true, CityId = 12 });
            modelBuilder.Entity<Airports>().HasData(new Airports() { AirportId = 19, AirportName = "Cilipi Airport", IsAvailable = true, CityId = 13 });
            modelBuilder.Entity<Airports>().HasData(new Airports() { AirportId = 20, AirportName = "Rijeka Airport", IsAvailable = true, CityId = 14 });
            modelBuilder.Entity<Airports>().HasData(new Airports() { AirportId = 21, AirportName = "Hvar Airport", IsAvailable = true, CityId = 15 });
            modelBuilder.Entity<Airports>().HasData(new Airports() { AirportId = 22, AirportName = "Osijek Airport", IsAvailable = true, CityId = 16 });
            modelBuilder.Entity<Airports>().HasData(new Airports() { AirportId = 23, AirportName = "Makarska Airport", IsAvailable = true, CityId = 17 });
            modelBuilder.Entity<Airports>().HasData(new Airports() { AirportId = 24, AirportName = "Zadar Airport", IsAvailable = true, CityId = 18 });
            modelBuilder.Entity<Airports>().HasData(new Airports() { AirportId = 25, AirportName = "Auckland Airport", IsAvailable = true, CityId = 19 });
            modelBuilder.Entity<Airports>().HasData(new Airports() { AirportId = 26, AirportName = "Wellington Airport", IsAvailable = true, CityId = 20 });
            modelBuilder.Entity<Airports>().HasData(new Airports() { AirportId = 27, AirportName = "Christchurch Airport", IsAvailable = true, CityId = 21 });
            modelBuilder.Entity<Airports>().HasData(new Airports() { AirportId = 28, AirportName = "Hamilton Airport", IsAvailable = true, CityId = 22 });
            modelBuilder.Entity<Airports>().HasData(new Airports() { AirportId = 29, AirportName = "Gold Coast Airport", IsAvailable = true, CityId = 23 });
            modelBuilder.Entity<Airports>().HasData(new Airports() { AirportId = 30, AirportName = "Cairns Airport", IsAvailable = true, CityId = 24 });
            modelBuilder.Entity<Airports>().HasData(new Airports() { AirportId = 31, AirportName = "Darwin Airport", IsAvailable = true, CityId = 25 });
            modelBuilder.Entity<Airports>().HasData(new Airports() { AirportId = 32, AirportName = "Adelaide Airport", IsAvailable = true, CityId = 26 });
            modelBuilder.Entity<Airports>().HasData(new Airports() { AirportId = 33, AirportName = "Hobart Airport", IsAvailable = true, CityId = 27 });
            modelBuilder.Entity<Airports>().HasData(new Airports() { AirportId = 34, AirportName = "Tokyo Main Airport", IsAvailable = true, CityId = 28 });
            modelBuilder.Entity<Airports>().HasData(new Airports() { AirportId = 35, AirportName = "Tokyo Oyo Airport", IsAvailable = true, CityId = 28 });
            modelBuilder.Entity<Airports>().HasData(new Airports() { AirportId = 36, AirportName = "Tokyo Takahuma Airport", IsAvailable = true, CityId = 28 });
            modelBuilder.Entity<Airports>().HasData(new Airports() { AirportId = 37, AirportName = "Yokohama Airport", IsAvailable = true, CityId = 29 });
            modelBuilder.Entity<Airports>().HasData(new Airports() { AirportId = 38, AirportName = "Nagoya Airport", IsAvailable = true, CityId = 30 });
            modelBuilder.Entity<Airports>().HasData(new Airports() { AirportId = 39, AirportName = "Kyoto Airport", IsAvailable = true, CityId = 31 });

            // Offer Types
            modelBuilder.Entity<OfferTypes>().HasData(new OfferTypes() { OfferTypeId = 1, TypeName = "Regional", TypeDescription = "This offer type reffers to offers containing flights which share the same regional part of the specific area/continent." });
            modelBuilder.Entity<OfferTypes>().HasData(new OfferTypes() { OfferTypeId = 2, TypeName = "Seasonal", TypeDescription = "This offer type reffers to offers containing flights which belongs to the same season of the year" });
            modelBuilder.Entity<OfferTypes>().HasData(new OfferTypes() { OfferTypeId = 3, TypeName = "Special", TypeDescription = "This offer type reffers to offers containing flights which belongs to the offers of special/uncategorized types." });

            // Offers
            modelBuilder.Entity<Offers>().HasData(new Offers() { OfferId = 1, OfferName = "Green Poland", ShortInfo = "While parts of the country do still feel like a time warp, today's Poland also has a vibrant urbanity, enticing food and design culture, dynamic history, and kindhearted natives.", Picture = File.ReadAllBytes("Assets/offer1.jpg"), StartDate = new System.DateTime(2023, 4, 1), EndDate = new System.DateTime(2023, 6, 1), IsActive = true, DateAdded = new System.DateTime(2022, 10, 10), OfferTypeId = 1 });
            modelBuilder.Entity<Offers>().HasData(new Offers() { OfferId = 2, OfferName = "Perfect Summer", ShortInfo = "A perfect balance of time with myself, with friends, and with family.", Picture = File.ReadAllBytes("Assets/offer2.jpg"), StartDate = new System.DateTime(2022, 5, 12), EndDate = new System.DateTime(2022, 10, 1), IsActive = true, DateAdded = new System.DateTime(2022, 10, 10), OfferTypeId = 1 });
            modelBuilder.Entity<Offers>().HasData(new Offers() { OfferId = 3, OfferName = "Christmas Magic", ShortInfo = "I am the traditions, I am the baker for school sales, I am the buyer of last-minute presents that were forgotten.", Picture = File.ReadAllBytes("Assets/offer3.jpg"), StartDate = new System.DateTime(2023, 11, 1), EndDate = new System.DateTime(2024, 1, 1), IsActive = true, DateAdded = new System.DateTime(2022, 10, 10), OfferTypeId = 1 });
            modelBuilder.Entity<Offers>().HasData(new Offers() { OfferId = 4, OfferName = "Travelling Adventure", ShortInfo = "Leading an active adventure lifestyle has it's benefits. Here are ways it can improve your quality of life and overall sense of well-being.", Picture = File.ReadAllBytes("Assets/offer4.jpg"), StartDate = new System.DateTime(2023, 4, 1), EndDate = new System.DateTime(2023, 6, 1), IsActive = true, DateAdded = new System.DateTime(2022, 10, 11), OfferTypeId = 1 });
            modelBuilder.Entity<Offers>().HasData(new Offers() { OfferId = 5, OfferName = "FITable journey", ShortInfo = "Travel takes us out of our comfort zones and inspires us to see, taste and try new things.", Picture = File.ReadAllBytes("Assets/offer5.jpg"), StartDate = new System.DateTime(2022, 6, 1), EndDate = new System.DateTime(2023, 9, 1), IsActive = true, DateAdded = new System.DateTime(2022, 9, 10), OfferTypeId = 1 });
            modelBuilder.Entity<Offers>().HasData(new Offers() { OfferId = 6, OfferName = "FIT Special", ShortInfo = "It constantly challenges us, not only to adapt to and explore new surroundings, but also to engage with different people, to embrace adventures as they come and to share new and meaningful experiences with friends and loved ones.", Picture = File.ReadAllBytes("Assets/offer6.jpg"), StartDate = new System.DateTime(2022, 4, 1), EndDate = new System.DateTime(2022, 12, 31), IsActive = true, DateAdded = new System.DateTime(2022, 10, 10), OfferTypeId = 1 });

            // Planes
            modelBuilder.Entity<Planes>().HasData(new Planes() { PlaneId = 1, PlaneName = "Fitovac M20", Capacity = 300, NumberOfColumns = 6, IsAvailable = true });
            modelBuilder.Entity<Planes>().HasData(new Planes() { PlaneId = 2, PlaneName = "DLearningovac M60", Capacity = 150, NumberOfColumns = 6, IsAvailable = true });
            modelBuilder.Entity<Planes>().HasData(new Planes() { PlaneId = 3, PlaneName = "Mrezar 443", Capacity = 84, NumberOfColumns = 6, IsAvailable = true });
            modelBuilder.Entity<Planes>().HasData(new Planes() { PlaneId = 4, PlaneName = "Sistemac 1010", Capacity = 306, NumberOfColumns = 6, IsAvailable = true });
            modelBuilder.Entity<Planes>().HasData(new Planes() { PlaneId = 5, PlaneName = "Coder 17", Capacity = 150, NumberOfColumns = 6, IsAvailable = true });
            modelBuilder.Entity<Planes>().HasData(new Planes() { PlaneId = 6, PlaneName = "Mostarac 1000", Capacity = 180, NumberOfColumns = 6, IsAvailable = true });
            modelBuilder.Entity<Planes>().HasData(new Planes() { PlaneId = 7, PlaneName = "Studentovic 21", Capacity = 90, NumberOfColumns = 6, IsAvailable = true });
            modelBuilder.Entity<Planes>().HasData(new Planes() { PlaneId = 8, PlaneName = "Apsolvent 333", Capacity = 150, NumberOfColumns = 6, IsAvailable = true });

            // MembershipTypes
            modelBuilder.Entity<MembershipTypes>().HasData(new MembershipTypes() { MembershipTypeId = 1, Title = "Basic", IsPriorityAvailable = false, IsExtraBaggageAvailable = false, IsFitsandwichAvailable = false, IsSeatChangeAvailable = false, IsBonusDrinkAvailable = false, IsBonusMealAvailable = false, BasicTicketDiscount = 0, BasicFoodDrinkDiscount = 0, ShortInfo = "Default Membership Type" });
            modelBuilder.Entity<MembershipTypes>().HasData(new MembershipTypes() { MembershipTypeId = 2, Title = "Blue", IsPriorityAvailable = true, IsExtraBaggageAvailable = true, IsFitsandwichAvailable = false, IsSeatChangeAvailable = false, IsBonusDrinkAvailable = false, IsBonusMealAvailable = false, BasicTicketDiscount = 0, BasicFoodDrinkDiscount = 0, ShortInfo = "With Blue FIT membership you have a priority while checking in and you are able to take the extra baggage." });
            modelBuilder.Entity<MembershipTypes>().HasData(new MembershipTypes() { MembershipTypeId = 3, Title = "Gold", IsPriorityAvailable = true, IsExtraBaggageAvailable = true, IsFitsandwichAvailable = true, IsSeatChangeAvailable = true, IsBonusDrinkAvailable = false, IsBonusMealAvailable = false, BasicTicketDiscount = 0, BasicFoodDrinkDiscount = 0, ShortInfo = "With Gold FIT membership you will get special FIT sandwich before every flight and if you would like to change a seat during the flight and if there are some other free seats, you will be able to do it." });
            modelBuilder.Entity<MembershipTypes>().HasData(new MembershipTypes() { MembershipTypeId = 4, Title = "Platinum", IsPriorityAvailable = true, IsExtraBaggageAvailable = true, IsFitsandwichAvailable = true, IsSeatChangeAvailable = true, IsBonusDrinkAvailable = true, IsBonusMealAvailable = true, BasicTicketDiscount = 0, BasicFoodDrinkDiscount = 0, ShortInfo = "With Platinum FIT membership you will get one extra meal and one extra drink for free." });
            modelBuilder.Entity<MembershipTypes>().HasData(new MembershipTypes() { MembershipTypeId = 5, Title = "Diamond", IsPriorityAvailable = true, IsExtraBaggageAvailable = true, IsFitsandwichAvailable = true, IsSeatChangeAvailable = true, IsBonusDrinkAvailable = true, IsBonusMealAvailable = true, BasicTicketDiscount = 1, BasicFoodDrinkDiscount = 1, ShortInfo = "With Diamond FIT membership you will get an additional discount for your ticket as long as for all meals and drinks in the FIT menu." });

            // UserRoles
            modelBuilder.Entity<UserRoles>().HasData(new UserRoles() { UserRoleId = 1, Title = "Administrator", IsAbleToAddNewUsers = true, IsAbleToAddNewOffers = true, IsAbleToAddNewFlights = true, IsAbleToAddNewPlanes = true, IsAbleToAddUserCredits = true, IsAbleToAddNewReservations = true, IsAbleToAddNewPlaces = true, IsSuperUser = true });
            modelBuilder.Entity<UserRoles>().HasData(new UserRoles() { UserRoleId = 2, Title = "Boss", IsAbleToAddNewUsers = true, IsAbleToAddNewOffers = false, IsAbleToAddNewFlights = false, IsAbleToAddNewPlanes = false, IsAbleToAddUserCredits = false, IsAbleToAddNewReservations = false, IsAbleToAddNewPlaces = false, IsSuperUser = false });
            modelBuilder.Entity<UserRoles>().HasData(new UserRoles() { UserRoleId = 3, Title = "Flight Offers Manager", IsAbleToAddNewUsers = false, IsAbleToAddNewOffers = true, IsAbleToAddNewFlights = true, IsAbleToAddNewPlanes = true, IsAbleToAddUserCredits = false, IsAbleToAddNewReservations = false, IsAbleToAddNewPlaces = true, IsSuperUser = false });
            modelBuilder.Entity<UserRoles>().HasData(new UserRoles() { UserRoleId = 4, Title = "Cashier", IsAbleToAddNewUsers = false, IsAbleToAddNewOffers = false, IsAbleToAddNewFlights = false, IsAbleToAddNewPlanes = false, IsAbleToAddUserCredits = true, IsAbleToAddNewReservations = true, IsAbleToAddNewPlaces = false, IsSuperUser = false });
            modelBuilder.Entity<UserRoles>().HasData(new UserRoles() { UserRoleId = 5, Title = "FIT Member", IsAbleToAddNewUsers = false, IsAbleToAddNewOffers = false, IsAbleToAddNewFlights = false, IsAbleToAddNewPlanes = false, IsAbleToAddUserCredits = false, IsAbleToAddNewReservations = true, IsAbleToAddNewPlaces = false, IsSuperUser = false });





            //modelBuilder.Entity<Countries>().HasData(new Countries()
            //{
            //    CountryId = 2,
            //    CountryName = "Poland",
            //    Picture = File.ReadAllBytes("Assets/countrytest.jpg")
            //});



            //////// TODO: JR
            //modelBuilder.Entity<Cities>().HasData(new Cities()
            //{
            //    CityId = 1,
            //    CityName = "Test",
            //    ShortInfo = "Shor",
            //    Picture = File.ReadAllBytes("Assets/cityname.jpg"),
            //    CountryId = 1,
            //});
        }
    }
}
