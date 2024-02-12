
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
    public class CourtCaseController : ControllerBase
    {
        private readonly ICourtCaseService _service;
        private readonly IMapper _mapper;
        public CourtCaseController(ICourtCaseService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult Get()
        {
            var list = _service.Get();
            var newList = _mapper.Map<IEnumerable<CourtCaseDto>>(list);
            return Ok(newList);
        }

        
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var court = _service.Get(id);
            if (court == null)
                return NotFound();
            return Ok(_mapper.Map<CourtCaseDto>(court));
        }


        [HttpGet("date")]
        public ActionResult Get(DateTime date)
        {
            var list =  _service.Get(date);
            var newList = _mapper.Map<IEnumerable<CourtCaseDto>>(list);
            return Ok(newList);
        }


        [HttpPost]
        public ActionResult Post([FromBody] CourtCasePostModel value)
        {
            var court = new CourtCase { CourtType = value.CourtType, Fees = value.Fees, OpeningDate = value.OpeningDate, CourtCaseStatus = value.CourtCaseStatus, CostumerStatusOnCourt = value.CostumerStatusOnCourt, CostumerId = value.CostumerId };
            return Ok(_service.Post(court));
        }

        
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] CourtCasePutModel value)
        {
            var court = new CourtCase { Fees = value.Fees, ClosingDate = value.ClosingDate, CourtCaseStatus = value.CourtCaseStatus, AmountToPay = value.AmountToPay };
            var res = _service.Put(id, court);
            if (res == null)
                return NotFound();
            return Ok();
        }


        [HttpPut("{id}/status")]
        public ActionResult Put(int id, [FromBody] CourtStatus status)
        {
            var res = _service.Put(id, status);
            if (res == null)
                return NotFound();
            return Ok();
        }
    }
}
