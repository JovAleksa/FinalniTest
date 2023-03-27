using AutoMapper;
using FinalniTest.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalniTest.Models
{
    public class PaketProfile : Profile
    {
        public PaketProfile()
        {
            CreateMap<Paket, PaketDTO>();
            CreateMap <Kurir,KuririPaketiDTO>();
            CreateMap<Paket, SearchBetweenTwoNumberDTO>();
        }
    }
}
