using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAPIProject1.Models;

namespace WebAPIProject1.Data
{
    public class WebProject1DbContext : DbContext
    {
        public WebProject1DbContext (DbContextOptions<WebProject1DbContext> options)
            : base(options)
        {
        }

        public DbSet<WebAPIProject1.Models.EmpProfile> EmpProfile { get; set; } = default!;
    }
}
