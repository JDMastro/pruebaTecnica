using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace prueba.Models
{
    public class Empresas
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Nombre de la compañia")]
        public string Descripcion { get; set; }


        public List<Trabajadores> Trabajadores { get; set; }
    }
}
