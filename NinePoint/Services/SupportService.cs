using NinePoint.Entities;
using NinePoint.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace NinePoint.Services
{
    public class SupportService : ISupportService
    {
        private readonly IUnitOfWork _unitOfWork;

        public SupportService(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        public virtual IQueryable<Support> Find()
        {
            return _unitOfWork.supportRepository.Find();
        }

        public void Add(Support support)
        {
            _unitOfWork.supportRepository.Add(support);
            _unitOfWork.SaveAsync();
        }

      
        public IQueryable<Support> FindSupportById(int key)
        {
            return _unitOfWork.supportRepository.FindSupportById(key);
        }
    }
}