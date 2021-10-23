using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IDCCombustible1.Models
{
    interface IConduceService
    {
        IEnumerable<Conduce> GetConduces();
        void InsertConduce(Conduce conduce);
        void UpdateConduce(int id, Conduce conduce);
        Conduce SingleConduce(int id);
        void DeleteConduce(int id);
        IEnumerable<Activo> GetActivos();
    }
}
