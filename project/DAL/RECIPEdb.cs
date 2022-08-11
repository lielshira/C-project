using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public class RECIPEdb:DbContext
    {
        public RECIPEdb(DbContextOptions<RECIPEdb>options):base(options)
        {

        }
        public DbSet<Layer> Layers { get; set; }
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<User> Users { get; set; }

    }
}
