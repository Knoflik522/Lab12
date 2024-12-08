﻿using Microsoft.EntityFrameworkCore;
namespace Lab12.Models
{
    public class AppDbContext: DbContext
    {
        public DbSet<Company> Companies { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
    }
}