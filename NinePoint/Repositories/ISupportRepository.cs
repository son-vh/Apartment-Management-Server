using NinePoint.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinePoint.Repositories
{
    public interface ISupportRepository : IGenericRepository<Support>
    {
        IQueryable<Support> FindSupportById(int key);
    }
}
