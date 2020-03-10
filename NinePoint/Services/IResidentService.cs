using NinePoint.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinePoint.Services
{
    public interface IResidentService
    {
        IQueryable<Resident> Find();
        IEnumerable<John> FindResidentBySupport();
    }
}
