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
        public async Task<ActionResult> PostAsync([FromBody] PaymentPostModel value)
        {
            var p = new Payment { Sum = value.Sum, Date = value.Date, PaymentBy = value.PaymentBy, CourtCaseId = value.CourtCaseId };
            return Ok(await _service.PostAsync(p));
        }


        [HttpPut("{id}")]
        public async Task<ActionResult> PutAsync(int id, [FromBody] PaymentPostModel value)
        {
            var p = new Payment { Sum = value.Sum, Date = value.Date, PaymentBy = value.PaymentBy, CourtCaseId = value.CourtCaseId };
            var income = await _service.PutAsync(id, p);
            if (income != null)
                return Ok();
            return NotFound();
        }


        [HttpPut("{id}/sum")]
        public async Task<ActionResult> PutAsync(int id, int sum)
        {
            var income = await _service.PutAsync(id, sum);
            if (income != null)
                return Ok();
            return NotFound();
        }


        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteAsync(int id)
        {
            var income = await _service.DeleteAsync(id);
            if (income != null)
                return Ok();
            return NotFound();
        }
    }
}
