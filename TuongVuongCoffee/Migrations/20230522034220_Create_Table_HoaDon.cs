using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TuongVuongCoffee.Migrations
{
    /// <inheritdoc />
    public partial class Create_Table_HoaDon : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HoaDon",
                columns: table => new
                {
                    HoaDonID = table.Column<string>(type: "TEXT", nullable: false),
                    HoaDonName = table.Column<string>(type: "TEXT", nullable: false),
                    SoLuong = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDon", x => x.HoaDonID);
                });

            migrationBuilder.CreateTable(
                name: "KhachHang",
                columns: table => new
                {
                    KhachHangCode = table.Column<string>(type: "TEXT", nullable: false),
                    KhachHangName = table.Column<string>(type: "TEXT", nullable: false),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: false),
                    Address = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhachHang", x => x.KhachHangCode);
                });

            migrationBuilder.CreateTable(
                name: "NhanVien",
                columns: table => new
                {
                    NhanVienCode = table.Column<string>(type: "TEXT", nullable: false),
                    NhanVienName = table.Column<string>(type: "TEXT", nullable: false),
                    Sex = table.Column<string>(type: "TEXT", nullable: false),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: false),
                    Address = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanVien", x => x.NhanVienCode);
                });

            migrationBuilder.CreateTable(
                name: "SanPham",
                columns: table => new
                {
                    SanPhamID = table.Column<string>(type: "TEXT", nullable: false),
                    SanPhamName = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SanPham", x => x.SanPhamID);
                });

            migrationBuilder.CreateTable(
                name: "Kho",
                columns: table => new
                {
                    KhoID = table.Column<string>(type: "TEXT", nullable: false),
                    SanPhamName = table.Column<string>(type: "TEXT", nullable: false),
                    NumberKho = table.Column<string>(type: "TEXT", nullable: false),
                    KhoStoreExists = table.Column<string>(type: "TEXT", nullable: false),
                    InventoryKho = table.Column<string>(type: "TEXT", nullable: false),
                    ExportKho = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kho", x => x.KhoID);
                    table.ForeignKey(
                        name: "FK_Kho_SanPham_SanPhamName",
                        column: x => x.SanPhamName,
                        principalTable: "SanPham",
                        principalColumn: "SanPhamID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Kho_SanPhamName",
                table: "Kho",
                column: "SanPhamName");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HoaDon");

            migrationBuilder.DropTable(
                name: "KhachHang");

            migrationBuilder.DropTable(
                name: "Kho");

            migrationBuilder.DropTable(
                name: "NhanVien");

            migrationBuilder.DropTable(
                name: "SanPham");
        }
    }
}
