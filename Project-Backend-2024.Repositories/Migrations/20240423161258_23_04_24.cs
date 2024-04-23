﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project_Backend_2024.Repositories.Migrations
{
    /// <inheritdoc />
    public partial class _23_04_24 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ApplicationStatus",
                table: "AppliedProjects",
                type: "varchar",
                maxLength: 50,
                nullable: false,
                defaultValueSql: "'Active'",
                oldClrType: typeof(string),
                oldType: "varchar",
                oldMaxLength: 50);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ApplicationStatus",
                table: "AppliedProjects",
                type: "varchar",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar",
                oldMaxLength: 50,
                oldDefaultValueSql: "'Active'");
        }
    }
}
