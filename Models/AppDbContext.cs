using DevTimeSolution.data;
using Microsoft.EntityFrameworkCore;
using System;

namespace DevTimeSolution.Models
{
    public class AppDbContext :DbContext
    {
      public  AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {


        }
        public DbSet<MobileApp> MobileApps { get; set; }

    }
}
