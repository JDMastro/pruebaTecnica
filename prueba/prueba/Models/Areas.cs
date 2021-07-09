using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace prueba.Models
{
    public class Areas
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Es requerido un nombre para el area")]
        [Display(Name = "Nombre del area")]
        public string Descripcion { get; set; }

        [Display(Name = "Jefe de area")]
        public int TrabajadoresId { get; set; }

        public List<Trabajadores> Trabajadores { get; set; }
    }
}
