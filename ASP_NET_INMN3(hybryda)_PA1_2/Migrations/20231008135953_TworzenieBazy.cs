using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASP_NET_INMN3_hybryda__PA1_2.Migrations
{
    /// <inheritdoc />
    public partial class TworzenieBazy : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Miasta",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nazwa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Populacja = table.Column<decimal>(type: "decimal(20,0)", nullable: false),
                    Powierzchnia = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DataZałożenia = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Miasta", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Miasta");
        }
    }
}
