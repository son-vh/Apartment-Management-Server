using NinePoint.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinePoint.Services
{
    public interface IEquipmentService
    {
        void Add(Equipment equipment);
        IQueryable<Equipment> Find();
        IQueryable<Equipment> FindByResidentId(int residentId);
        void Delete(Equipment equipment);
        Task<Equipment> FindByIdAsync(object id);
        void Update(Equipment equipment);

    }
}
