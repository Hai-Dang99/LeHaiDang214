using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LeHaiDang214.Models;

    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext (DbContextOptions<ApplicationDBContext> options)
            : base(options)
        {
        }

        public DbSet<LeHaiDang214.Models.UniversityLHD214> UniversityLHD214 { get; set; }

        public DbSet<LeHaiDang214.Models.LHD0214> LHD0214 { get; set; }
    }
