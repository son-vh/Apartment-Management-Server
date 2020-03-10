using Microsoft.AspNet.OData;
using Microsoft.AspNet.OData.Routing;
using NinePoint.Entities;
using NinePoint.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace NinePoint.Controllers
{
    public class SupportController : ODataController
    {
        private readonly ISupportService _supportService;

        public SupportController(ISupportService supportService)
        {
            this._supportService = supportService;
        }

        [EnableQuery]
        public IQueryable<Support> Get()
        {
            return _supportService.Find();

        }

        [HttpGet]
        [ODataRoute("FindSupportById(Id={key})")]
        public IQueryable<Support> FindSupportById([FromODataUri] int key)
        {
            return _supportService.FindSupportById(key);    
        }       


        public IHttpActionResult Post(Support support)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            _supportService.Add(support);
            return Created(support);
        }
    }
}