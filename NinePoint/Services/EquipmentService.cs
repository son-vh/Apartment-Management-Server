using NinePoint.Entities;
using NinePoint.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace NinePoint.Services
{
    public class EquipmentService : IEquipmentService
    {
        private readonly IUnitOfWork _unitOfWork;

        public EquipmentService(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        public void Add(Equipment equipment)
        {
            _unitOfWork.equipmentReponsitory.Add(equipment);
            _unitOfWork.SaveAsync();
        }

        public void Delete(Equipment equipment)
        {
            _unitOfWork.equipmentReponsitory.Delete(equipment);
            _unitOfWork.SaveAsync();
        }

        public virtual IQueryable<Equipment> Find()
        {
            return _unitOfWork.equipmentReponsitory.Find();
        }

        public Task<Equipment> FindByIdAsync(object id)
        {
            return _unitOfWork.equipmentReponsitory.FindByIdAsync(id);
        }

        public void Update(Equipment equipment)
        {
            _unitOfWork.equipmentReponsitory.Update(equipment);
            _unitOfWork.SaveAsync();
        }

        public IQueryable<Equipment> FindByResidentId(int residentId)
        {
            return _unitOfWork.equipmentReponsitory.FindByResidentId(residentId);

        }
    }
}