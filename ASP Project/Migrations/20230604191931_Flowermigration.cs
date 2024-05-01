using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ASP_Project.Migrations
{
    public partial class Flowermigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    minPrice = table.Column<int>(type: "int", nullable: false),
                    maxPrice = table.Column<int>(type: "int", nullable: false),
                    img = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Flowers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Price = table.Column<float>(type: "float", nullable: false),
                    Description = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Color = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdCategory = table.Column<int>(type: "int", nullable: false),
                    img = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CategoryId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Flowers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Flowers_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "img", "maxPrice", "minPrice" },
                values: new object[,]
                {
                    { 1, "Рози", "/icon/mainroze.jpg", 5000, 400 },
                    { 2, "Тюльпани", "/icon/maintulpan.jpg", 6000, 250 },
                    { 3, "Лилии", "/icon/mainlilii.jpg", 8500, 300 },
                    { 4, "Гвоздики", "/icon/maingvozdiki.jpg", 7000, 550 },
                    { 5, "Півонії", "/icon/mainpioni.jpg", 7500, 385 }
                });

            migrationBuilder.InsertData(
                table: "Flowers",
                columns: new[] { "Id", "CategoryId", "Color", "Description", "IdCategory", "Price", "img" },
                values: new object[,]
                {
                    { 18, null, "Білий", "Lorem ipsum dolor sit amet consectetur adipisicing elit.", 5, 45f, "/icon/pioni/Білий.jpg" },
                    { 17, null, "Фіолетовий", "Lorem ipsum dolor sit amet consectetur adipisicing elit.", 5, 56f, "/icon/pioni/Фіолетовий.jpg" },
                    { 16, null, "Рожевий", "Lorem ipsum dolor sit amet consectetur adipisicing elit.", 4, 97f, "/icon/gvozdiki/Рожевий.jpg" },
                    { 15, null, "Червоний", "Lorem ipsum dolor sit amet consectetur adipisicing elit.", 4, 56f, "/icon/gvozdiki/Червоний.jpg" },
                    { 14, null, "Фіолетовий", "Lorem ipsum dolor sit amet consectetur adipisicing elit.", 4, 56f, "/icon/gvozdiki/Фіолетовий.jpg" },
                    { 13, null, "Синій", "Lorem ipsum dolor sit amet consectetur adipisicing elit.", 4, 68f, "/icon/gvozdiki/Синій.jpg" },
                    { 12, null, "Рожевий", "Lorem ipsum dolor sit amet consectetur adipisicing elit.", 3, 78f, "/icon/lilii/Рожевий.jpg" },
                    { 11, null, "Червоний", "Lorem ipsum dolor sit amet consectetur adipisicing elit.", 3, 235f, "/icon/lilii/Червоний.jpg" },
                    { 10, null, "Синій", "Lorem ipsum dolor sit amet consectetur adipisicing elit.", 3, 34f, "/icon/lilii/Синій.jpg" },
                    { 8, null, "Фіолетовий", "Lorem ipsum dolor sit amet consectetur adipisicing elit.", 2, 123f, "/icon/tulpan/Фіолетовий.jpg" },
                    { 19, null, "Синій", "Lorem ipsum dolor sit amet consectetur adipisicing elit.", 5, 68f, "/icon/pioni/Синій.jpg" },
                    { 7, null, "Рожевий", "Lorem ipsum dolor sit amet consectetur adipisicing elit.", 2, 75f, "/icon/tulpan/Рожевий.jpg" },
                    { 6, null, "Жовтий", "Lorem ipsum dolor sit amet consectetur adipisicing elit.", 2, 80f, "/icon/tulpan/Жовтий.jpg" },
                    { 5, null, "Червоний", "Lorem ipsum dolor sit amet consectetur adipisicing elit.", 2, 80f, "/icon/tulpan/Червоний.jpg" },
                    { 4, null, "Рожевий", "Lorem ipsum dolor sit amet consectetur adipisicing elit.", 1, 80f, "/icon/roze/Рожевий.jpg" },
                    { 3, null, "Зелений", "Lorem ipsum dolor sit amet consectetur adipisicing elit.", 1, 300f, "/icon/roze/Зелений.jpg" },
                    { 2, null, "Жовтий", "Lorem ipsum dolor sit amet consectetur adipisicing elit.", 1, 25f, "/icon/roze/Жовтий.jpg" },
                    { 1, null, "Червоний", "Lorem ipsum dolor sit amet consectetur adipisicing elit.", 1, 50f, "/icon/roze/Червоний.jpg" },
                    { 9, null, "Білий", "Lorem ipsum dolor sit amet consectetur adipisicing elit.", 3, 46f, "/icon/lilii/Білий.jpg" },
                    { 20, null, "Червоний", "Lorem ipsum dolor sit amet consectetur adipisicing elit.", 5, 46f, "/icon/pioni/Червоний.jpg" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Flowers_CategoryId",
                table: "Flowers",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Flowers");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
