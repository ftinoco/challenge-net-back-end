using AutoMapper;
using ChallengeNetBackEnd.Models;
using ChallengeNetBackEnd.Models.DTOs;

namespace ChallengeNetBackEnd.Utils.Mappers
{
    public class UserMapper : Profile
    {
        public UserMapper()
        {
            CreateMap<User, UserDTO>()
                .ForMember(dest => dest.Fullname,
                    src => src.MapFrom(x => $"{x.FirstName} {x.Surname}"))
                .ForMember(dest => dest.CreationDate,
                    src => src.MapFrom(x => x.Created))
                .ForMember(dest => dest.AdvisorFullname,
                    src => src.MapFrom(x => x.Advisor != null ? 
                             $"{x.Advisor.FirstName} {x.Advisor.Surname}"
                             : string.Empty)
                    );
        }
    }
}
