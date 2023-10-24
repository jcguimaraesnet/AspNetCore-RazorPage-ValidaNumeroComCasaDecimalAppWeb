using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ValidaNumeroComCasaDecimalAppWeb.Models;

namespace ValidaNumeroComCasaDecimalAppWeb.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ValidaNumeroComCasaDecimalAppWeb.Data.ValidaNumeroComCasaDecimalAppWebContext _context;

        public IndexModel(ValidaNumeroComCasaDecimalAppWeb.Data.ValidaNumeroComCasaDecimalAppWebContext context)
        {
            _context = context;
        }

        public IList<Produto> Produto { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Produto != null)
            {
                Produto = await _context.Produto.ToListAsync();
            }
        }
    }
}
