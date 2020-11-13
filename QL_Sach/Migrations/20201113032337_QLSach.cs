using Microsoft.EntityFrameworkCore.Migrations;

namespace QL_Sach.Migrations
{
    public partial class QLSach : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BookInfors",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Author = table.Column<string>(nullable: true),
                    ShortContent = table.Column<string>(nullable: true),
                    PublishYear = table.Column<int>(nullable: false),
                    Amount = table.Column<int>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookInfors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookInfors_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Tiểu Thuyết" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Chính Trị" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 3, "Khoa Học" });

            migrationBuilder.InsertData(
                table: "BookInfors",
                columns: new[] { "Id", "Amount", "Author", "CategoryId", "Name", "PublishYear", "ShortContent" },
                values: new object[] { 1, 50, "Tào Tuyết Cần", 1, "Hồng Lâu Mộng", 1750, "Tác phẩm ra đời vào khoảng giữa thế kỉ XVIII, đời nhà Thanh, 80 hồi đầu do Tào Tuyết Cần viết, 40 hồi sau do Cao Ngạc viết thêm và soạn thành sách" });

            migrationBuilder.InsertData(
                table: "BookInfors",
                columns: new[] { "Id", "Amount", "Author", "CategoryId", "Name", "PublishYear", "ShortContent" },
                values: new object[] { 2, 35, "Dale Carnegie", 2, "Đắc Nhân Tâm", 2016, "Quyển sách duy nhất về thể loại self-help liên tục đứng đầu danh mục sách bán chạy nhất (best-selling Books) do báo The New York Times bình chọn suốt 10 năm liền" });

            migrationBuilder.InsertData(
                table: "BookInfors",
                columns: new[] { "Id", "Amount", "Author", "CategoryId", "Name", "PublishYear", "ShortContent" },
                values: new object[] { 3, 62, "Jared Diamond", 3, "Súng, vi trùng và thép", 2019, "Bàn tay của diễn trình lịch sử từ 8.000 năm trước vẫn đang đè nặng lên chúng ta" });

            migrationBuilder.CreateIndex(
                name: "IX_BookInfors_CategoryId",
                table: "BookInfors",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookInfors");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
