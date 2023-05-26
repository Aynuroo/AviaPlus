using Microsoft.EntityFrameworkCore.Migrations;

namespace AviaPlus.Migrations
{
    public partial class AddIdColumnsToFlight : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TicketId",
                table: "Flights",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Flights_TicketId",
                table: "Flights",
                column: "TicketId");

            migrationBuilder.AddForeignKey(
                name: "FK_Flights_Tickets_TicketId",
                table: "Flights",
                column: "TicketId",
                principalTable: "Tickets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Flights_Tickets_TicketId",
                table: "Flights");

            migrationBuilder.DropIndex(
                name: "IX_Flights_TicketId",
                table: "Flights");

            migrationBuilder.DropColumn(
                name: "TicketId",
                table: "Flights");
        }
    }
}
