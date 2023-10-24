using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ValidaNumeroComCasaDecimalAppWeb.Models;

namespace ValidaNumeroComCasaDecimalAppWeb.Data
{
    public class ValidaNumeroComCasaDecimalAppWebContext : DbContext
    {
        public ValidaNumeroComCasaDecimalAppWebContext (DbContextOptions<ValidaNumeroComCasaDecimalAppWebContext> options)
            : base(options)
        {
        }

        public DbSet<ValidaNumeroComCasaDecimalAppWeb.Models.Produto> Produto { get; set; } = default!;
    }
}
