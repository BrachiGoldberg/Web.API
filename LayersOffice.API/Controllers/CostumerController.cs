using AutoMapper;
using LayersOffice.API.Models;
using LayersOffice.Core.DTOs;
using LayersOffice.Core.Entities;
using LayersOffice.Core.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LayersOffice.API.Controllers
{
    [Route("lawyer.co.il/[controller]")]
    [ApiController]
    public class CostumerController : ControllerBase
    {
        private readonly ICostumerService _service;
        private readonly IMapper _mapper;
        public CostumerController(ICostumerService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult Get()
        {
            var list = _service.Get();
            var listDto = _mapper.Map<IEnumerable<CostumerDto>>(list);
            return Ok(listDto);
        }

        
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var c = _service.Get(id);
            if (c == null)
                return NotFound();
            return Ok(_mapper.Map<CostumerDto>(c));
        }

        
        [HttpPost]
        public async Task<ActionResult> PostAsync([FromBody] CostumerPostModel value)
        {
            var c = new Costumer() { FirstName = value.FirstName, LastName = value.LastName, Address = value.Address, Email = value.Email, PhoneNumber = value.PhoneNumber };
            var newCostumer =await _service.PostAsync(c);
            return Ok(newCostumer);
        }

        
        [HttpPut("{id}")]
        public async Task<ActionResult> PutAsync(int id, [FromBody] CostumerPostModel value)
        {
            var newC = new Costumer { Address = value.Address, Email = value.Email, PhoneNumber = value.PhoneNumber, FirstName = value.FirstName, LastName = value.LastName };
            var c =await _service.PutAsync(id, newC);
            if (c == null)
                return NotFound();
            return Ok();
        }
    }
}
