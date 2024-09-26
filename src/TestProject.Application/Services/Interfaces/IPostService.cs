using TestProject.Application.DataTransferObject.Post;
using TestProject.Application.DataTransferObject.User;
using TestProject.Core.Common;

namespace TestProject.Application.Services.Interfaces;

public interface IPostService
{
    Task<PagedResult<PostDto>> GetListAsync(int pageNumber, int pageSize);
    Task<PostDto> GetAsync(long id);
    Task<PostDto> CreateAsync(CreateUserDto dto);
    Task<PostDto> UpdateAsync(UpdateUserDto dto);
    Task<PostDto> DeleteAsync(long id);
}
