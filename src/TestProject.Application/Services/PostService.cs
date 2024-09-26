using TestProject.Application.DataTransferObject.Post;
using TestProject.Application.DataTransferObject.User;
using TestProject.Application.Services.Interfaces;
using TestProject.Core.Common;

namespace TestProject.Application.Services;

public class PostService : IPostService
{

    public PostService()
    {
        
    }
    public Task<PostDto> CreateAsync(CreateUserDto dto)
    {
        throw new NotImplementedException();
    }

    public Task<PostDto> DeleteAsync(long id)
    {
        throw new NotImplementedException();
    }

    public Task<PostDto> GetAsync(long id)
    {
        throw new NotImplementedException();
    }

    public Task<PagedResult<PostDto>> GetListAsync(int pageNumber, int pageSize)
    {
        throw new NotImplementedException();
    }

    public Task<PostDto> UpdateAsync(UpdateUserDto dto)
    {
        throw new NotImplementedException();
    }
}
