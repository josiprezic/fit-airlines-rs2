using Microsoft.EntityFrameworkCore.Migrations;

namespace FitAirlines.WebAPI.Migrations
{
    public partial class seedCountries2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "CountryID", "CountryName", "Picture", "ShortInfo" },
                values: new object[,]
                {
                    { 1, "Poland", null, "Poland may not be an obvious holiday destination, but it has a lot to offer. It’s the perfect place for a weekend getaway, a skiing trip, or a peaceful beach escape. From impressive natural beauty, to rich history and mouthwatering food, here is why Poland should be number one on your travel wish list." },
                    { 17, "United Kingdom", null, "The United Kingdom is a great place to visit. In fact, England, Scotland, Wales and the Offshore Islands all offer great vacation and holiday destinations with something for everyone—singles, couples, and families." },
                    { 16, "Switzerland", null, "Switzerland may seem relatively small as compared to other European nations but that certainly does not mean that it has less to offer. Rather, it has set itself apart from the rest of Europe – its unparalleled landscapes, peaceful environments and cosmopolitan cities." },
                    { 15, "Greece", null, "Want to visit Greece? Good choice! It’s a fantastic country that offers everything from beaches and islands to culture and history as well as delicious food and friendly locals." },
                    { 14, "Italy", null, "Italy isn’t just for travelers who crave the world’s best pizzas, pastas and wines. The food (and wine) in this uniquely boot-shaped country is one reason to add it to your bucket list, but the historic cities, snow-capped mountains, pristine coastlines and endless museums will assure you that one visit is not enough." },
                    { 13, "Portugal", null, "I bet you’ve probably checked most European destinations off your travel bucket list by now: the UK, France, Spain, Italy, Germany, Ireland, Austria, Switzerland… Have I missed any? Oh yeah! You should visit Portugal." },
                    { 12, "Spain", null, "Spain really does have it all, from incredible landscapes and beaches, to world-famous cuisine and rich history – not to mention fantastic museums and striking architecture." },
                    { 11, "France", null, "I do not need to convince you to come over to visit or live in France. France is still the top holiday’s destination in the world. Everyone seems to dream about coming to France and everyone is fascinated by France & French people and language of course." },
                    { 18, "Uruguay", null, "Uruguay’s entire southeast coast is littered with beaches. The Río de la Plata River, the widest in the world, makes up the beaches in the south. As you go eastwards, you’ll see how the river water gradually mixes with the Atlantic Ocean, creating more blue and green beaches with bigger waves." },
                    { 10, "Germany", null, "There’s no way around it: Germany has firmly established itself as a first rate travel destination, not just for the well-informed few but for the happy-go-lucky crowds of tourists from all over the world too; in case anyone wonders why: this country has much more to it than meets the eye (no rhyme intended)." },
                    { 8, "Botswana", null, "Botswana is rich in culture and wildlife, and here Botswana Holidays gives us not one, but six reasons that will definitely inspire you to visit this amazing country!" },
                    { 7, "Nepal", null, "Nepal still evades travellers’ bucket lists, and we for one can’t understand why: the views are stunning (you have jungle, lakes, and mountains), the people are friendly, it’s home to once-in-a-lifetime treks and it’s safe and affordable. So what are you waiting for? Here are our 17 reasons to visit Nepal in 2019." },
                    { 6, "Thailand", null, "Whether visitors are staying in the Land of Smiles for one day or one month, Thai food is so delicious and diverse that visitors should never have to eat the same dish twice. Visitors will even find that the cuisine changes as their location does, keeping their food options interesting as they venture from one city to the next." },
                    { 5, "Japan", null, "All the beautiful ancient Buddhist temples and Shinto shrines are reason enough to visit Japan. One of the best-preserved cities in Japan, Kyoto offers something like 2,000 Buddhist temples and shrines within the limits of the Kansai Region city, while Nara is home to no less than 8 UNESCO World Heritage Sites." },
                    { 4, "Australia", null, "One of the most popular reasons to visit Australia is the snorkelling and scuba diving around the Great Barrier Reef. It’s the world’s largest living organism (so big that it has its own post box), and the entire Reef is bigger than the United Kingdom, Holland and Switzerland combined!" },
                    { 3, "New Zeland", null, "New Zealand is a tiny country. Made up of two rather remote islands (and many smaller ones) and with a population of just over four million people, it is not the most acessible place in the world to visit. Yet it remains one of the world greatest tourist destinations." },
                    { 2, "Croatia", null, "Thanks in part to that dazzling World Cup run, Croatia is buzzier than ever, although each year increasing numbers of travelers seek out this idyllic haven on the Adriatic, known for its richly historic and evocative cities, exceptional food and wine, and heavenly sailing waters." },
                    { 9, "Latvia", null, "Also known to be the pearl of Baltic States, Latvia is located in the Baltic region in Northern Europe. It has an enchanting history, long and well established traditions and rich culture." },
                    { 19, "Mexico", null, "Mexico is one of the year’s hottest destinations, what with its secret island escapes, Caribbean coastline and cosmopolitan capital city, as well as its thriving restaurant scene and quirky colonial towns that are ideal for day trips. " }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 19);
        }
    }
}
