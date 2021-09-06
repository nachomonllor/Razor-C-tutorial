using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using agenda1.Datos;
using agenda1.Modelos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace agenda1.Pages.Categorias
{
    public class DetalleModel : PageModel
    {
        private readonly ApplicationDbContext _contexto;

        public DetalleModel(ApplicationDbContext context)
        {
            this._contexto = context;
        }

        [BindProperty]
        public Categoria Categoria { get; set; }

        public async Task OnGet(int id)
        {
            Categoria = await _contexto.Categoria.FindAsync(id);


        }
    }
}
