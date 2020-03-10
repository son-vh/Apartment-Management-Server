using NinePoint.Entities;
using NinePoint.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NinePoint.Services
{
    public class JobInfoService:IJobInfoService
    {
        private readonly IUnitOfWork _unitOfWork;

        public JobInfoService(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        public IEnumerable<JobInfo> GetData()
        {
            return _unitOfWork.jobInfoRepository.GetData();
        }
    }
}