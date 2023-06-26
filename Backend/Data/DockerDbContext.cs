using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Backend.Models;

    public class DockerDbContext : DbContext
    {
        public DockerDbContext (DbContextOptions<DockerDbContext> options)
            : base(options)
        {
        }

        public DbSet<Backend.Models.Food> Food { get; set; } = default!;
    }
