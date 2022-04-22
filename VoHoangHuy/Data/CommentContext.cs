#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VoHoangHuy.Models;

    public class CommentContext : DbContext
    {
        public CommentContext (DbContextOptions<CommentContext> options)
            : base(options)
        {
        }

        public DbSet<VoHoangHuy.Models.Comment> Comment { get; set; }
    }
