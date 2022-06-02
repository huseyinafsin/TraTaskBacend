using AutoMapper;
using TraLoginApi.Data.Dtos;
using TraLoginApi.Data.Models;

namespace TraLoginApi.Mapping
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User,UserInfoDto>().ReverseMap();
            CreateMap<UserInfoDto, User>();

        }
    }
}
