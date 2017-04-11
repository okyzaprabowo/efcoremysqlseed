using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using EFCoreMySQLContext.Models;
using MySQL.Data.EntityFrameworkCore.Extensions;

namespace EFCoreMySQLContext.Helpers
{
    public class BaseContext : DbContext
    {
        public static BaseContext Connect(string connectionString)
        {
            var optionsBuilder = new DbContextOptionsBuilder<BaseContext>();
            optionsBuilder.UseMySQL(connectionString);

            //Ensure database creation
            var context = new BaseContext(optionsBuilder.Options);
            context.Database.EnsureCreated();

            return context;
        }

        public BaseContext(DbContextOptions<BaseContext> options)
            : base(options)
        {

        }

        public DbSet<Example> Example { get; set; }
    }
}
