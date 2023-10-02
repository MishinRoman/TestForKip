using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

using TestForKip.Controllers;

namespace TestForKip
{
    public class MyDbContext:DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options):base(options)
        {
            
        }
       public DbSet<Report> Reports { get; set; }
        public DbSet<UserStatistics> UserStatistics { get; set; }
        public DbSet<UserStatisticsRequest> requests { get; set; }

    }
}
