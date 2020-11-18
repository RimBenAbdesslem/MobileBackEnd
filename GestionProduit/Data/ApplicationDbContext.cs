using GestionProduit.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionProduit.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }


        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Produit> Produits { get; set; }
        public DbSet<FournisseurModel> Fournnisseurs { get; set; }
        public DbSet<CategorieModel> Categories { get; set; }
        public DbSet<SCategorieModel> SCategories { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<IdentityRole>().HasData(
                    new { Id = "1", Name = "admin", NormalizedName = "ADMIN" },
                    new { Id = "2", Name = "user", NormalizedName = "USER" }
                );

            modelBuilder.Entity<CategorieModel>()
          .HasMany(c => c.SCategories)
           .WithOne(e => e.Categories);


            base.OnModelCreating(modelBuilder);
        }



        }
}
