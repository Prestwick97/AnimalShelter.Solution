using Microsoft.EntityFrameworkCore.Migrations;

namespace AnimalShelter.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 1,
                column: "Info",
                value: "Lovely orange kitty, very nice and lovely.");

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "AnimalId", "Age", "Gender", "Info", "Name", "Species" },
                values: new object[,]
                {
                    { 2, 2, "male", "Lovely doggo, very nice and snuggly black lab.", "Charlitan", "dog" },
                    { 3, 1, "male", "Black cat, loves to snuggle.", "Maxamillion", "cat" },
                    { 4, 4, "female", "Kind and loving calico, occasionally fiesty.", "Hillary", "cat" },
                    { 5, 300, "female", "Purple kitty, ancient and full of wisdom. Great pal.", "Heceta", "cat" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 1,
                column: "Info",
                value: "Lovely kitty, very nice and lovely.");
        }
    }
}
