﻿using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    //IdentityDbContext DbContext sınıfından miras alır ve dbcontextin bütün özelliklerinin kullanabilir
    public class Context : IdentityDbContext<AppUser,AppRole,int> //Hali hazırda bulunan sql tabloma(aspNetUser) baktığım zaman appuser da ki propertilerim bu tablomun propertilerinin önüne geçti
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=YUSUF;database=CoreBlogDb;integrated security=true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Match>()
                .HasOne(x => x.HomeTeam)
                .WithMany(y => y.HomeMatches)
                .HasForeignKey(z => z.HomeTeamID)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<Match>()
                .HasOne(x => x.GuestTeam)
                .WithMany(y => y.AwayMatches)
                .HasForeignKey(z => z.GuestTeamID)
                .OnDelete(DeleteBehavior.ClientSetNull);

            base.OnModelCreating(modelBuilder);
            //HomeMatches-->WriterSender
            //AwayMatches-->WriterReceiver


            //HomeTeam-->SenderUser
            //GuestTeam-->ReceiverUser

            modelBuilder.Entity<Message2>()   // MESAJ YOLLAYAN İÇİN YAPILAN İŞLEMLER
                .HasOne(x=>x.SenderUser)
                 .WithMany(y => y.WriterSender)
                 .HasForeignKey(z=>z.SenderID)
                   .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<Message2>() // MESAJ ALAN İÇİN YAPILAN İŞLEMLER
                .HasOne(x=>x.ReceiverUser)
                 .WithMany(y => y.WriterReceiver)
                  .HasForeignKey(z => z.ReceiverID)
                    .OnDelete(DeleteBehavior.ClientSetNull);
        }

        public DbSet<About> Abouts { get; set; }

        public DbSet<Blog> Blogs { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Comment> Comments { get; set; }

        public DbSet<Contact> Contacts { get; set; }

        public DbSet<Writer> Writers { get; set; }

        public DbSet<NewsLatter> NewsLatters { get; set; }


        public DbSet<BlogRayting> BlogRaytings { get; set; }

        public DbSet<Notification> Notifications { get; set; }

        public DbSet<Message> Messages { get; set; }

        public DbSet<Team> Teams { get; set; }
        public DbSet<Match> Matches { get; set; } 
        public DbSet<Message2> Message2s { get; set; }
        public DbSet<Admin> Admins { get; set; }
    }
}