using Microsoft.EntityFrameworkCore;
using HolidayChecklist.Models;

namespace HolidayChecklist.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
                : base(options)
        {
        }
        public DbSet<HolidayChecklist.Models.TVShow> TVShow { get; set; }
        public DbSet<HolidayChecklist.Models.Season> Season { get; set; }
        public DbSet<HolidayChecklist.Models.Episode> Episode { get; set; }
    }
}