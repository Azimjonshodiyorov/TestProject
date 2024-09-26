using AutoMapper;
using TestProject.Core.Entities;

namespace TestProject.Application.DataTransferObject.Post.Mapping;

public class PostProfile : Profile
{
    public PostProfile()
    {
        CreateMap<TestProject.Core.Entities.Post , PostDto>().ReverseMap();
        CreateMap<TestProject.Core.Entities.Post , PostDto>();
        CreateMap<TestProject.Core.Entities.Post , CreatePostDto>().ReverseMap();
        CreateMap<TestProject.Core.Entities.Post , UpdatePostDto>().ReverseMap();
    }
}
