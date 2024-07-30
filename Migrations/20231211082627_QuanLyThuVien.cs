using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace PRO131_Duan1_FA23.Migrations
{
    /// <inheritdoc />
    public partial class QuanLyThuVien : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "khachHangs",
                columns: table => new
                {
                    MaKhachHang = table.Column<string>(type: "character varying(6)", maxLength: 6, nullable: false),
                    TenKhachHang = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    SoDT = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    Email = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    NgayMuon = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    NgayTra = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    MatKhau = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    TrangThai = table.Column<string>(type: "character varying(40)", maxLength: 40, nullable: true),
                    MaNV = table.Column<string>(type: "character varying(6)", maxLength: 6, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_khachHangs", x => x.MaKhachHang);
                });

            migrationBuilder.CreateTable(
                name: "KhachHangSach",
                columns: table => new
                {
                    STT = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MaKhachHang = table.Column<string>(type: "character varying(6)", maxLength: 6, nullable: true),
                    MaSach = table.Column<string>(type: "character varying(6)", maxLength: 6, nullable: true),
                    MaNV = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhachHangSach", x => x.STT);
                });

            migrationBuilder.CreateTable(
                name: "nhanViens",
                columns: table => new
                {
                    MaNV = table.Column<string>(type: "character varying(6)", maxLength: 6, nullable: false),
                    TenNV = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    SoDT = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    Email = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    DiaChi = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    VaiTro = table.Column<bool>(type: "boolean", nullable: false),
                    MatKhau = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    TinhTrang = table.Column<bool>(type: "boolean", nullable: false),
                    Hinh = table.Column<byte[]>(type: "bytea", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_nhanViens", x => x.MaNV);
                });

            migrationBuilder.CreateTable(
                name: "nhaXBs",
                columns: table => new
                {
                    MaXB = table.Column<string>(type: "character varying(6)", maxLength: 6, nullable: false),
                    TenNhaXB = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    DiaChi = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    SoDT = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    GhiChu = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true),
                    MaNV = table.Column<string>(type: "character varying(6)", maxLength: 6, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_nhaXBs", x => x.MaXB);
                });

            migrationBuilder.CreateTable(
                name: "sachs",
                columns: table => new
                {
                    MaSach = table.Column<string>(type: "character varying(6)", maxLength: 6, nullable: false),
                    TenSach = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    TacGia = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    LoaiSach = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    TinhTrang = table.Column<bool>(type: "boolean", nullable: false),
                    TrangThai = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    SoLuong = table.Column<int>(type: "integer", nullable: false),
                    MaNV = table.Column<string>(type: "character varying(6)", maxLength: 6, nullable: true),
                    MaXB = table.Column<string>(type: "character varying(6)", maxLength: 6, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sachs", x => x.MaSach);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "khachHangs");

            migrationBuilder.DropTable(
                name: "KhachHangSach");

            migrationBuilder.DropTable(
                name: "nhanViens");

            migrationBuilder.DropTable(
                name: "nhaXBs");

            migrationBuilder.DropTable(
                name: "sachs");
        }
    }
}
