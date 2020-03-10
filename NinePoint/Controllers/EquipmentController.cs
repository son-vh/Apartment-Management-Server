using Microsoft.AspNet.OData;
using Microsoft.AspNet.OData.Routing;
using NinePoint.Entities;
using NinePoint.Services;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace NinePoint.Controllers
{
    public class EquipmentController : ODataController
    {
        private readonly IEquipmentService _equipmentService;

        public EquipmentController(IEquipmentService equipmentService)
        {
            this._equipmentService = equipmentService;
        }

        [EnableQuery]
        public IQueryable<Equipment> Get()
        {
            return _equipmentService.Find();

        }

        [HttpGet]
        [ODataRoute("GetEquipmentByResident(Id={residentId})")]
        public IHttpActionResult GetEquipmentByResident([FromODataUri] int residentId)
        {
            var product = _equipmentService.FindByResidentId(residentId);
            return Ok(product);
        }

        public IHttpActionResult Post(Equipment equipment)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            _equipmentService.Add(equipment);
            return Created(equipment);
        }


        public IHttpActionResult Put([FromODataUri] int key, Equipment update)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if (key != update.Id)
            {
                return BadRequest();
            }
            _equipmentService.Update(update);
            return Updated(update);
        }

        public async Task<IHttpActionResult> Delete([FromODataUri]int key)
        {
            var equipment = await _equipmentService.FindByIdAsync(key);
            if (equipment == null)
            {
                return NotFound();
            }
            _equipmentService.Delete(equipment);
            return StatusCode(HttpStatusCode.NoContent);
        }

    }
}