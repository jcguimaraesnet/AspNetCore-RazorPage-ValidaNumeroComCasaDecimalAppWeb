using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ValidaNumeroComCasaDecimalAppWeb.Data;
using ValidaNumeroComCasaDecimalAppWeb.Models;

namespace ValidaNumeroComCasaDecimalAppWeb.Pages
{
    public class DetailsModel : PageModel
    {
        private readonly ValidaNumeroComCasaDecimalAppWeb.Data.ValidaNumeroComCasaDecimalAppWebContext _context;

        public DetailsModel(ValidaNumeroComCasaDecimalAppWeb.Data.ValidaNumeroComCasaDecimalAppWebContext context)
        {
            _context = context;
        }

      public Produto Produto { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Produto == null)
            {
                return NotFound();
            }

            var produto = await _context.Produto.FirstOrDefaultAsync(m => m.Id == id);
            if (produto == null)
            {
                return NotFound();
            }
            else 
            {
                Produto = produto;
            }
            return Page();
        }
    }
}
