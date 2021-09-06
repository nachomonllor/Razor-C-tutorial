﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace agenda1.Modelos
{
    public class Contacto
    {
        
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="El nombre de categoria es obligatorio")]
        [StringLength(15, ErrorMessage = "{0} el nombre debe tener entre {2} y {1}", MinimumLength = 4)]
        public string Nombre { get; set; }

        [Required(ErrorMessage ="El mail es obligatorio")]
        public string Email { get; set; }

        [Required(ErrorMessage ="El teléfono es obligatorio")]
        public string Telefono { get; set; }

        [DataType(DataType.Date)]
        [Display(Name ="Fecha de creación")]

        public DateTime? FechaCreacion { get; set; }

        [Required]
        public int CategoriaId { get; set; }

        public Categoria Categoria { get; set; }






    }
}
