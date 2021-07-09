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
    public class TrabajadoresRepository : Repository<Trabajadores>, ITrabajos
    {
        public TrabajadoresRepository(AppDbContext context) : base(context) { }

        public async Task<List<Trabajadores>> ActualizarTrabajadoresJefeporSp(Trabajadores t)
        {
            var Vid = new MySqlParameter("@Vid", t.Id);
            var Vnombres = new MySqlParameter("@Vnombres", t.Nombres);
            var Vapellidos = new MySqlParameter("@Vapellidos", t.Apellidos);
            var Vdireccion = new MySqlParameter("@Vdireccion", t.Direccion);
            var Vtelefono = new MySqlParameter("@Vtelefono", t.Telefono);
            var Vsalario = new MySqlParameter("@Vsalario", t.Salario);

            return await Context.Trabajadores.FromSqlRaw("call test.SpUpdateTrabajadorJefe(@Vid,@Vnombres,@Vapellidos,@Vdireccion,@Vtelefono,@Vsalario)", 
                parameters : new[] { Vid, Vnombres, Vapellidos, Vdireccion, Vtelefono, Vsalario }).ToListAsync();
        }

        public async Task<List<Trabajadores>> IngresarTrabajadoresJefeporSp(Trabajadores t)
        {
            var Vnombres = new MySqlParameter("@Vnombres", t.Nombres);
            var Vapellidos = new MySqlParameter("@Vapellidos", t.Apellidos);
            var Vdireccion = new MySqlParameter("@Vdireccion", t.Direccion);
            var Vtelefono = new MySqlParameter("@Vtelefono", t.Telefono);
            var Vsalario = new MySqlParameter("@Vsalario", t.Salario);
            var VareasId = new MySqlParameter("@VareasId", t.AreasId);
            var VfechaIngreso = new MySqlParameter("@VfechaIngreso", t.FechaIngreso);
            var Vsexo = new MySqlParameter("@Vsexo", t.Sexo);
            var VempresasId = new MySqlParameter("@VempresasId", t.EmpresasId);



            return await Context.Trabajadores.FromSqlRaw("call test.SpInsertarTrabajadorJefe(@Vnombres, @Vapellidos, @Vdireccion, @Vtelefono, @Vsalario, @VareasId, @VfechaIngreso, @Vsexo, @VempresasId);",
                parameters : new[] { Vnombres, Vapellidos, Vdireccion, Vtelefono, Vsalario, VareasId, VfechaIngreso, Vsexo, VempresasId }).ToListAsync();
        }

        public async Task<List<Trabajadores>> IngresarTrabajadoresNormalporSp(Trabajadores t)
        {
            var Vnombres = new MySqlParameter("@Vnombres", t.Nombres);
            var Vapellidos = new MySqlParameter("@Vapellidos", t.Apellidos);
            var Vdireccion = new MySqlParameter("@Vdireccion", t.Direccion);
            var Vtelefono = new MySqlParameter("@Vtelefono", t.Telefono);
            var Vsalario = new MySqlParameter("@Vsalario", t.Salario);
            var VareasId = new MySqlParameter("@VareasId", t.AreasId);
            var VfechaIngreso = new MySqlParameter("@VfechaIngreso", t.FechaIngreso);
            var Vsexo = new MySqlParameter("@Vsexo", t.Sexo);
            var VempresasId = new MySqlParameter("@VempresasId", t.EmpresasId);



            return await Context.Trabajadores.FromSqlRaw("call test.SpInsertarTrabajadorNormal(@Vnombres, @Vapellidos, @Vdireccion, @Vtelefono, @Vsalario, @VareasId, @VfechaIngreso, @Vsexo, @VempresasId);",
                parameters: new[] { Vnombres, Vapellidos, Vdireccion, Vtelefono, Vsalario, VareasId, VfechaIngreso, Vsexo, VempresasId }).ToListAsync();
        }

        public async Task<List<Trabajadores>> ObtenerTrabajadoresporSp()
        {
            return await Context.Trabajadores.FromSqlRaw("call test.SpObtenerTrabajadores();").ToListAsync();
        }
    }
}
