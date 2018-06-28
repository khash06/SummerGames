using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SummerGames.Migrations
{
    public partial class Player : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "storyline",
                columns: table => new
                {
                    StoryId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Storybook = table.Column<string>(nullable: true),
                    created_at = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_storyline", x => x.StoryId);
                });

            migrationBuilder.CreateTable(
                name: "player",
                columns: table => new
                {
                    PlayerId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Class = table.Column<string>(nullable: true),
                    Life = table.Column<bool>(nullable: false),
                    Password = table.Column<string>(nullable: true),
                    StoryId = table.Column<int>(nullable: true),
                    Username = table.Column<string>(nullable: true),
                    dexterity = table.Column<int>(nullable: false),
                    health = table.Column<int>(nullable: false),
                    healthMax = table.Column<int>(nullable: false),
                    intelligence = table.Column<int>(nullable: false),
                    strength = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_player", x => x.PlayerId);
                    table.ForeignKey(
                        name: "FK_player_storyline_StoryId",
                        column: x => x.StoryId,
                        principalTable: "storyline",
                        principalColumn: "StoryId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "encounters",
                columns: table => new
                {
                    EncountersId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    PlayerId = table.Column<int>(nullable: false),
                    Story = table.Column<string>(nullable: true),
                    dragons = table.Column<int>(nullable: false),
                    orcs = table.Column<int>(nullable: false),
                    spiders = table.Column<int>(nullable: false),
                    zombies = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_encounters", x => x.EncountersId);
                    table.ForeignKey(
                        name: "FK_encounters_player_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "player",
                        principalColumn: "PlayerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "enemies",
                columns: table => new
                {
                    EnemiesId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    EncountersId = table.Column<int>(nullable: false),
                    health = table.Column<int>(nullable: false),
                    healthMax = table.Column<int>(nullable: false),
                    strength = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_enemies", x => x.EnemiesId);
                    table.ForeignKey(
                        name: "FK_enemies_encounters_EncountersId",
                        column: x => x.EncountersId,
                        principalTable: "encounters",
                        principalColumn: "EncountersId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "multiplayer",
                columns: table => new
                {
                    MultiplayerId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    EncountersId = table.Column<int>(nullable: false),
                    PlayerId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_multiplayer", x => x.MultiplayerId);
                    table.ForeignKey(
                        name: "FK_multiplayer_encounters_EncountersId",
                        column: x => x.EncountersId,
                        principalTable: "encounters",
                        principalColumn: "EncountersId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_multiplayer_player_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "player",
                        principalColumn: "PlayerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_encounters_PlayerId",
                table: "encounters",
                column: "PlayerId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_enemies_EncountersId",
                table: "enemies",
                column: "EncountersId");

            migrationBuilder.CreateIndex(
                name: "IX_multiplayer_EncountersId",
                table: "multiplayer",
                column: "EncountersId");

            migrationBuilder.CreateIndex(
                name: "IX_multiplayer_PlayerId",
                table: "multiplayer",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_player_StoryId",
                table: "player",
                column: "StoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "enemies");

            migrationBuilder.DropTable(
                name: "multiplayer");

            migrationBuilder.DropTable(
                name: "encounters");

            migrationBuilder.DropTable(
                name: "player");

            migrationBuilder.DropTable(
                name: "storyline");
        }
    }
}
