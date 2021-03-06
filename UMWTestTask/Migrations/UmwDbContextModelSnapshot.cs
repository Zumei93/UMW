// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UMWTestTask.Persistence;

namespace UMWTestTask.Migrations
{
    [DbContext(typeof(UmwDbContext))]
    partial class UmwDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("UMWTestTask.DAL.Models.Brand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.ToTable("Brands");
                });

            modelBuilder.Entity("UMWTestTask.DAL.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("FlagId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("FlagId")
                        .IsUnique()
                        .HasFilter("[FlagId] IS NOT NULL");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("UMWTestTask.DAL.Models.Discount", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("DiscountedPrice")
                        .HasColumnType("real");

                    b.Property<int?>("FlagId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("FlagId")
                        .IsUnique()
                        .HasFilter("[FlagId] IS NOT NULL");

                    b.ToTable("Discounts");
                });

            modelBuilder.Entity("UMWTestTask.DAL.Models.Flag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<byte>("Priority")
                        .HasColumnType("tinyint");

                    b.HasKey("Id");

                    b.ToTable("Flags");
                });

            modelBuilder.Entity("UMWTestTask.DAL.Models.Folder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("DiscountId")
                        .HasColumnType("int");

                    b.Property<int?>("FlagId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<int?>("ParentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DiscountId");

                    b.HasIndex("FlagId")
                        .IsUnique()
                        .HasFilter("[FlagId] IS NOT NULL");

                    b.HasIndex("ParentId");

                    b.ToTable("Folders");
                });

            modelBuilder.Entity("UMWTestTask.DAL.Models.Image", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<byte[]>("Source")
                        .HasColumnType("varbinary(max)");

                    b.HasKey("Id");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("UMWTestTask.DAL.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BrandId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("DiscountId")
                        .HasColumnType("int");

                    b.Property<int?>("FlagId")
                        .HasColumnType("int");

                    b.Property<int>("FolderId")
                        .HasColumnType("int");

                    b.Property<int?>("ImageId")
                        .HasColumnType("int");

                    b.Property<int>("InStock")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.HasIndex("DiscountId");

                    b.HasIndex("FlagId")
                        .IsUnique()
                        .HasFilter("[FlagId] IS NOT NULL");

                    b.HasIndex("FolderId");

                    b.HasIndex("ImageId")
                        .IsUnique()
                        .HasFilter("[ImageId] IS NOT NULL");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("UMWTestTask.DAL.Models.ProductCategory", b =>
                {
                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("CategoryId", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductCategories");
                });

            modelBuilder.Entity("UMWTestTask.DAL.Models.Category", b =>
                {
                    b.HasOne("UMWTestTask.DAL.Models.Flag", "Flag")
                        .WithOne("Category")
                        .HasForeignKey("UMWTestTask.DAL.Models.Category", "FlagId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("Flag");
                });

            modelBuilder.Entity("UMWTestTask.DAL.Models.Discount", b =>
                {
                    b.HasOne("UMWTestTask.DAL.Models.Flag", "Flag")
                        .WithOne("Discount")
                        .HasForeignKey("UMWTestTask.DAL.Models.Discount", "FlagId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("Flag");
                });

            modelBuilder.Entity("UMWTestTask.DAL.Models.Folder", b =>
                {
                    b.HasOne("UMWTestTask.DAL.Models.Discount", "Discount")
                        .WithMany("Folders")
                        .HasForeignKey("DiscountId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("UMWTestTask.DAL.Models.Flag", "Flag")
                        .WithOne("Folder")
                        .HasForeignKey("UMWTestTask.DAL.Models.Folder", "FlagId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("UMWTestTask.DAL.Models.Folder", "Parent")
                        .WithMany("SubFolders")
                        .HasForeignKey("ParentId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.Navigation("Discount");

                    b.Navigation("Flag");

                    b.Navigation("Parent");
                });

            modelBuilder.Entity("UMWTestTask.DAL.Models.Product", b =>
                {
                    b.HasOne("UMWTestTask.DAL.Models.Brand", "Brand")
                        .WithMany("Products")
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UMWTestTask.DAL.Models.Discount", "Discount")
                        .WithMany("Products")
                        .HasForeignKey("DiscountId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("UMWTestTask.DAL.Models.Flag", "Flag")
                        .WithOne("Product")
                        .HasForeignKey("UMWTestTask.DAL.Models.Product", "FlagId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("UMWTestTask.DAL.Models.Folder", "Folder")
                        .WithMany("Products")
                        .HasForeignKey("FolderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UMWTestTask.DAL.Models.Image", "Image")
                        .WithOne("Product")
                        .HasForeignKey("UMWTestTask.DAL.Models.Product", "ImageId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("Brand");

                    b.Navigation("Discount");

                    b.Navigation("Flag");

                    b.Navigation("Folder");

                    b.Navigation("Image");
                });

            modelBuilder.Entity("UMWTestTask.DAL.Models.ProductCategory", b =>
                {
                    b.HasOne("UMWTestTask.DAL.Models.Category", "Category")
                        .WithMany("ProductCategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UMWTestTask.DAL.Models.Product", "Product")
                        .WithMany("ProductCategories")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("UMWTestTask.DAL.Models.Brand", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("UMWTestTask.DAL.Models.Category", b =>
                {
                    b.Navigation("ProductCategories");
                });

            modelBuilder.Entity("UMWTestTask.DAL.Models.Discount", b =>
                {
                    b.Navigation("Folders");

                    b.Navigation("Products");
                });

            modelBuilder.Entity("UMWTestTask.DAL.Models.Flag", b =>
                {
                    b.Navigation("Category");

                    b.Navigation("Discount");

                    b.Navigation("Folder");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("UMWTestTask.DAL.Models.Folder", b =>
                {
                    b.Navigation("Products");

                    b.Navigation("SubFolders");
                });

            modelBuilder.Entity("UMWTestTask.DAL.Models.Image", b =>
                {
                    b.Navigation("Product");
                });

            modelBuilder.Entity("UMWTestTask.DAL.Models.Product", b =>
                {
                    b.Navigation("ProductCategories");
                });
#pragma warning restore 612, 618
        }
    }
}
