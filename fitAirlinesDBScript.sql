
/**********************************************************************************
***********************************************************************************					
						FIT AIRLINES DATABASE
***********************************************************************************
***********************************************************************************/

/**********************************************************************************
						CREATING FIT AIRLINES DATABASE
**********************************************************************************/
USE master
GO
DROP DATABASE FitAirlines
GO
CREATE DATABASE FitAirlines
GO
USE FitAirlines
GO

/**********************************************************************************
						CREATING TABLES AND PROCEDURES
**********************************************************************************/

-- COUNTRIES TABLE
CREATE TABLE Countries (
	CountryID INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	CountryName NVARCHAR(50) NOT NULL UNIQUE,
	ShortInfo NVARCHAR(400) NULL,
	Picture VARBINARY(MAX) NULL
)
GO

-- CITIES TABLE
CREATE TABLE Cities (
	CityID INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	CityName NVARCHAR(50) NOT NULL,
	ShortInfo NVARCHAR(400) NULL,
	Picture VARBINARY(MAX) NULL,
	CountryID INT FOREIGN KEY REFERENCES Countries(CountryID) NOT NULL
)
GO

-- AIRPORTS TABLE
CREATE TABLE Airports (
	AirportID INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	AirportName NVARCHAR(50) NOT NULL UNIQUE,
	isAvailable BIT NOT NULL DEFAULT 1,
	CityID INT FOREIGN KEY REFERENCES Cities(CityID) NOT NULL
)
GO

--PLANES TABLE
CREATE TABLE Planes (
	PlaneID INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	PlaneName NVARCHAR (50) NOT NULL UNIQUE,
	Capacity INT NOT NULL,
	NumberOfColumns INT NOT NULL DEFAULT 6,
	IsAvailable BIT NOT NULL DEFAULT 1
)
GO

-- TABLE OFFER TYPES
CREATE TABLE OfferTypes (
	OfferTypeID INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	TypeName NVARCHAR(20) NOT NULL  UNIQUE,
	TypeDescription NVARCHAR(200) NOT NULL
)
GO

-- TABLE OFFERS
CREATE TABLE Offers (
	OfferID INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	OfferName NVARCHAR(50) NOT NULL UNIQUE,
	ShortInfo NVARCHAR(400) NULL,
	Picture VARBINARY(MAX) NULL,
	StartDate DATETIME NOT NULL,
	EndDate DATETIME NOT NULL,
	IsActive BIT NOT NULL DEFAULT 1,
	DateAdded DATETIME DEFAULT GETDATE(),
	OfferTypeID INT FOREIGN KEY REFERENCES OfferTypes(OfferTypeID) NOT NULL
)
GO

--USER ROLES TABLE
CREATE TABLE UserRoles (
	UserRoleID INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	Title NVARCHAR(30) NOT NULL UNIQUE,
	IsAbleToAddNewUsers BIT NOT NULL,
	IsAbleToAddNewOffers BIT NOT NULL,
	IsAbleToAddNewFlights BIT NOT NULL,
	IsAbleToAddNewPlanes BIT NOT NULL,
	IsAbleToAddUserCredits BIT NOT NULL,
	IsAbleToAddNewReservations BIT NOT NULL,
	IsAbleToAddNewPlaces BIT NOT NULL,
	IsSuperUser BIT NOT NULL DEFAULT 0
)
GO

-- MEMBERSHIP TYPES TABLE
CREATE TABLE MembershipTypes (
	MembershipTypeID INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	Title NVARCHAR(30) NOT NULL UNIQUE,
	ShortInfo NVARCHAR(400) NOT NULL,
	MembershipPrice FLOAT NOT NULL,
	IsPriorityAvailable BIT NOT NULL,
	IsExtraBaggageAvailable BIT NOT NULL,
	IsFITSandwichAvailable BIT NOT NULL,
	IsSeatChangeAvailable BIT NOT NULL,
	IsBonusDrinkAvailable BIT NOT NULL,
	IsBonusMealAvailable BIT NOT NULL,
	BasicTicketDiscount FLOAT NOT NULL,
	BasicFoodDrinkDiscount FLOAT NOT NULL    
)
GO

-- USERS TABLE
CREATE TABLE Users (
	UserID INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	FirstName NVARCHAR(50) NOT NULL,
	LastName NVARCHAR(50) NOT NULL,
	BirthDate DATETIME NOT NULL,
	Gender CHAR NOT NULL,
	Username NVARCHAR(50) NOT NULL UNIQUE,
	PasswordSalt NVARCHAR(100) DEFAULT '' NOT NULL,
	PasswordHash NVARCHAR(100) DEFAULT '' NOT NULL,
	Email NVARCHAR(50) NULL UNIQUE,
	ContactNumber NVARCHAR(50) NOT NULL,
	Picture VARBINARY(MAX) NULL,
	Credit FLOAT NOT NULL DEFAULT 0.0,
	StartDate DATETIME NOT NULL DEFAULT GETDATE(),
	isActive BIT NOT NULL DEFAULT 1,
	UserRoleID INT FOREIGN KEY REFERENCES UserRoles(UserRoleID) NOT NULL,
	MembershipTypeID INT FOREIGN KEY REFERENCES MembershipTypes(MembershipTypeID) NOT NULL
)
GO

--FLIGHTS TABLE
CREATE TABLE Flights (
	FlightID INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	CityID INT FOREIGN KEY REFERENCES Cities(CityID) NOT NULL,
	DestinationAirportID INT FOREIGN KEY REFERENCES Airports(AirportID) NOT NULL,
	OfferID INT FOREIGN KEY REFERENCES Offers(OfferID) NOT NULL,
	PlaneID INT FOREIGN KEY REFERENCES Planes(PlaneID) NOT NULL,
	AddedByUserID  INT FOREIGN KEY REFERENCES Users(UserID) NOT NULL,
	AddedDate DATETIME NOT NULL DEFAULT GETDATE(),
	VoucherCode NVARCHAR(10) NULL,
	VoucherDiscountPercentage FLOAT NULL,
	StartDate DATETIME NOT NULL,
	EndDate DATETIME NOT NULL,
	PilotFullName NVARCHAR (100) NOT NULL,
	FlightDuration TIME NOT NULL,
	Price FLOAT NOT NULL,
	ShortInfo NVARCHAR(400) NULL,
	Picture VARBINARY(MAX) NULL,
	Notes NVARCHAR(400) NULL,
	AvailableToMemberTypeID  INT FOREIGN KEY REFERENCES MembershipTypes(MembershipTypeID) NOT NULL,
	IsActive BIT NOT NULL DEFAULT 1
)
GO

-- RESERVATIONS TABLE
CREATE TABLE Reservations (
	ReservationID INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	UserID INT FOREIGN KEY REFERENCES Users(UserID) NOT NULL,
	FlightID INT FOREIGN KEY REFERENCES Flights(FlightID) NOT NULL,
	ReservationDate DATETIME NOT NULL DEFAULT GETDATE(),
	BaseTicketPrice FLOAT NOT NULL,
	TotalDiscountPercentage FLOAT NOT NULL DEFAULT 0,
	IsValid BIT NOT NULL DEFAULT 1,
	CashierID INT FOREIGN KEY REFERENCES Users(UserID) NULL,
	Notes NVARCHAR(100) NULL
)
GO

-- TABLE RATINGS
CREATE TABLE Ratings (
	RatingID INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	ReservationID INT FOREIGN KEY REFERENCES Reservations(ReservationID) NOT NULL,
	RatingValue FLOAT NOT NULL,
	Notes NVARCHAR(200) NULL,
	DateAdded DATETIME DEFAULT GETDATE()
)
GO

-- RESERVED SEATS TABLE
CREATE TABLE ReservedSeats (
	ReservedSeatID INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	ReservationID INT FOREIGN KEY REFERENCES Reservations(ReservationID) NOT NULL,
	FlightID INT FOREIGN KEY REFERENCES Flights(FlightID) NOT NULL,
	Direction NVARCHAR(5) NOT NULL,
	SeatPrice FLOAT NOT NULL,
	SeatRow INT NOT NULL,
	SeatColumn INT NOT NULL
)
GO

/**********************************************************************************
						INSERTING TEST DATA
**********************************************************************************/

/**********************************************************************************
									COUNTRIES
**********************************************************************************/
INSERT INTO Countries (CountryName, ShortInfo)
VALUES 
('Poland', 'Poland may not be an obvious holiday destination, but it has a lot to offer. It’s the perfect place for a weekend getaway, a skiing trip, or a peaceful beach escape. From impressive natural beauty, to rich history and mouthwatering food, here is why Poland should be number one on your travel wish list.'),
('Croatia', 'Thanks in part to that dazzling World Cup run, Croatia is buzzier than ever, although each year increasing numbers of travelers seek out this idyllic haven on the Adriatic, known for its richly historic and evocative cities, exceptional food and wine, and heavenly sailing waters.'),
('New Zeland', 'New Zealand is a tiny country. Made up of two rather remote islands (and many smaller ones) and with a population of just over four million people, it is not the most acessible place in the world to visit. Yet it remains one of the world greatest tourist destinations.'),
('Australia', 'One of the most popular reasons to visit Australia is the snorkelling and scuba diving around the Great Barrier Reef. It’s the world’s largest living organism (so big that it has its own post box), and the entire Reef is bigger than the United Kingdom, Holland and Switzerland combined!'),
('Japan', 'All the beautiful ancient Buddhist temples and Shinto shrines are reason enough to visit Japan. One of the best-preserved cities in Japan, Kyoto offers something like 2,000 Buddhist temples and shrines within the limits of the Kansai Region city, while Nara is home to no less than 8 UNESCO World Heritage Sites.'),	
('Thailand', 'Whether visitors are staying in the Land of Smiles for one day or one month, Thai food is so delicious and diverse that visitors should never have to eat the same dish twice. Visitors will even find that the cuisine changes as their location does, keeping their food options interesting as they venture from one city to the next.'),
('Nepal', 'Nepal still evades travellers’ bucket lists, and we for one can’t understand why: the views are stunning (you have jungle, lakes, and mountains), the people are friendly, it’s home to once-in-a-lifetime treks and it’s safe and affordable. So what are you waiting for? Here are our 17 reasons to visit Nepal in 2019.'),
('Botswana', 'Botswana is rich in culture and wildlife, and here Botswana Holidays gives us not one, but six reasons that will definitely inspire you to visit this amazing country!'),
('Latvia', 'Also known to be the pearl of Baltic States, Latvia is located in the Baltic region in Northern Europe. It has an enchanting history, long and well established traditions and rich culture.'),
('Germany', 'There’s no way around it: Germany has firmly established itself as a first rate travel destination, not just for the well-informed few but for the happy-go-lucky crowds of tourists from all over the world too; in case anyone wonders why: this country has much more to it than meets the eye (no rhyme intended).'),
('France', 'I do not need to convince you to come over to visit or live in France. France is still the top holiday’s destination in the world. Everyone seems to dream about coming to France and everyone is fascinated by France & French people and language of course.'),
('Spain', 'Spain really does have it all, from incredible landscapes and beaches, to world-famous cuisine and rich history – not to mention fantastic museums and striking architecture.'),
('Portugal', 'I bet you’ve probably checked most European destinations off your travel bucket list by now: the UK, France, Spain, Italy, Germany, Ireland, Austria, Switzerland… Have I missed any? Oh yeah! You should visit Portugal.'),
('Italy', 'Italy isn’t just for travelers who crave the world’s best pizzas, pastas and wines. The food (and wine) in this uniquely boot-shaped country is one reason to add it to your bucket list, but the historic cities, snow-capped mountains, pristine coastlines and endless museums will assure you that one visit is not enough.'),
('Greece', 'Want to visit Greece? Good choice! It’s a fantastic country that offers everything from beaches and islands to culture and history as well as delicious food and friendly locals.'),
('Switzerland', 'Switzerland may seem relatively small as compared to other European nations but that certainly does not mean that it has less to offer. Rather, it has set itself apart from the rest of Europe – its unparalleled landscapes, peaceful environments and cosmopolitan cities.'),
('United Kingdom', 'The United Kingdom is a great place to visit. In fact, England, Scotland, Wales and the Offshore Islands all offer great vacation and holiday destinations with something for everyone—singles, couples, and families.'),
('Uruguay', 'Uruguay’s entire southeast coast is littered with beaches. The Río de la Plata River, the widest in the world, makes up the beaches in the south. As you go eastwards, you’ll see how the river water gradually mixes with the Atlantic Ocean, creating more blue and green beaches with bigger waves.'),
('Mexico', 'Mexico is one of the year’s hottest destinations, what with its secret island escapes, Caribbean coastline and cosmopolitan capital city, as well as its thriving restaurant scene and quirky colonial towns that are ideal for day trips. '),
('Canada', 'The expanse of Canadas natural beauty, from mountains and glaciers to secluded lakes and forests, is almost unparalleled worldwide. But Canadas allure is not just the great outdoors.'),
('Vietnam', 'Holidaymakers from these four countries will be permitted entry for up to 15 days without having to acquire documentation, while an e-visa will be necessary for for trips of up to 30 days.'),
('Indonesia', 'Their itinerary has included rafting down the Ayung River and visiting the Jatiluwih rice terraces, after which they are expected to visit Jakarta, the Indonesian capital. Here are 15 reasons to follow them to the vast archipelago.   '),
('Ireland', 'With its scene-stealing natural beauty and multitude of things to see and do, Ireland is a dream tourist destination.'),
('Sri Lanka', 'Dive with blue whales in season or watch spinner dolphins leap about in Kalpitiya. Sri Lanka also has 5,800 wild elephants ambling about and the biggest concentration of leopards in the world.'),
('Kenya', 'Long after you have left Kenya, there are some things that will stay with you forever – little treasures, both tangible and intangible.'),
('Albania', 'Currently becoming one of the world’s most sought-after travel destinations, Albania is growing fast to accommodate visitors but also staying true to its strong rural culture. From beautiful nature to the more modern urban attractions, there’s so much to discover.'),
('India', 'According to the biennial World Economic Forum (WEF) Travel and Tourism Competitiveness Report, India ranks 10th best for “price competitiveness”. Luxurious accommodation is relatively affordable, eating out cost very little indeed, and you can get around the country by train for peanuts.'),
('Wales', 'If you love hearty food, a distinct culture, the outdoors, cosy pubs, fascinating traditions and breathtaking scenery then Wales is for you. It’s never easy to sum up a whole country but if you’re considering a visit to the land of song, here are the top 12 reasons why you should go ahead and do it.'),
('Morocco', 'North Africa’s Morocco is a popular destination, attracting culture lovers, backpackers, adventure travelers, couples, families, foodies, and more.'),
('Netherlands', 'Finding an excuse to visit the Netherlands is rarely difficult, thanks to the nation’s charming cities, beautiful countryside, and world-leading cultural attractions. For some additional motivation, we’ve put together the following list of top reasons to visit the Netherlands at least once.'),
('Colombia', 'You do not need to be a huge expert in the sociopolitical history of Latin America in the last half-century to know that Colombia has not always been a country you would consider as a holiday option.'),
('Philippines', 'The Philippines will never fail to amaze you. The stunning sights above and under the sea, the culture, the hospitality, the food, and of course, the friendly people willing to welcome visitors wherever and whenever.')
GO
 
/**********************************************************************************
									CITIES
**********************************************************************************/
INSERT INTO Cities (CityName, ShortInfo, CountryID)
VALUES 
('Kielce', 'First impressions of Kielce (kyel-tseh) are not likely to be positive. The town is ringed by postwar housing projects that on a rainy day, or any day, can look downright dispiriting. But dig a little deeper and you’ll find a lively city with a surprisingly elegant core.', 1),
('Wroclaw', 'Are you wondering where to go during your next trip to Europe? Next, to its most famous cities, such as London, Paris or Barcelona, there are some that few have heard of. One of them is Wroclaw.', 1),
('Krakow', 'From a booming café culture to wild nightlife, fascinating historical spots to pretty parks, there are plenty of reasons why a visit to Krakow should be on the menu this year.', 1),
('Gdansk', 'Poland’s Baltic seaside city of Gdansk has sat in the background for years as one of the most underrated cities in Europe.', 1),
('Warsaw', 'Warsaw has undergone some rapid changes in the last 20 years since the fall of communism. It has developed into a city for new business, turned into a tourist hub and really proved why this is the true capital city, ahead of previous capitals Gniezno and Kraków', 1),
('Lodz', 'What makes Lodz such a fascinating destination in Poland is how wildly different it is to other major attractions.', 1),
('Gdynia', 'You might argue that modern Gdynia is a history lesson in itself, created as it was ... such as the Emigration Museum is improving the choice of places to visit.', 1),
('Katowice', 'Katowice - the most underrated and misunderstood city in Poland, with a bright future ahead.', 1),
('Gliwice', 'Gliwice comes as a real surprise for those to determined to pay it a visit. From wooden towers to leafy gardens to historic churches, this is a city full of suprises.', 1),
('Bialystok', 'When trying to figure out how to get between Lithuania and Poland, I came across the option to travel to the city of Bialystok in far eastern', 1),
('Zagreb', 'As the inland capital of a country famous for its dazzling island-speckled coastline, Zagreb is often overlooked by travellers.', 2),
('Split', 'No longer just a launchpad to Dalmatia’s islands, Split has successfully shaken off its one-time image as an industrial backwater, reinventing itself as a city where antiquity and urban life fully intersect.', 2),
('Dubrovnik', 'Should there even be a specific reason to visit Dubrovnik? To gaze upon the Pearl of the Adriatic, a historic jewel set within pristine City Walls, is almost reason alone.', 2),
('Rijeka', 'Check out what Rijeka’s history, culture, heritage, nature have to offer… what is worth a visit while you’re here and what you will remember Rijeka by.', 2),
('Hvar', 'The island of Hvar has a reputation of being one of the most beautiful in Croatia and has been named by some travel magazines one of the most beautiful places in the World.', 2),
('Osijek', 'Visit Osijek, Croatia in the Slavonia region for both city and nature experiences - and exceptional local cuisine and wine.', 2),
('Makarska', 'Makarska has always been the center of the surrounding region known as Makarska Riviera, one of the most famous tourist destinations on the Croatian coast.', 2),
('Zadar', ' I always love thinking of the hundreds of generations of people who walked the same route when I visit towns like Zadar, the weight of history etc.', 2),
('Auckland', 'It’s no secret that Auckland is New Zealand’s largest city both population and landmass-wise. In fact, Auckland has a larger population than the whole South Island!', 3),
('Wellington', 'Wellington is a popular choice for backpackers to stay a while.', 3),
('Christchurch', 'The South Island’s largest city is not only teaming with work opportunities for backpackers, but the art work, views from the Port Hills, and surf beaches entice many to explore.', 3),
('Hamilton', 'Situated on the banks of the might Waikato River, Hamilton is the centre of the Waikato region.', 3),
('Gold Coast', 'As the closest thing Australia has to Miami, Gold Coast is a glitzy strip of modern high-rises built on 90 miles of sunshine-soaked coastline.', 4),
('Cairns', 'Everything is the opposite Down Under. Winter is summer and the further north you go, the hotter it gets.', 4),
('Darwin', 'The most laid-back city in a famously laid-back country, Darwin’s far northern location has it closer to Indonesia and Papua New Guinea than Sydney or Melbourne.', 4),
('Adelaide', 'Probably Australia’s most overlooked of the country’s five cities with populations over one million.', 4),
('Hobart', 'Hobart is a beautiful and underrated city in the equally overlooked and misunderstood island of Tasmania.', 4),
('Tokyo', 'The Tokyo Metropolis is made up of 23 Special Wards, home to upwards of 35 million people.', 5),
('Yokohama', 't is known for being Japan’s first port that officially opened to foreign trade in 1859. It’s not a stretch to say that international influences have shaped Yokohama’s character, from the city’s signature brick architecture.', 5),
('Nagoya', 'Nagoya has long been the center of Japan’s automotive and aviation manufacturing, as well as a technological hub with a growing robotics industry.', 5),
('Kyoto', 'Kyoto was the official capital of Japan for over 1,000 years and remains one of the foremost destinations to experience traditional Japanese culture.', 5)
GO

/**********************************************************************************
									CITIES
**********************************************************************************/
INSERT INTO Airports(AirportName, CityID)
VALUES
('Kielce Lotnisko Glowne', 1),	
('Kielce-Cminsk Lotnisko', 1),			   
('Kielce Lotnisko Narodowe', 1),
('Wroclaw Lotnisko Biskupin', 2),
('Lotnisko Morskie Oko', 2),
('Lotnisko Hala Stulecia', 2),			   
('Krakow Lotnisko Narodowe', 3),    
('Gdansk Lotnisko', 4),	   
('Warsaw Lotnisko Glowne Narodowe', 5), 				   
('Lodz Airport', 6),	   
('Gdynia Airport', 7),
('Katowice Airport', 8),
('Gliwice Airport', 9),
('Bialystok Airport', 10),
('Zagreb Main Airport', 11),
('Dubrava Airport', 11),
('Jelacic Airport', 11),
('Split Airport', 12),
('Cilipi Airport', 13),
('Rijeka Airport', 14),
('Hvar Airport', 15),
('Osijek Airport', 16),
('Makarska Airport', 17),
('Zadar Airport', 18),
('Auckland Airport', 19),
('Wellington Airport', 20),
('Christchurch Airport', 21),
('Hamilton Airport', 22),
('Gold Coast Airport', 23),
('Cairns Airport', 24),
('Darwin Airport', 25),
('Adelaide Airport', 26),
('Hobart Airport', 27),
('Tokyo Main Airport', 28),
('Tokyo Oyo Airport', 28),
('Tokyo Takahuma Airport', 28),
('Yokohama Airport', 29),
('Nagoya Airport', 30),
('Kyoto Airport', 31)
GO

/**********************************************************************************
									PLANES
**********************************************************************************/
INSERT INTO Planes(PlaneName, Capacity)
VALUES
('Fitovac M20','80'),
('DLearningovac M60','50'),
('Mrezar 443','80'),
('Sistemac 1010','10'),
('Coder 17','20'),
('Mostarac 1000','15'),
('Studentovic 21','60'),
('Apsolvent 333','40')
GO

/**********************************************************************************
									OFFER TYPES
**********************************************************************************/
INSERT INTO OfferTypes(TypeName, TypeDescription)
VALUES
('Type1', ''),
('Type2',''),
('Type3','')
GO

/**********************************************************************************
									OFFERS
**********************************************************************************/
INSERT INTO Offers(OfferName, StartDate, EndDate, OfferTypeID)
VALUES
('Zielona Polska', '2019-4-1', '2019-4-4', 1),
('My Perfect Summer', '2019-7-7', '2019-7-10', 1),
('Christmas Magic', '2019-12-15', '2019-12-31', 1),
('International Workers Day', '2019-5-1', '2019-5-1', 1),
('Student Month', '2019-6-1', '2019-7-1', 1),
('FIT Sky', '2019-5-1', '2019-5-1', 1)
GO

/**********************************************************************************
									USER ROLES
**********************************************************************************/
INSERT INTO UserRoles(Title, IsAbleToAddNewUsers, IsAbleToAddNewOffers, IsAbleToAddNewFlights, IsAbleToAddNewPlanes, IsAbleToAddUserCredits, IsAbleToAddNewReservations, IsAbleToAddNewPlaces, IsSuperUser)
VALUES
('Administrator', 1,1,1,1,1,1,1,1),
('Boss', 1,0,0,0,0,0,0,0),
('Flight Offers Manager',0,1,1,1,0,0,1,0),
('Cashier',0,0,0,0,1,1,0,0),
('FIT Member',0,0,0,0,0,1,0,0)
GO

/**********************************************************************************
									MEMBERSHIP TYPES
**********************************************************************************/
INSERT INTO MembershipTypes(Title, ShortInfo, MembershipPrice, IsPriorityAvailable, IsExtraBaggageAvailable, IsFITSandwichAvailable, IsSeatChangeAvailable, IsBonusDrinkAvailable, IsBonusMealAvailable, BasicTicketDiscount, BasicFoodDrinkDiscount)
VALUES
('Basic', 'Default Membership Type', 0, 0, 0, 0, 0, 0, 0, 0, 0),
('Blue', 'With Blue FIT membership you have a priority while checking in and you are able to take the extra baggage.', 100, 1, 1, 0, 0, 0, 0, 0, 0),
('Gold', 'With Gold FIT membership you will get special FIT sandwich before every flight and if you would like to change a seat during the flight and if there are some other free seats, you will be able to do it.', 200, 1, 1, 1, 1, 0, 0, 0, 0),
('Platinum', 'With Platinum FIT membership you will get one extra meal and one extra drink for free.', 300, 1, 1, 1, 1, 1, 1, 0, 0),
('Diamond', 'With Diamond FIT membership you will get an additional discount for your ticket as long as for all meals and drinks in the FIT menu.', 400, 1, 1, 1, 1, 1, 1, 1, 1)
GO

/**********************************************************************************
									USERS
**********************************************************************************/
INSERT INTO Users(FirstName, LastName, BirthDate, Gender, Username, Email, ContactNumber, Picture, Credit, StartDate, isActive, UserRoleID, MembershipTypeID)
VALUES
('Josip', 'Rezic', GETDATE(), 'M', 'josiprezic', 'josip.rezic@edu.fit.ba', '063124542', NULL, 0, GETDATE(), 1, 1, 5),
('Bosko', 'Bossovic', GETDATE(), 'M', 'boskobossovic', 'bosko.bossovic@edu.fit.ba', '312123534', NULL, 0, GETDATE(), 1, 2, 5),
('Letelko', 'Naletilic', GETDATE(), 'M', 'naletilic990', 'letelko@edu.fit.ba', '112343237', NULL, 0, GETDATE(), 1, 3, 1),
('Blagajka', 'Blagajevic', GETDATE(), 'Z', 'blagajka123', 'blagajka@edu.fit.ba', '653866555', NULL, 0, GETDATE(), 1, 4, 1),
('Fitovac', 'Studentovic', GETDATE(), 'M', 'fitovac111', 'fitovac@edu.fit.ba', '999966555', NULL, 0, GETDATE(), 1, 5, 1)
GO

/**********************************************************************************
									FLIGHTS
**********************************************************************************/
INSERT INTO Flights(CityID, DestinationAirportID, OfferID, PlaneID, AddedByUserID, AddedDate, VoucherCode, VoucherDiscountPercentage, StartDate, EndDate, PilotFullName, FlightDuration, Price, ShortInfo, Picture, Notes, AvailableToMemberTypeID, IsActive)
VALUES
(1, 1, 1, 1, 3, GETDATE(), 'SDFBJ54GH', 0.2, GETDATE(), GETDATE(), 'Pilotko Pilotovicz', TIMEFROMPARTS(1,1,1,1,1), 100, 'First FIT flight', NULL, '', 1, 1),
(2, 3, 1, 2, 3, GETDATE(), 'WRO43ASDS', 0.2, GETDATE(), GETDATE(), 'Pilotko Pilotovicz', TIMEFROMPARTS(2,2,2,2,2), 100, 'Wroclaw is the most beautiful city in Poland.', NULL, '', 1, 1)
GO

/**********************************************************************************
									RESERVATIONS
**********************************************************************************/