using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PIM_VIII.Migrations
{
    public partial class Second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Telefone_Pessoa_PessoaID",
                table: "Telefone");

            migrationBuilder.RenameColumn(
                name: "PessoaID",
                table: "Telefone",
                newName: "pessoaID");

            migrationBuilder.RenameIndex(
                name: "IX_Telefone_PessoaID",
                table: "Telefone",
                newName: "IX_Telefone_pessoaID");

            migrationBuilder.AlterColumn<int>(
                name: "pessoaID",
                table: "Telefone",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "tipoID",
                table: "Telefone",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "TipoTelefone",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tipo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoTelefone", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Telefone_tipoID",
                table: "Telefone",
                column: "tipoID");

            migrationBuilder.AddForeignKey(
                name: "FK_Telefone_Pessoa_pessoaID",
                table: "Telefone",
                column: "pessoaID",
                principalTable: "Pessoa",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Telefone_TipoTelefone_tipoID",
                table: "Telefone",
                column: "tipoID",
                principalTable: "TipoTelefone",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Telefone_Pessoa_pessoaID",
                table: "Telefone");

            migrationBuilder.DropForeignKey(
                name: "FK_Telefone_TipoTelefone_tipoID",
                table: "Telefone");

            migrationBuilder.DropTable(
                name: "TipoTelefone");

            migrationBuilder.DropIndex(
                name: "IX_Telefone_tipoID",
                table: "Telefone");

            migrationBuilder.DropColumn(
                name: "tipoID",
                table: "Telefone");

            migrationBuilder.RenameColumn(
                name: "pessoaID",
                table: "Telefone",
                newName: "PessoaID");

            migrationBuilder.RenameIndex(
                name: "IX_Telefone_pessoaID",
                table: "Telefone",
                newName: "IX_Telefone_PessoaID");

            migrationBuilder.AlterColumn<int>(
                name: "PessoaID",
                table: "Telefone",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Telefone_Pessoa_PessoaID",
                table: "Telefone",
                column: "PessoaID",
                principalTable: "Pessoa",
                principalColumn: "ID");
        }
    }
}
