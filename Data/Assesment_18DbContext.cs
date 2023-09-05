using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAppAssesment_18.Models;

namespace WebAppAssesment_18.Data
{
    public class Assesment_18DbContext : DbContext
    {
        public Assesment_18DbContext (DbContextOptions<Assesment_18DbContext> options)
            : base(options)
        {
        }

        public DbSet<WebAppAssesment_18.Models.Movie> Movie { get; set; } = default!;
    }
}
