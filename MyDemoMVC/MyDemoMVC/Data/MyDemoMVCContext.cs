using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyDemoMVC.Models;

namespace MyDemoMVC.Data
{
    public class MyDemoMVCContext : DbContext
    {
        public MyDemoMVCContext (DbContextOptions<MyDemoMVCContext> options)
            : base(options)
        {
        }

        public DbSet<MyDemoMVC.Models.Filme> Filme { get; set; }
    }
}
