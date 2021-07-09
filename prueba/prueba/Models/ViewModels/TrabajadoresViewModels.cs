using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prueba.Models.ViewModels
{
    public class TrabajadoresViewModels
    {
        public List<Areas> Areas { get; set; }
        public List<Trabajadores> Trabajadores { get; set; }

        public List<Empresas> Empresas { get; set; }




        public Trabajadores Trabajador { get; set; }

        /*public TrabajadoresViewModels()
        {
            this.Areas = new List<Areas>();
            this.Trabajadores = new List<Trabajadores>();
            this.Empresas = new List<Empresas>();
        }*/
    }
}
