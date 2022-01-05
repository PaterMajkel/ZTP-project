using Microsoft.EntityFrameworkCore.Migrations;

namespace ZTP.EntityFramework.Migrations
{
    public partial class forgotToMakeMakerNullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Commissions_UserInfos_TakerId",
                table: "Commissions");

            migrationBuilder.DropForeignKey(
                name: "FK_Offers_UserInfos_UserId",
                table: "Offers");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Offers",
                newName: "UserInfoId");

            migrationBuilder.RenameIndex(
                name: "IX_Offers_UserId",
                table: "Offers",
                newName: "IX_Offers_UserInfoId");

            migrationBuilder.AddColumn<int>(
                name: "CommissionId",
                table: "Offers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "TakerId",
                table: "Commissions",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Offers_CommissionId",
                table: "Offers",
                column: "CommissionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Commissions_UserInfos_TakerId",
                table: "Commissions",
                column: "TakerId",
                principalTable: "UserInfos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Offers_Commissions_CommissionId",
                table: "Offers",
                column: "CommissionId",
                principalTable: "Commissions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Offers_UserInfos_UserInfoId",
                table: "Offers",
                column: "UserInfoId",
                principalTable: "UserInfos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Commissions_UserInfos_TakerId",
                table: "Commissions");

            migrationBuilder.DropForeignKey(
                name: "FK_Offers_Commissions_CommissionId",
                table: "Offers");

            migrationBuilder.DropForeignKey(
                name: "FK_Offers_UserInfos_UserInfoId",
                table: "Offers");

            migrationBuilder.DropIndex(
                name: "IX_Offers_CommissionId",
                table: "Offers");

            migrationBuilder.DropColumn(
                name: "CommissionId",
                table: "Offers");

            migrationBuilder.RenameColumn(
                name: "UserInfoId",
                table: "Offers",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Offers_UserInfoId",
                table: "Offers",
                newName: "IX_Offers_UserId");

            migrationBuilder.AlterColumn<int>(
                name: "TakerId",
                table: "Commissions",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Commissions_UserInfos_TakerId",
                table: "Commissions",
                column: "TakerId",
                principalTable: "UserInfos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Offers_UserInfos_UserId",
                table: "Offers",
                column: "UserId",
                principalTable: "UserInfos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
