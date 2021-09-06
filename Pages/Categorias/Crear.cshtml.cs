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
    public class CrearModel : PageModel
    {
        private readonly ApplicationDbContext _contexto;

        public CrearModel(ApplicationDbContext context)
        {
            this._contexto = context;
        }

        [BindProperty]
        public Categoria Categoria { get; set; }

        public void OnGet()
        {


        }

        public async Task<IActionResult> OnPost()
        {
            if(ModelState.IsValid)
            {
                await _contexto.Categoria.AddAsync(Categoria);
                await _contexto.SaveChangesAsync();
                return RedirectToPage("Index");
            }
            return Page();
        }
    }
}
