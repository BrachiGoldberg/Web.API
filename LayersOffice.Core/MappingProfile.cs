using AutoMapper;
using LayersOffice.Core.DTOs;
using LayersOffice.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayersOffice.Core
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Costumer, CostumerDto>().ReverseMap();
            CreateMap<CourtCase, CourtCaseDto>().ReverseMap();
            CreateMap<Payment, PaymentDto>().ReverseMap();
        }
    }
}
