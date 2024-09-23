using HotelProject.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccessLayer.Concrete
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=LAPTOP-QNO3SB5P\\SQLEXPRESS; initial Catalog=ApiDb; integrated Security=true;");
        }
        public DbSet<Room>Rooms { get; set; }
        public DbSet<Service>Services { get; set; }
        public DbSet<Team>Teams { get; set; }
        public DbSet<Subscribe>Subscribes { get; set; }
        public DbSet<Testimonial>Testimonials { get; set; }
    }
}
