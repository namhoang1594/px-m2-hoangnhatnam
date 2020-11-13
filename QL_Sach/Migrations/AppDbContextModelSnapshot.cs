﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QL_Sach.Models;

namespace QL_Sach.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("QL_Sach.Models.BookInfor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<string>("Author")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PublishYear")
                        .HasColumnType("int");

                    b.Property<string>("ShortContent")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("BookInfors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Amount = 50,
                            Author = "Tào Tuyết Cần",
                            CategoryId = 1,
                            Name = "Hồng Lâu Mộng",
                            PublishYear = 1750,
                            ShortContent = "Tác phẩm ra đời vào khoảng giữa thế kỉ XVIII, đời nhà Thanh, 80 hồi đầu do Tào Tuyết Cần viết, 40 hồi sau do Cao Ngạc viết thêm và soạn thành sách"
                        },
                        new
                        {
                            Id = 2,
                            Amount = 35,
                            Author = "Dale Carnegie",
                            CategoryId = 2,
                            Name = "Đắc Nhân Tâm",
                            PublishYear = 2016,
                            ShortContent = "Quyển sách duy nhất về thể loại self-help liên tục đứng đầu danh mục sách bán chạy nhất (best-selling Books) do báo The New York Times bình chọn suốt 10 năm liền"
                        },
                        new
                        {
                            Id = 3,
                            Amount = 62,
                            Author = "Jared Diamond",
                            CategoryId = 3,
                            Name = "Súng, vi trùng và thép",
                            PublishYear = 2019,
                            ShortContent = "Bàn tay của diễn trình lịch sử từ 8.000 năm trước vẫn đang đè nặng lên chúng ta"
                        });
                });

            modelBuilder.Entity("QL_Sach.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Tiểu Thuyết"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Chính Trị"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Khoa Học"
                        });
                });

            modelBuilder.Entity("QL_Sach.Models.BookInfor", b =>
                {
                    b.HasOne("QL_Sach.Models.Category", "Category")
                        .WithMany("BookInfors")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}