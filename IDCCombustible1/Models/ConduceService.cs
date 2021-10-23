using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IDCCombustible1.Models
{
    public class ConduceService : IConduceService
    {
        private ConduceContext _context;

        public ConduceService(ConduceContext context)
        {
            _context = context;
        }

        public void DeleteConduce(int id)
        {
            try
            {
                Conduce ord = _context.Conduces.Find(id);
                _context.Conduces.Remove(ord);
                _context.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        public IEnumerable<Conduce> GetConduces()
        {
            try
            {
                return _context.Conduces.ToList();
            }
            catch
            {
                throw;
            }
        }

        public void InsertConduce(Conduce conduce)
        {
            try
            {
                _context.Conduces.Add(conduce);
                _context.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        public Conduce SingleConduce(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateConduce(int id, Conduce conduce)
        {
            try
            {
                var local = _context.Set<Conduce>().Local.FirstOrDefault(entry => entry.Id.Equals(conduce.Id));
                // check if local is not null 
                if (local != null)
                {
                    // detach
                    _context.Entry(local).State = EntityState.Detached;
                }
                _context.Entry(conduce).State = EntityState.Modified;
                _context.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        public IEnumerable<Activo> GetActivos()
        {
            try
            {
                return _context.Activos.ToList();
            }
            catch
            {
                throw;
            }
        }
    }
}
