using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ETicaretSitesi.Migrations
{
    public partial class AddSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Şifre" },
                values: new object[] { new DateTime(2022, 11, 7, 13, 41, 54, 463, DateTimeKind.Local).AddTicks(7926), "$2a$11$FtGyAQIMYFOd0npZQVZrbeYhwZH5hQ7tHyqgNoC.hkmIfsGgzK4HS" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Şifre", "Kullanıcı Adı" },
                values: new object[] { new DateTime(2022, 11, 7, 13, 41, 54, 464, DateTimeKind.Local).AddTicks(5863), "$2a$11$tS6tC.QF8IDB9b80RAHTWOGJLnbQ.Krj0nfgo7uUlXM4f8a.remDW", "Mustafa" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Şifre" },
                values: new object[] { new DateTime(2022, 11, 7, 13, 39, 16, 12, DateTimeKind.Local).AddTicks(4410), "$2a$11$IzRisKbPFXqNpwJW6tigEOWywJXNDOADj//MTeuZZv9CbAEllEvoa" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Şifre", "Kullanıcı Adı" },
                values: new object[] { new DateTime(2022, 11, 7, 13, 39, 16, 13, DateTimeKind.Local).AddTicks(3058), "$2a$11$Q64P.ybDc9ZzqeioMKqIU.fe8BnRMOjoz2nwt/7FhUQOXuLPCZP4O", "adminStrator" });
        }
    }
}
