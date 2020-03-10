using NinePoint.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace NinePoint.Repositories
{
    public class EquipmentReponsitory : GenericRepository<Equipment>, IEquipmentReponsitory
    {     
        public EquipmentReponsitory(ManageApartmentDbContext context) : base(context)
        {
            _context = context;
            _dbSet = context.Set<Equipment>();
        }


        public IQueryable<Equipment> FindByResidentId(int residentId)
        {
            var equipment = _context.Equipments.Where(s => s.ResidentId == residentId);                 
            return equipment;

        }
    }
}