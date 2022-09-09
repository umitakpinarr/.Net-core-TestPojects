using Microsoft.EntityFrameworkCore.Migrations;

namespace mulk.Migrations
{
    public partial class mig4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "note",
                table: "rents");

            migrationBuilder.DropColumn(
                name: "tenantId",
                table: "rents");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "rents",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "rents",
                newName: "status");

            migrationBuilder.RenameColumn(
                name: "type",
                table: "rents",
                newName: "adress");

            migrationBuilder.AddColumn<string>(
                name: "Surname",
                table: "tenants",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "mail",
                table: "tenants",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "price",
                table: "rents",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Surname",
                table: "tenants");

            migrationBuilder.DropColumn(
                name: "mail",
                table: "tenants");

            migrationBuilder.RenameColumn(
                name: "status",
                table: "rents",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "rents",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "adress",
                table: "rents",
                newName: "type");

            migrationBuilder.AlterColumn<string>(
                name: "price",
                table: "rents",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "note",
                table: "rents",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "tenantId",
                table: "rents",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
