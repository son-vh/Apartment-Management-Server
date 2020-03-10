using NinePoint.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NinePoint.Repositories
{
    public class SupportRepository : GenericRepository<Support>, ISupportRepository
    {
        public SupportRepository(ManageApartmentDbContext context) : base(context)
        {
            _context = context;
            _dbSet = context.Set<Support>();
        }

        public IQueryable<Support> FindSupportById(int key)
        {
            var support = _context.Supports.Where(s => s.Id == key);
            return support;

        }
    }
}