using prueba.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prueba.Services.Interfaces
{
    public interface IAreas : IRepository<Areas>
    {
        Task<List<Areas>> ObtenerAreasporSp();
        Task<List<Areas>> InsertarAreasporSp(Areas a);
        Task<List<Areas>> ObtenerAreasporIdSp(int? id);
        Task<List<Areas>> ActualizarAreasSp(Areas a);
    }
}
