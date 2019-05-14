using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DB_Utility.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LikeProducts",
                columns: table => new
                {
                    LikeProductId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LikeProducts", x => x.LikeProductId);
                });

            migrationBuilder.CreateTable(
                name: "ProductDates",
                columns: table => new
                {
                    ProductDateId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    P_Date = table.Column<DateTime>(nullable: false),
                    E_Date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductDates", x => x.ProductDateId);
                });

            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    PersonId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    likeProductsLikeProductId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.PersonId);
                    table.ForeignKey(
                        name: "FK_Persons_LikeProducts_likeProductsLikeProductId",
                        column: x => x.likeProductsLikeProductId,
                        principalTable: "LikeProducts",
                        principalColumn: "LikeProductId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ShoppingCards",
                columns: table => new
                {
                    ShoppingCardId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    personid = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCards", x => x.ShoppingCardId);
                    table.ForeignKey(
                        name: "FK_ShoppingCards_Persons_personid",
                        column: x => x.personid,
                        principalTable: "Persons",
                        principalColumn: "PersonId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    ProductDateId = table.Column<int>(nullable: true),
                    SerialNumber = table.Column<string>(nullable: false),
                    NumberOfExsistance = table.Column<long>(nullable: false),
                    LikeProductId = table.Column<int>(nullable: true),
                    ShoppingCardId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Products_LikeProducts_LikeProductId",
                        column: x => x.LikeProductId,
                        principalTable: "LikeProducts",
                        principalColumn: "LikeProductId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Products_ProductDates_ProductDateId",
                        column: x => x.ProductDateId,
                        principalTable: "ProductDates",
                        principalColumn: "ProductDateId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Products_ShoppingCards_ShoppingCardId",
                        column: x => x.ShoppingCardId,
                        principalTable: "ShoppingCards",
                        principalColumn: "ShoppingCardId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Persons_likeProductsLikeProductId",
                table: "Persons",
                column: "likeProductsLikeProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_LikeProductId",
                table: "Products",
                column: "LikeProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductDateId",
                table: "Products",
                column: "ProductDateId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ShoppingCardId",
                table: "Products",
                column: "ShoppingCardId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCards_personid",
                table: "ShoppingCards",
                column: "personid",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "ProductDates");

            migrationBuilder.DropTable(
                name: "ShoppingCards");

            migrationBuilder.DropTable(
                name: "Persons");

            migrationBuilder.DropTable(
                name: "LikeProducts");
        }
    }
}
