using NinePoint.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinePoint.Services
{
    public interface ISupportService
    {
        IQueryable<Support> Find();
        void Add(Support support);
        IQueryable<Support> FindSupportById(int key);
    }
}
