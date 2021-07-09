using prueba.Data;
using prueba.Models;
using prueba.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prueba.Services.Implementations
{
    public class EmpresasRepository : Repository<Empresas>, IEmpresas
    {
        public EmpresasRepository(AppDbContext context) : base(context) { }
    }
}
