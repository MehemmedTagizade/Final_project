﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalProject_DarkLook.Migrations
{
    public partial class AboutTableUpdate463 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "OriginalImageName",
                table: "Abouts",
                maxLength: 255,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OriginalImageName",
                table: "Abouts");
        }
    }
}
