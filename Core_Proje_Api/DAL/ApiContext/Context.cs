﻿using Core_Proje_Api.DAL.Entity;
using Microsoft.EntityFrameworkCore;

namespace Core_Proje_Api.DAL.ApiContext
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server = DESKTOP-SHJ8E5B\\SQLEXPRESS01;database=CoreProjeDB2;integrated security=true");
        }
        public DbSet<Category> Categories { get; set; }
    }
}