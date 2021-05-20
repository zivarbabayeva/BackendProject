using Microsoft.EntityFrameworkCore;
using ProjectBackend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBackend.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { 

        }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Caption> Captions { get; set; }
        public DbSet<NoticeBoard> NoticeBoards { get; set; }
        public DbSet<NoticeTwo> NoticeTwos { get; set; }
        public DbSet<WhyChoose> WhyChooses { get; set; }
        public DbSet<Upcomming> Upcomming { get; set; }
        public DbSet<Testimonial> Testimonial { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<VideoTour> VideoTour { get; set; }
         public DbSet<Blogdetails> Blogdetails { get; set; }
        public DbSet<Blog> Blog { get; set; }
        public DbSet<CoursesOffer> CoursesOffers { get; set; }
        public DbSet<CourseDetails> CourseDetails { get; set; }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<Bio> Bio { get; set; }
        public DbSet<Subscribe> Subscribe { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Eventdetails> Eventdetails { get; set; }
        public DbSet<Speakers> Speakers { get; set; }
        public EventSpeakers EventSpeakers {get; set; }
        public DbSet<Home> Homes { get; set; }
        public DbSet<Teacher> Teacher { get; set; }
        public DbSet<TeacherDetails> TeacherDetails { get; set; }
        public DbSet<TeacherSpeciality> TeacherSpecialities { get; set; }
    }
    }

