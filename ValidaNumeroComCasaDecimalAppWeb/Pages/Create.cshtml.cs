using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ValidaNumeroComCasaDecimalAppWeb.Data;
using ValidaNumeroComCasaDecimalAppWeb.Models;

namespace ValidaNumeroComCasaDecimalAppWeb.Pages
{
    public class CreateModel : PageModel
    {
        private readonly ValidaNumeroComCasaDecimalAppWeb.Data.ValidaNumeroComCasaDecimalAppWebContext _context;

        public CreateModel(ValidaNumeroComCasaDecimalAppWeb.Data.ValidaNumeroComCasaDecimalAppWebContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Produto Produto { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Produto == null || Produto == null)
            {
                return Page();
            }

            _context.Produto.Add(Produto);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
