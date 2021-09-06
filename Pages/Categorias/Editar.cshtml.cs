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
    public class EditarModel : PageModel
    {
        private readonly ApplicationDbContext _contexto;

        public EditarModel(ApplicationDbContext context)
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
            if(ModelState.IsValid)
            {
                var CategoriaDesdeDb = await _contexto.Categoria.FindAsync(Categoria.Id);
                CategoriaDesdeDb.Nombre = Categoria.Nombre;
                CategoriaDesdeDb.FechaCreacion = Categoria.FechaCreacion;
                await _contexto.SaveChangesAsync();
                return RedirectToPage("Index");
            }
            return RedirectToPage();
        }

    }
}
