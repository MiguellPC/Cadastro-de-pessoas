using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PIM_VIII.Migrations
{
    public partial class Third : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Telefone_Pessoa_pessoaID",
                table: "Telefone");

            migrationBuilder.DropIndex(
                name: "IX_Telefone_pessoaID",
                table: "Telefone");

            migrationBuilder.DropColumn(
                name: "pessoaID",
                table: "Telefone");

            migrationBuilder.AddColumn<int>(
                name: "telefonesID",
                table: "Pessoa",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Pessoa_telefonesID",
                table: "Pessoa",
                column: "telefonesID");

            migrationBuilder.AddForeignKey(
                name: "FK_Pessoa_Telefone_telefonesID",
                table: "Pessoa",
                column: "telefonesID",
                principalTable: "Telefone",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pessoa_Telefone_telefonesID",
                table: "Pessoa");

            migrationBuilder.DropIndex(
                name: "IX_Pessoa_telefonesID",
                table: "Pessoa");

            migrationBuilder.DropColumn(
                name: "telefonesID",
                table: "Pessoa");

            migrationBuilder.AddColumn<int>(
                name: "pessoaID",
                table: "Telefone",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Telefone_pessoaID",
                table: "Telefone",
                column: "pessoaID");

            migrationBuilder.AddForeignKey(
                name: "FK_Telefone_Pessoa_pessoaID",
                table: "Telefone",
                column: "pessoaID",
                principalTable: "Pessoa",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
