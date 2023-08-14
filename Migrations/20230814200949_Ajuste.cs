﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APICatalogo.Migrations
{
    /// <inheritdoc />
    public partial class Ajuste : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("insert into Categorias (Name, ImagemUrl) Values ('Bebidas', 'bebidas.jpg') ");
            migrationBuilder.Sql("insert into Categorias (Name, ImagemUrl) Values ('Lanches', 'lanches.jpg') ");
            migrationBuilder.Sql("insert into Categorias (Name, ImagemUrl) Values ('Sobremesas', 'sobremesas.jpg') ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Delete from Categorias");
        }
    }
}
