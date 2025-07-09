using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetShopScheduling.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "agendamento",
                columns: table => new
                {
                    id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    id_cliente = table.Column<long>(type: "INTEGER", nullable: false),
                    id_pet = table.Column<long>(type: "INTEGER", nullable: false),
                    vacina = table.Column<bool>(type: "INTEGER", nullable: false),
                    id_vacina = table.Column<long>(type: "INTEGER", nullable: true),
                    banho = table.Column<bool>(type: "INTEGER", nullable: false),
                    tosa = table.Column<bool>(type: "INTEGER", nullable: false),
                    tipo_tosa = table.Column<int>(type: "INTEGER", nullable: true),
                    dia = table.Column<DateOnly>(type: "TEXT", nullable: false),
                    horario = table.Column<DateTime>(type: "TEXT", nullable: false),
                    observacao = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_agendamento", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "cliente",
                columns: table => new
                {
                    id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    nome = table.Column<string>(type: "TEXT", nullable: false),
                    cpf = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cliente", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "endereco_usuario",
                columns: table => new
                {
                    id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    id_cliente = table.Column<long>(type: "INTEGER", nullable: false),
                    cep = table.Column<string>(type: "TEXT", nullable: true),
                    bairro = table.Column<string>(type: "TEXT", nullable: true),
                    rua = table.Column<string>(type: "TEXT", nullable: true),
                    numero = table.Column<string>(type: "TEXT", nullable: true),
                    observacao = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_endereco_usuario", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "pet",
                columns: table => new
                {
                    id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    id_cliente = table.Column<long>(type: "INTEGER", nullable: false),
                    identificação = table.Column<string>(type: "TEXT", nullable: true),
                    tipo_animal = table.Column<int>(type: "INTEGER", nullable: false),
                    nome = table.Column<string>(type: "TEXT", nullable: true),
                    data_nascimento = table.Column<DateOnly>(type: "TEXT", nullable: true),
                    raca = table.Column<string>(type: "TEXT", nullable: true),
                    tamanho = table.Column<int>(type: "INTEGER", nullable: true),
                    observação = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pet", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "servico",
                columns: table => new
                {
                    id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    nome = table.Column<string>(type: "TEXT", nullable: false),
                    descricao = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_servico", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "telefone_usuario",
                columns: table => new
                {
                    id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    id_cliente = table.Column<long>(type: "INTEGER", nullable: false),
                    numero = table.Column<string>(type: "TEXT", nullable: false),
                    tem_whatsapp = table.Column<bool>(type: "INTEGER", nullable: false),
                    observação = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_telefone_usuario", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "vacina",
                columns: table => new
                {
                    id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    nome = table.Column<string>(type: "TEXT", nullable: false),
                    fabricante = table.Column<string>(type: "TEXT", nullable: true),
                    estoque = table.Column<int>(type: "INTEGER", nullable: false),
                    lote = table.Column<string>(type: "TEXT", nullable: true),
                    validade = table.Column<DateOnly>(type: "TEXT", nullable: false),
                    status_vacina = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vacina", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "vacina_reservada",
                columns: table => new
                {
                    id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    id_vacina = table.Column<long>(type: "INTEGER", nullable: false),
                    id_agendamento = table.Column<long>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vacina_reservada", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "agendamento_pet",
                columns: table => new
                {
                    id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    id_agendamento = table.Column<long>(type: "INTEGER", nullable: false),
                    id_pet = table.Column<long>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_agendamento_pet", x => x.id);
                    table.ForeignKey(
                        name: "FK_agendamento_pet_agendamento_id_agendamento",
                        column: x => x.id_agendamento,
                        principalTable: "agendamento",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_agendamento_pet_pet_id_pet",
                        column: x => x.id_pet,
                        principalTable: "pet",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "agendamento_vacina",
                columns: table => new
                {
                    id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    id_agendamento = table.Column<long>(type: "INTEGER", nullable: false),
                    id_vacina = table.Column<long>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_agendamento_vacina", x => x.id);
                    table.ForeignKey(
                        name: "FK_agendamento_vacina_agendamento_id_agendamento",
                        column: x => x.id_agendamento,
                        principalTable: "agendamento",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_agendamento_vacina_vacina_id_vacina",
                        column: x => x.id_vacina,
                        principalTable: "vacina",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_agendamento_pet_id_agendamento",
                table: "agendamento_pet",
                column: "id_agendamento");

            migrationBuilder.CreateIndex(
                name: "IX_agendamento_pet_id_pet",
                table: "agendamento_pet",
                column: "id_pet");

            migrationBuilder.CreateIndex(
                name: "IX_agendamento_vacina_id_agendamento",
                table: "agendamento_vacina",
                column: "id_agendamento");

            migrationBuilder.CreateIndex(
                name: "IX_agendamento_vacina_id_vacina",
                table: "agendamento_vacina",
                column: "id_vacina");

            migrationBuilder.CreateIndex(
                name: "IX_cliente_nome",
                table: "cliente",
                column: "nome");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "agendamento_pet");

            migrationBuilder.DropTable(
                name: "agendamento_vacina");

            migrationBuilder.DropTable(
                name: "cliente");

            migrationBuilder.DropTable(
                name: "endereco_usuario");

            migrationBuilder.DropTable(
                name: "servico");

            migrationBuilder.DropTable(
                name: "telefone_usuario");

            migrationBuilder.DropTable(
                name: "vacina_reservada");

            migrationBuilder.DropTable(
                name: "pet");

            migrationBuilder.DropTable(
                name: "agendamento");

            migrationBuilder.DropTable(
                name: "vacina");
        }
    }
}
