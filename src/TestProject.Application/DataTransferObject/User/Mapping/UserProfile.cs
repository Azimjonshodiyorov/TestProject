using AutoMapper;
using TestProject.Core.Entities;

namespace TestProject.Application.DataTransferObject.User.Mapping;

public class UserProfile : Profile
{
    public UserProfile()
    {
        CreateMap<TestProject.Core.Entities.User, UserDto>().ReverseMap();
        CreateMap<TestProject.Core.Entities.User, UpdateUserDto>().ReverseMap();
        CreateMap<TestProject.Core.Entities.User, CreateUserDto>().ReverseMap();
    }
}
