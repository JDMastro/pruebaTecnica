using prueba.Data;
using prueba.Models;
using prueba.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prueba.Services.Implementations
{
    public class TrabajadoresRepository : Repository<Trabajadores>, ITrabajos
    {
        public TrabajadoresRepository(AppDbContext context) : base(context) { }
    }
}
