using Blog.Entity.Entities;
using Blog.Entity.Helper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.DataAccess
{
    public class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseNpgsql(
            //   ("User ID=postgres;Password=123;Server=localhost;Port=5432;Database=landingforms_db"),
            //    (e) => { e.EnableRetryOnFailure(); });
            //optionsBuilder.EnableSensitiveDataLogging();

            optionsBuilder.UseNpgsql(EnvHelper.ConnectionString,
            (e) => { e.EnableRetryOnFailure(); });

            //string str ="username=landingform_user;password=AVNS_Y8At_Ro7K-X57nP7emL;host=db-postgresql-ams3-41785-do-user-11154186-0.b.db.ondigitalocean.com;port=25061;database=Pool-Landingform;SSL Mode=Require;Trust Server Certificate=true;Pooling = true";
        }

        public DbSet<Author> Authors { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Comment> Comments { get; set; }

        public DbSet<Content> Contents { get; set; }

        public DbSet<ContentCategory> ContentCategories { get; set; }

        public DbSet<ContentTag> ContentTags { get; set; }

        public DbSet<Media> Medias { get; set; }

        public DbSet<Tag> Tags { get; set; }



    }
}
