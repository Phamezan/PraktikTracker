using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PraktikTracker.Models;

namespace PraktikTracker.Data
{
    public class PraktikDbContext : DbContext
    {
        public DbSet<Company> Companies { get; set; }
        public PraktikDbContext(DbContextOptions<PraktikDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Company>().HasData(
                new Company
                {
                    Id = 1,
                    Name = "Hesehus",
                    URL = "https://www.hesehus.dk/karriere/praktik-og-studieprojekt",
                    HasSentEmail = true,
                    Description = "",
                    EmailSent = new DateOnly(2025, 6, 23),
                    Answer = Answer.Ingen_svar,
                    SentViaWebsite = true,
                },
                new Company
                {
                    Id = 2,
                    Name = "Vitec",
                    URL = "https://jobs.vitecsoftware.dk/jobs/1208909-praktikperiode-hos-vitec-software-group",
                    HasSentEmail = true,
                    Description = "",
                    EmailSent = new DateOnly(2025, 6, 23),
                    Answer = Answer.Ingen_svar,
                    SentViaWebsite = true,
                },
                new Company
                {
                    Id = 3,
                    Name = "Viking",
                    URL = "https://www.vikingsoftware.com/get-in-touch/",
                    HasSentEmail = true,
                    Description = "Arbejder i mange sprog og frameworks som f.eks. C# og React",
                    EmailSent = new DateOnly(2025, 6, 23),
                    Answer = Answer.Ingen_svar,
                    SentViaWebsite = false,
                }
            );
            base.OnModelCreating(modelBuilder);
        }
    }
}