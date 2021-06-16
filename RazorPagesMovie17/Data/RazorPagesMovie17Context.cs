using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie17.Models;

namespace RazorPagesMovie17.Data
{
    public class RazorPagesMovie17Context : DbContext
    {
        public RazorPagesMovie17Context (DbContextOptions<RazorPagesMovie17Context> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesMovie17.Models.Movie> Movie { get; set; }
    }
}
