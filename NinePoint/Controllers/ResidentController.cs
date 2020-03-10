using Microsoft.AspNet.OData;
using Microsoft.AspNet.OData.Routing;
using NinePoint.Entities;
using NinePoint.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace NinePoint.Controllers
{
    public class ResidentController : ODataController
    {
        private readonly IResidentService _residentService;

        public ResidentController(IResidentService residentService)
        {
            this._residentService = residentService;
        }

        [EnableQuery]
        public IQueryable<Resident> Get()
        {
            return _residentService.Find();

        }

        [HttpGet]
        [ODataRoute("FindResidentBySupport()")]
        public IEnumerable<John> FindResidentBySupport()
        {
            return _residentService.FindResidentBySupport();

        }
    }
}