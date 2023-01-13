using Microsoft.EntityFrameworkCore.Migrations;

namespace CarsSelling.Migrations
{
    public partial class DataAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "BodyTypeId", "Contact", "Description", "Displacement", "FuelTypeId", "ImagePath", "MakeId", "Model", "Power", "Price", "Year" },
                values: new object[,]
                {
                    { 1, 3, "5069324472", "The standard features of the Audi A4 40 Premium include 2.0L I - 4 201hp intercooled turbo engine, 7 - speed auto - shift manual transmission with overdrive 4 - wheel anti -lock brakes(ABS), side seat mounted airbags, SIDEGUARD curtain 1st and 2nd row overhead airbags, driver and passenger knee airbag, airbag occupancy sensor, automatic air conditioning, and cruise control.", 2000m, 2, "~/ImageUpload/659281fd-f4d4-4a40-a399-7ca60c0e6366.jpg", 1, "A4", 201, 39100m, 2022 },
                    { 2, 1, "6046927694", "The size of the DS5 is compact (only 4,53 m), and the trunk volume is 468 liters, with the rear seats folded down to 1.288 liters.", 1598m, 1, "~/ImageUpload/dbf2f3a3-e732-4d58-997e-904c9e5d4fc7.jpg", 2, "DS5", 156, 11450m, 2011 },
                    { 3, 3, "6147274670", "The Dacia Logan is a more family oriented vehicle. You get a huge load space – up to 1,518 litres with the seats folded flat – which is bigger than most of its mainstream competitors. ", 1400m, 2, "~/ImageUpload/3a20cb03-dade-418c-9f60-787f39ab207c.jpg", 4, "Logan", 90, 8360m, 2013 },
                    { 4, 2, "3063027591", "The 2022 BMW 4 Series blends class and performance in a way that few other luxury small cars can.The BMW 4 Series is an upmarket coupe that seats four. ", 1983m, 1, "~/ImageUpload/cd09419e-9509-4719-bcb2-123df35b0640.jpg", 3, "4", 228, 39870m, 2021 },
                    { 5, 1, "4038889985", "This small two-door Audi hatch came equipped with a 2.0-liter turbocharged four-cylinder engine, with an optional diesel power plant.", 1197m, 2, "~/ImageUpload/2872ccba-ccc1-401a-870e-a76bff9d9503.jpg", 1, "A3", 110, 9995m, 2016 },
                    { 6, 4, "5062111872", "Citroen C5 Aircross is currently available in Diesel engine. The 1997 cc Diesel engine generates a power of 174.33@3750rpm and a torque of 400Nm@2000rpm.", 1499m, 2, "~/ImageUpload/92ebbdc6-5e7b-4d8e-a3e6-9fc6fa143eae.jpg", 2, "C5", 130, 30000m, 2022 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
