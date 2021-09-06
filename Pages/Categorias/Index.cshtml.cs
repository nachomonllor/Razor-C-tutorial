using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using agenda1.Datos;
using agenda1.Modelos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace agenda1.Pages.Categorias
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _contexto;

        public IndexModel(ApplicationDbContext context)
        {
            this._contexto = context;
        }

        public IEnumerable<Categoria> Categorias { get; set; }

        public async Task OnGet()
        {
            Categorias = await _contexto.Categoria.ToListAsync();
            

        }
    }
}
