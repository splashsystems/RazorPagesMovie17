using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie17.Data;
using RazorPagesMovie17.Models;

namespace RazorPagesMovie17.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesMovie17.Data.RazorPagesMovie17Context _context;

        public IndexModel(RazorPagesMovie17.Data.RazorPagesMovie17Context context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
