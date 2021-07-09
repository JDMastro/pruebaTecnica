using Microsoft.EntityFrameworkCore;
using MySqlConnector;
using prueba.Data;
using prueba.Models;
using prueba.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prueba.Services.Implementations
{
    public class AreasRepository : Repository<Areas>, IAreas
    {
        public AreasRepository(AppDbContext context) : base(context) { }

        public async Task<List<Areas>> ActualizarAreasSp(Areas a)
        {
            var Vdescripcion = new MySqlParameter("@Vdescripcion", a.Descripcion);
            var Vid = new MySqlParameter("@Vid", a.Id);
            return await Context.Areas.FromSqlRaw("call SpActualizarArea(@Vid, @Vdescripcion)", parameters: new[] { Vid, Vdescripcion }).ToListAsync();
        }

        public async Task<List<Areas>> InsertarAreasporSp(Areas a)
        {
            var Vdescripcion = new MySqlParameter("@Vdescripcion", a.Descripcion);
            return await Context.Areas.FromSqlRaw("call test.SpInsertarAreas(@Vdescripcion)", parameters: new[] { Vdescripcion }).ToListAsync();
        }

        public async Task<List<Areas>> ObtenerAreasporIdSp(int? id)
        {
            var Vid = new MySqlParameter("@Vid", id);
            return await Context.Areas.FromSqlRaw("call test.SpObtenerPorId(@Vid)", parameters : new[] { Vid }).ToListAsync();
        }

        public async Task<List<Areas>> ObtenerAreasporSp()
        {
            return await Context.Areas.FromSqlRaw("call test.SpObtenerAreas").ToListAsync();
        }
    }
}
