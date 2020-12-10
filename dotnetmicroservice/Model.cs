using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace dotnetmicroservice
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext()
        {
            _connectionString = "host=localhost;database=postgresdb;user id=root;password=onlyfordev";
        }

        public ApiDbContext(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("Default");
        }

        protected string _connectionString { get; }

        public DbSet<Robot> Robots { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseNpgsql(_connectionString);
    }

    public class Robot
    {
        public int Id { get; set; }
        public int positionX { get; set; }
        public int positionY { get; set; }
    }
}