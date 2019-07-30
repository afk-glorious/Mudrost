using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace AFKArena.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Heroes",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Name = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    Tier = table.Column<int>(nullable: false),
                    Type = table.Column<int>(nullable: false),
                    Faction = table.Column<int>(nullable: false),
                    Health = table.Column<long>(nullable: false),
                    Attack = table.Column<long>(nullable: false),
                    Defense = table.Column<long>(nullable: false),
                    CritRating = table.Column<double>(nullable: false),
                    Accuracy = table.Column<long>(nullable: false),
                    Dodge = table.Column<long>(nullable: false),
                    Haste = table.Column<long>(nullable: false),
                    Recovery = table.Column<long>(nullable: false),
                    MagicResist = table.Column<double>(nullable: false),
                    PhysicalResist = table.Column<double>(nullable: false),
                    LifeLeech = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Heroes", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Heroes");
        }
    }
}
