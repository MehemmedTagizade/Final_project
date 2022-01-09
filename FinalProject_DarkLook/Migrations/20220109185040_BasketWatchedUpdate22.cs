﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalProject_DarkLook.Migrations
{
    public partial class BasketWatchedUpdate22 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "BasketWatches",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "BasketWatches");
        }
    }
}
