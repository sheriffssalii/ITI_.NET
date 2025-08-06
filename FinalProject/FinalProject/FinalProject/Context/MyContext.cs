using FinalProject.Models;
using Microsoft.EntityFrameworkCore;

namespace FinalProject.Context
{
    public class MyContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Server=.;Database=FinalProject;Trusted_Connection=True;TrustServerCertificate=true";
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>().HasData(
                
                new User { UserId = 2, FirstName = "Anas", LastName = "Sherif", Email = "anas.sherif@example.com", Password = "pass5678" },
                new User { UserId = 3, FirstName = "Ashraf", LastName = "Fathy", Email = "ashraf.fathy@example.com", Password = "pass9101112" },
                new User { UserId = 4, FirstName = "Salma", LastName = "Mohamed", Email = "salma.mohamed@example.com", Password = "pass13141516" },
                new User { UserId = 5, FirstName = "Mona", LastName = "Mostafa", Email = "mona.mostafa@example.com", Password = "pass17181920" },
                new User { UserId = 6, FirstName = "Emad", LastName = "Shady", Email = "emad.shady@example.com", Password = "pass21222324" },
                new User { UserId = 7, FirstName = "Nancy", LastName = "Kareem", Email = "nancy.kareem@example.com", Password = "pass25262728" },
                new User { UserId = 8, FirstName = "Youssef", LastName = "Mahmoud", Email = "youssef.mahmoud@example.com", Password = "pass29303132" }
                );



            modelBuilder.Entity<Product>().HasData(
                new Product { ProductId = 1, Title = "iPhone 11 Pro Max",
                    Description = "The iPhone 11 Pro Max is a high-end smartphone from Apple," +
                    "featuring a powerful A13 Bionic chip with a hexa-core CPU for smooth and efficient performance.",
                    Price = 10000, Quantity = 111, ImagePath = "/images/iphone-11-pro-max.jpg", CategoryId = 1 },

                  new Product { ProductId = 2, Title = "iPhone 12 Pro Max",
                      Description = "The iPhone 12 Pro Max, released in 2020, is Apple's flagship smartphone featuring a 6.7-inch Super Retina XDR OLED display and powered by the A14 Bionic chip..",
                      Price = 20000, Quantity = 222, ImagePath = "/images/iphone-12-pro-max.jpg", CategoryId = 1 },

                    new Product { ProductId = 3, Title = "iPhone 13 Pro Max",
                        Description = "The iPhone 13 Pro Max is Apple's top-tier flagship smartphone released in 2021." +
                    " It features a large 6.7-inch Super Retina XDR OLED display with ProMotion technology ",
                        Price = 30000, Quantity = 333, ImagePath = "/images/iphone-13-pro-max.jpg", CategoryId=1 },
                      new Product { ProductId = 4, Title = "iPhone 14 Pro Max",
                          Description = "The iPhone 14 Pro Max, released in 2022, features a 6.7-inch Super Retina XDR OLED display with ProMotion technology for a smooth 120Hz refresh rate. It is powered by the A16 Bionic chip, ensuring top-tier performance." +
                    " The device boasts a triple-camera system with a 48 MP main sensor, enhanced low-light capabilities, and ProRAW/ProRes video recording.",
                          Price = 40000, Quantity = 444, ImagePath = "/images/iphone-14-pro-max.jpg", CategoryId=1 }
                      );

            modelBuilder.Entity<Category>().HasData(
                    new Category { CategoryId = 1, Name = "Mobile",Description = "Mobile Phone"  },
                    new Category { CategoryId = 2, Name = "Lap",Description = "Laptop" },
                    new Category { CategoryId = 3, Name = "Acc",Description = "Accessories" },
                    new Category { CategoryId = 4, Name = "HW",Description = "HardWare" }
            );

            modelBuilder.Entity<Product>()
               .HasOne(p => p.Category)
               .WithMany(c => c.Products)
               .HasForeignKey(p => p.CategoryId);

            // Configure unique constraint for email
            modelBuilder.Entity<User>()
                .HasIndex(u => u.Email)
                .IsUnique();

            base.OnModelCreating(modelBuilder);
        }

        #region Tables
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        #endregion
    }
}




