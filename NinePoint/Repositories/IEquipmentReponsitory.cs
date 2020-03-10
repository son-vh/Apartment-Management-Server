using NinePoint.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinePoint.Repositories
{
    public interface IEquipmentReponsitory:IGenericRepository<Equipment>
    {
        IQueryable<Equipment> FindByResidentId(int residentId);


    }
}
