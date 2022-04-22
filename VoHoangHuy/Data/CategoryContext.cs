#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VoHoangHuy.Models;

    public class CategoryContext : DbContext
    {
        public CategoryContext (DbContextOptions<CategoryContext> options)
            : base(options)
        {
        }

        public DbSet<VoHoangHuy.Models.Category> Category { get; set; }
    }
