using prueba.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prueba.Services.Interfaces
{
    public interface ITrabajos : IRepository<Trabajadores>
    {
        Task<List<Trabajadores>> ObtenerTrabajadoresporSp();
        Task<List<Trabajadores>> IngresarTrabajadoresJefeporSp(Trabajadores t);

        Task<List<Trabajadores>> ActualizarTrabajadoresJefeporSp(Trabajadores t);

    }
}
