using System.Linq;
using AutoMapper;
using Azad.API.Dtos;
using Azad.API.Models;

namespace Azad.API.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<User, UserForListDto>()
            .ForMember(dest => dest.PhotoUrl, opt => {
                opt.MapFrom(src => src.Photos.FirstOrDefault(p => p.IsMain).Url);
            })
            .ForMember(dest => dest.Age, opt => {
                opt.MapFrom(d => d.DateOfBirth.CalculateAge());
            });
            CreateMap<User, UserForDetailsDto>()
             .ForMember(dest => dest.PhotoUrl, opt => {
                opt.MapFrom(src => src.Photos.FirstOrDefault(p => p.IsMain).Url);
            })
               .ForMember(dest => dest.Age, opt => {
                opt.MapFrom(d => d.DateOfBirth.CalculateAge());
            });
            CreateMap<Photo, PhotoForDetailsDto>();   
            CreateMap<UserForUpdateDto, User>(); 
            CreateMap<Photo, PhotoForReturnDto>();   
            CreateMap<PhotoForCreationDto,Photo>();                                        
                            
        }
    }
}