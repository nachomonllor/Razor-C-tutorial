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
    public class BorrarModel : PageModel
    {
        private readonly ApplicationDbContext _contexto;

        public BorrarModel(ApplicationDbContext context)
        {
            this._contexto = context;
        }

        [BindProperty]
        public Categoria Categoria { get; set; }

        public async Task OnGet(int id)
        {
            Categoria = await _contexto.Categoria.FindAsync(id);


        }

        public async Task<IActionResult> OnPost()
        {

            var CategoriaDesdeDb = await _contexto.Categoria.FindAsync(Categoria.Id);

            if (CategoriaDesdeDb == null)
            {
                return NotFound();
            }

            _contexto.Categoria.Remove(CategoriaDesdeDb);

            await _contexto.SaveChangesAsync();
            return RedirectToPage("Index");


        }

    }
}
