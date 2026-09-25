using INT.Applaction.Iservises;
using INT.Domain.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace INT.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OwnerController : ControllerBase
    {
        private readonly IOwnerServises _ownerService;
        public OwnerController(IOwnerServises ownerService)
        {
            _ownerService = ownerService;
        }

        
        [HttpPost("AddOwner")]
        public IActionResult AddOwner(Owner owner)
        {
            _ownerService.AddOwner(owner);

            return Ok(owner);
        }

        [HttpPut("Update")]
        public IActionResult UpdateOwner(Owner owner)
        {
            var existingOwner = _ownerService.GetById(owner.OwnerId);

            _ownerService.Update(owner);

            return Ok(owner);
        }
        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var owners = _ownerService.GetAll();
            return Ok(owners);
        }

        [HttpGet("GetById/{Id}")]
        public IActionResult GetById(int id)
        {
            var owner = _ownerService.GetById(id);
            return Ok(owner);
        }

        [HttpPut("Delete/{Id}")]
        public IActionResult DeleteOwner(int id)
        {
            var existingOwner = _ownerService.GetById(id);

            return Ok("Delete By Id");
        }

    }



}
