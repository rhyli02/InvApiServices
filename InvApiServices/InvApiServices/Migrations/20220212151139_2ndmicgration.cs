using Microsoft.EntityFrameworkCore.Migrations;

namespace InvApiServices.Migrations
{
    public partial class _2ndmicgration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ClientAccount",
                table: "Terms",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ClientAccount",
                table: "Suppliers",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ClientAccount",
                table: "Shipments",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ClientAccount",
                table: "SalesMasterDatas",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ClientAccount",
                table: "PurchaseOrders",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SupplierId",
                table: "PurchaseOrders",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ClientAccount",
                table: "Products",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ClientAccount",
                table: "Customers",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ClientAccount",
                table: "ApprovalTransactions",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ClientAccount",
                table: "ApprovalAssignments",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClientAccount",
                table: "Terms");

            migrationBuilder.DropColumn(
                name: "ClientAccount",
                table: "Suppliers");

            migrationBuilder.DropColumn(
                name: "ClientAccount",
                table: "Shipments");

            migrationBuilder.DropColumn(
                name: "ClientAccount",
                table: "SalesMasterDatas");

            migrationBuilder.DropColumn(
                name: "ClientAccount",
                table: "PurchaseOrders");

            migrationBuilder.DropColumn(
                name: "SupplierId",
                table: "PurchaseOrders");

            migrationBuilder.DropColumn(
                name: "ClientAccount",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ClientAccount",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "ClientAccount",
                table: "ApprovalTransactions");

            migrationBuilder.DropColumn(
                name: "ClientAccount",
                table: "ApprovalAssignments");
        }
    }
}
