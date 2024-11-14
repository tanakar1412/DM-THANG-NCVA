using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace asdasda.Migrations
{
    /// <inheritdoc />
    public partial class Kms : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "khoaHoc",
                columns: table => new
                {
                    MaPB = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TenKH = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_khoaHoc", x => x.MaPB);
                });

            migrationBuilder.CreateTable(
                name: "sinhViens",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tuoi = table.Column<int>(type: "int", nullable: false),
                    GioiTinh = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sinhViens", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "KHCTs",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SinhVienID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    KhoaHocID = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KHCTs", x => x.id);
                    table.ForeignKey(
                        name: "FK_KHCTs_khoaHoc_KhoaHocID",
                        column: x => x.KhoaHocID,
                        principalTable: "khoaHoc",
                        principalColumn: "MaPB");
                    table.ForeignKey(
                        name: "FK_KHCTs_sinhViens_SinhVienID",
                        column: x => x.SinhVienID,
                        principalTable: "sinhViens",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_KHCTs_KhoaHocID",
                table: "KHCTs",
                column: "KhoaHocID");

            migrationBuilder.CreateIndex(
                name: "IX_KHCTs_SinhVienID",
                table: "KHCTs",
                column: "SinhVienID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KHCTs");

            migrationBuilder.DropTable(
                name: "khoaHoc");

            migrationBuilder.DropTable(
                name: "sinhViens");
        }
    }
}
