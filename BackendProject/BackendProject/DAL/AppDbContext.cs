using BackendProject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendProject.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<BlogCategory>BlogCategories {get; set;}
        public DbSet<Blog> Blogs { get; set; } 
        public DbSet<CourseCategory> CourseCategories {get; set;}
        public DbSet<Courses> Courses { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Home> Homes { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<TeacherSpeciality> TeacherSpecialities { get; set; }

    }
}