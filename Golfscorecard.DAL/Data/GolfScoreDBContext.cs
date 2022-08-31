using Golfscorecard.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Golfscorecard.DAL.Data
{
    public class GolfScoreDBContext : DbContext
    {

        public GolfScoreDBContext() : base() { }
        
        public GolfScoreDBContext(DbContextOptions<GolfScoreDBContext> options) : base(options)
        {
        }

        public DbSet<Scorecard> Scorecards { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-260D9DD\\SQLEXPRESS;Database=GolfScoreDB;Trusted_Connection=True;");
            }
        }
    }
}
