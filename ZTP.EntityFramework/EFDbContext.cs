using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZTP.EntityFramework.Models;

namespace ZTP.EntityFramework
{
    public class EFDbContext : IdentityDbContext<AppUser, AppRole, string>
    {
        public EFDbContext(DbContextOptions<EFDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Something is wrong here
            modelBuilder.Entity<Commission>()
                .HasOne(x => x.ComissionTaker)
                .WithMany(x => x.Comissions).HasForeignKey(x => x.MakerId);

            modelBuilder.Entity<Commission>()
                .HasOne(x => x.ComissionTaker)
                .WithMany(x => x.Comissions).HasForeignKey(x => x.TakerId);

            modelBuilder.Entity<AppUser>()
                .HasOne(x => x.UserInfo);


        }
        public DbSet<UserInfo> UserInfos { get; set; }
        public DbSet<Avatar> Avatars { get; set; }
        public DbSet<Commission> Commissions { get; set; }
        public DbSet<Offer> Offers { get; set; }



    }
}
