using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProdQ.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Finalize : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "product",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    code = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    description = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    price = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    createddate = table.Column<DateOnly>(type: "date", nullable: true),
                    createdby = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__product__3213E83FA4E2ADC2", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "qoute",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    subject = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: false),
                    validUntil = table.Column<DateOnly>(type: "date", nullable: true),
                    totalPrice = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    createddate = table.Column<DateOnly>(type: "date", nullable: true),
                    createdby = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__qoute__3213E83F9F83ED40", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "qouteItem",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    qouteId = table.Column<int>(type: "int", nullable: false),
                    productId = table.Column<int>(type: "int", nullable: false),
                    quantity = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__qouteIte__3213E83FA3B74D5C", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "user",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    role = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    fullname = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    createddate = table.Column<DateOnly>(type: "date", nullable: true),
                    createdby = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__user__3213E83FCFF4151D", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "product");

            migrationBuilder.DropTable(
                name: "qoute");

            migrationBuilder.DropTable(
                name: "qouteItem");

            migrationBuilder.DropTable(
                name: "user");
        }
    }
}
