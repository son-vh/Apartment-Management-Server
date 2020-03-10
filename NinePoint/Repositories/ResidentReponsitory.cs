using NinePoint.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NinePoint.Repositories
{
    public class ResidentReponsitory : GenericRepository<Resident>, IResidentReponsitory
    {
        public ResidentReponsitory(ManageApartmentDbContext context) : base(context)
        {
            _context = context;
            _dbSet = context.Set<Resident>();
        }


        public IEnumerable<John> FindResidentBySupport()
        {
            var res = _context.Residents.Join(_context.Supports,
                                                    e => e.Id,
                                                    d => d.ResidentId,
                                                    (resident, support) => new John
                                                    {
                                                        ResidentName = resident.ResidentName,
                                                        ResidentImage = resident.ResidentImage
                                                    }
                                                    ).ToList();
            return res;
        }
    }
}