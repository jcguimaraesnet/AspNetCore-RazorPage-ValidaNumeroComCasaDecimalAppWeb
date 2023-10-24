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
    public class DeleteModel : PageModel
    {
        private readonly ValidaNumeroComCasaDecimalAppWeb.Data.ValidaNumeroComCasaDecimalAppWebContext _context;

        public DeleteModel(ValidaNumeroComCasaDecimalAppWeb.Data.ValidaNumeroComCasaDecimalAppWebContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Produto == null)
            {
                return NotFound();
            }
            var produto = await _context.Produto.FindAsync(id);

            if (produto != null)
            {
                Produto = produto;
                _context.Produto.Remove(Produto);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
