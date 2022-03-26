using AutoMapper;
using SparkPlug.Core;
using SparkPlug.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SparkPlug.Helpers
{
    public class AutoMappingProfile : Profile
    {
        public AutoMappingProfile()
        {
            CreateMap<FeedbackDto, Feedback>()
                .ForMember(f => f.FormName, opt => opt.MapFrom(src => src._formName))
                .ForMember(f => f.DomainName, opt => opt.MapFrom(src => src._formDomainName));
        }
    }
}
