using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QL_Sach.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> dbContextOptions) : base(dbContextOptions)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<BookInfor> BookInfors { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(new Category { Id = 1, Name = "Tiểu Thuyết" });
            modelBuilder.Entity<Category>().HasData(new Category { Id = 2, Name = "Chính Trị" });
            modelBuilder.Entity<Category>().HasData(new Category { Id = 3, Name = "Khoa Học" });

            modelBuilder.Entity<BookInfor>().HasData(new BookInfor
            {
                Id = 1,
                Name = "Hồng Lâu Mộng",
                Author = "Tào Tuyết Cần",
                ShortContent = "Tác phẩm ra đời vào khoảng giữa thế kỉ XVIII, đời nhà Thanh, 80 hồi đầu do Tào Tuyết Cần viết, 40 hồi sau do Cao Ngạc viết thêm và soạn thành sách",
                PublishYear = 1750,
                Amount = 50,
                CategoryId = 1
            });
            modelBuilder.Entity<BookInfor>().HasData(new BookInfor
            {
                Id = 2,
                Name = "Đắc Nhân Tâm",
                Author = "Dale Carnegie",
                ShortContent = "Quyển sách duy nhất về thể loại self-help liên tục đứng đầu danh mục sách bán chạy nhất (best-selling Books) do báo The New York Times bình chọn suốt 10 năm liền",
                PublishYear = 2016,
                Amount = 35,
                CategoryId = 2
            });
            modelBuilder.Entity<BookInfor>().HasData(new BookInfor
            {
                Id = 3,
                Name = "Súng, vi trùng và thép",
                Author = "Jared Diamond",
                ShortContent = "Bàn tay của diễn trình lịch sử từ 8.000 năm trước vẫn đang đè nặng lên chúng ta",
                PublishYear = 2019,
                Amount = 62,
                CategoryId = 3
            });
        }
    }
}
