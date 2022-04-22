#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VoHoangHuy.Models;

    public class HuyDzContext : DbContext
    {
        public HuyDzContext (DbContextOptions<HuyDzContext> options)
            : base(options)
        {
        }

        public DbSet<VoHoangHuy.Models.Category> Category { get; set; }
             public DbSet<VoHoangHuy.Models.Comment> Comment { get; set; }
                     public DbSet<VoHoangHuy.Models.News> News { get; set; }
    }
