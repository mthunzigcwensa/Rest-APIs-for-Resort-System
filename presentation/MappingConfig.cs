﻿using AutoMapper;
using presentation.Models.Dto;

namespace presentation
{
    public class MappingConfig : Profile
    {
        public MappingConfig()
        {
            CreateMap<ResortDTO, ResortCreateDTO>().ReverseMap();
            CreateMap<ResortDTO, ResortUpdateDTO>().ReverseMap();

            CreateMap<ResortNumberDTO, ResortNumberCreateDTO>().ReverseMap();
            CreateMap<ResortNumberDTO, ResortNumberUpdateDTO>().ReverseMap();
        }
    }
}
