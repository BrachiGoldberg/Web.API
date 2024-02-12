using AutoMapper;
using LayersOffice.API.Models;
using LayersOffice.Core.DTOs;
using LayersOffice.Core.Entities;
using LayersOffice.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LayersOffice.API.Controllers
{
    [Route("lawyer.co.il/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private readonly IPaymentService _service;
        private readonly IMapper _mapper;
        public PaymentController(IPaymentService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }


        [HttpGet]
        public ActionResult Get()
        {
            var list = _service.Get();
            var newList = _mapper.Map<IEnumerable<PaymentDto>>(list);
            return Ok(newList);
        }


        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var p = _service.Get(id);
            if (p == null)
                return NotFound();
            return Ok(_mapper.Map<PaymentDto>(p));
        }


        [HttpPost]
        public ActionResult Post([FromBody] PaymentPostModel value)
        {
            var p = new Payment { Sum = value.Sum, Date = value.Date, PaymentBy = value.PaymentBy, CourtCaseId = value.CourtCaseId };
            return Ok(_service.Post(p));
        }


        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] PaymentPostModel value)
        {
            var p = new Payment { Sum = value.Sum, Date = value.Date, PaymentBy = value.PaymentBy, CourtCaseId = value.CourtCaseId };
            var income = _service.Put(id, p);
            if (income != null)
                return Ok();
            return NotFound();
        }


        [HttpPut("{id}/sum")]
        public ActionResult Put(int id, int sum)
        {
            var income = _service.Put(id, sum);
            if (income != null)
                return Ok();
            return NotFound();
        }


        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var income = _service.Delete(id);
            if (income != null)
                return Ok();
            return NotFound();
        }
    }
}
