using System.Linq;
using AutoMapper;
using DatingApp.API.DTOs;
using DatingApp.API.Models;

namespace DatingApp.API.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        #region Constructors
        public AutoMapperProfiles()
        {
            CreateMap<User, UserForListDto>()
                .ForMember(dest => dest.MainPhoto, opt => {
                   opt.MapFrom(src => src.Photos.FirstOrDefault(p =>p.IsMain)); 
                }).ForMember(dest => dest.Age, opt => opt.MapFrom(src => src.DateOfBirth.CalculateAge()));

            CreateMap<User, UserForDetailDto>()
                .ForMember(dest => dest.MainPhoto, opt => {
                   opt.MapFrom(src => src.Photos.FirstOrDefault(p =>p.IsMain)); 
                }).ForMember(dest => dest.Age, opt => opt.MapFrom(src => src.DateOfBirth.CalculateAge()));;
            CreateMap<Photo, PhotosForDisplayDto>();
        }
        #endregion
    }
}