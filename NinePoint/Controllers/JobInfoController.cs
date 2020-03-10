using Microsoft.AspNet.OData;
using NinePoint.Entities;
using NinePoint.Repositories;
using NinePoint.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace NinePoint.Controllers
{
    public class JobInfoController : ODataController
    {
        private readonly IJobInfoService _jobInfoService;

        public JobInfoController(IJobInfoService jobInfoService)
        {
            this._jobInfoService = jobInfoService;
        }
      
        public IEnumerable<JobInfo> Get()
        {
            return _jobInfoService.GetData();
        }
    }
       
}