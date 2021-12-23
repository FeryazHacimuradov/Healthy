using System;
using Microsoft.EntityFrameworkCore;
using One_HealthyV2._0.Models;

namespace One_HealthyV2._0.Data
{
    public class AppDbContext :DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<Social> Socials { get; set; }
        public DbSet<Specialty> Specialties { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<TagToBlog> TagToBlogs { get; set; }
        public DbSet<User> Users { get; set; }

    }
}
