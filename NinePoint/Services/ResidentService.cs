using NinePoint.Entities;
using NinePoint.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NinePoint.Services
{
    public class ResidentService:IResidentService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ResidentService(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }
        public virtual IQueryable<Resident> Find()
        {
            return _unitOfWork.residentReponsitory.Find();
        }
        public IEnumerable<John> FindResidentBySupport()
        {
            return _unitOfWork.residentReponsitory.FindResidentBySupport();
        }
    }
}