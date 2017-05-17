using AutoMapper;
using System.Linq;
using NewCo.Controllers.Resources;
using NewCo.Core.Models;

namespace NewCo.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            // Domain to API Resource
            CreateMap<Account, AccountResource>();
        }
        
    }
}