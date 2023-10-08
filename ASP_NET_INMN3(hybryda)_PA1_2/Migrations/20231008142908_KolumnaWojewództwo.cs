using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASP_NET_INMN3_hybryda__PA1_2.Migrations
{
    /// <inheritdoc />
    public partial class KolumnaWojewództwo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Województwo",
                table: "Miasta",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Województwo",
                table: "Miasta");
        }
    }
}
