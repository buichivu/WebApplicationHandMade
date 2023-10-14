using handMadeShop.Data.Entities;
using handMadeShop.Data.Enums;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace handMadeShop.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppConfig>().HasData(
               new AppConfig() { Key = "HomeTitle", Value = "This is home page of handMadeShop" },
               new AppConfig() { Key = "HomeKeyword", Value = "This is keyword of handMadeShop" },
               new AppConfig() { Key = "HomeDescription", Value = "This is description of handMadeShop" }
               );
            modelBuilder.Entity<Language>().HasData(
                new Language() { Id = "vi", Name = "Tiếng Việt", IsDefault = true },
                new Language() { Id = "en", Name = "English", IsDefault = false });

            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    Id = 1,
                    IsShowOnHome = true,
                    ParentId = null,
                    SortOrder = 1,
                    Status = Status.Active,
                },
                 new Category()
                 {
                     Id = 2,
                     IsShowOnHome = true,
                     ParentId = null,
                     SortOrder = 2,
                     Status = Status.Active
                 });

            modelBuilder.Entity<CategoryTranslation>().HasData(
                  new CategoryTranslation() { Id = 1, CategoryId = 1, Name = "Hoa Giấy", LanguageId = "vi", SeoAlias = "Hoa-Giay", SeoDescription = "Sản phẩm hoa Giấy", SeoTitle = "Sản phẩm hoa Giấ" },
                  new CategoryTranslation() { Id = 2, CategoryId = 1, Name = "Sap Flower", LanguageId = "en", SeoAlias = "Sap-Floewr", SeoDescription = "The Sap flower", SeoTitle = "The Sap flower" },
                  new CategoryTranslation() { Id = 3, CategoryId = 2, Name = "Quà Lưu niệm", LanguageId = "vi", SeoAlias = "Qua-Luu-Niem", SeoDescription = "Sản phẩm Quà lưu niệm", SeoTitle = "Sản phẩm Quà lưu niệm" },
                  new CategoryTranslation() { Id = 4, CategoryId = 2, Name = "Design products as required", LanguageId = "en", SeoAlias = "Design products as required", SeoDescription = "The Design products as required", SeoTitle = "The Design products as required" }
                    );

            modelBuilder.Entity<Product>().HasData(
           new Product()
           {
               Id = 1,
               DateCreated = DateTime.Now,
               OriginalPrice = 100000,
               Price = 200000,
               Stock = 0,
               ViewCount = 0,
           });
            modelBuilder.Entity<ProductTranslation>().HasData(
                 new ProductTranslation()
                 {
                     Id = 1,
                     ProductId = 1,
                     Name = "Hoa Hồng Giấy Màu Hồng Bó 50 bông",
                     LanguageId = "vi",
                     SeoAlias = "ao-so-mi-nam-trang-viet-tien",
                     SeoDescription = "Hoa Hồng Giấy Màu Hồng Bó 50 bông",
                     SeoTitle = "Hoa Hồng Giấy Màu Hồng Bó 50 bông",
                     Details = "Hoa Hồng Giấy Màu Hồng Bó 50 bông",
                     Description = "Hoa Hồng Giấy Màu Hồng Bó 50 bông"
                 },
                    new ProductTranslation()
                    {
                        Id = 2,
                        ProductId = 1,
                        Name = "ao-so-mi-nam-trang-viet-tien",
                        LanguageId = "en",
                        SeoAlias = "ao-so-mi-nam-trang-viet-tien",
                        SeoDescription = "ao-so-mi-nam-trang-viet-tien",
                        SeoTitle = "ao-so-mi-nam-trang-viet-tien",
                        Details = "ao-so-mi-nam-trang-viet-tien",
                        Description = "ao-so-mi-nam-trang-viet-tien"
                    });
            modelBuilder.Entity<ProductInCategory>().HasData(
                new ProductInCategory() { ProductId = 1, CategoryId = 1 }
                );

            // any guid
            var roleId = new Guid("C8221E47-16BE-4922-926D-3442065DB705");
            var adminId = new Guid("A80BBA1C-5E54-4FD2-8DBC-9C4571E3B864");
            modelBuilder.Entity<AppRole>().HasData(new AppRole
            {
                Id = roleId,
                Name = "admin",
                NormalizedName = "admin",
                Description = "Administrator role"
            });

            var hasher = new PasswordHasher<AppUser>();
            modelBuilder.Entity<AppUser>().HasData(new AppUser
            {
                Id = adminId,
                UserName = "admin",
                NormalizedUserName = "admin",
                Email = "buivuisme@gmail.com",
                NormalizedEmail = "buivuisme@gmail.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Abcd1234$"),
                SecurityStamp = string.Empty,
                FirstName = "Bui Chi",
                LastName = "Vu",
                Dob = new DateTime(2001, 02, 25)
            });

            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
            {
                RoleId = roleId,
                UserId = adminId
            });

            modelBuilder.Entity<Slide>().HasData(
              new Slide() { Id = 1, Name = "Second Thumbnail label", Description = "Cras justo odio, dapibus ac facilisis in, egestas eget quam. Donec id elit non mi porta gravida at eget metus. Nullam id dolor id nibh ultricies vehicula ut id elit.", SortOrder = 1, Url = "#", Image = "/themes/images/carousel/1.png", Status = Status.Active },
              new Slide() { Id = 2, Name = "Second Thumbnail label", Description = "Cras justo odio, dapibus ac facilisis in, egestas eget quam. Donec id elit non mi porta gravida at eget metus. Nullam id dolor id nibh ultricies vehicula ut id elit.", SortOrder = 2, Url = "#", Image = "/themes/images/carousel/2.png", Status = Status.Active },
              new Slide() { Id = 3, Name = "Second Thumbnail label", Description = "Cras justo odio, dapibus ac facilisis in, egestas eget quam. Donec id elit non mi porta gravida at eget metus. Nullam id dolor id nibh ultricies vehicula ut id elit.", SortOrder = 3, Url = "#", Image = "/themes/images/carousel/3.png", Status = Status.Active },
              new Slide() { Id = 4, Name = "Second Thumbnail label", Description = "Cras justo odio, dapibus ac facilisis in, egestas eget quam. Donec id elit non mi porta gravida at eget metus. Nullam id dolor id nibh ultricies vehicula ut id elit.", SortOrder = 4, Url = "#", Image = "/themes/images/carousel/4.png", Status = Status.Active },
              new Slide() { Id = 5, Name = "Second Thumbnail label", Description = "Cras justo odio, dapibus ac facilisis in, egestas eget quam. Donec id elit non mi porta gravida at eget metus. Nullam id dolor id nibh ultricies vehicula ut id elit.", SortOrder = 5, Url = "#", Image = "/themes/images/carousel/5.png", Status = Status.Active },
              new Slide() { Id = 6, Name = "Second Thumbnail label", Description = "Cras justo odio, dapibus ac facilisis in, egestas eget quam. Donec id elit non mi porta gravida at eget metus. Nullam id dolor id nibh ultricies vehicula ut id elit.", SortOrder = 6, Url = "#", Image = "/themes/images/carousel/6.png", Status = Status.Active }
              );
        }
    }
}