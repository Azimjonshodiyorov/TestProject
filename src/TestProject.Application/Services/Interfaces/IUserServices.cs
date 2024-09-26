using TestProject.Application.DataTransferObject.User;
using TestProject.Core.Common;

namespace TestProject.Application.Services.Interfaces;

public interface IUserService
{
    Task<PagedResult<UserDto>> GetListAsync(int pageNumber, int pageSize);
    Task<UserDto> GetAsync(long id);
    Task<UserDto> CreateAsync(CreateUserDto dto);
    Task<UserDto> UpdateAsync(UpdateUserDto dto);
    Task<UserDto> DeleteAsync(long id);
}
