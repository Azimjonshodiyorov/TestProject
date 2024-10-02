using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TestProject.Application.DataTransferObject.Post;
using TestProject.Application.DataTransferObject.User;
using TestProject.Application.Services.Interfaces;
using TestProject.Core.Common;
using TestProject.Core.Entities;
using TestProject.Infrastructure.Repositories.Interfaces;

namespace TestProject.Application.Services;

public class UserService : IUserService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public UserService(IUnitOfWork unitOfWork , IMapper mapper )
    {
        this._unitOfWork = unitOfWork;
        this._mapper = mapper;
    }
    public async Task<UserDto> CreateAsync(CreateUserDto dto)
    {
        try
        {
             var user = _mapper.Map<User>(dto);
            await this._unitOfWork.Users.AddAsync(user);
            await this._unitOfWork.SaveChangesAsync();
            var result = this._mapper.Map<UserDto>(user);
            return result;
        }
        catch( Exception ex ) 
        {
            throw new Exception($"{ex.StackTrace } : {ex.InnerException}");
        }
    }

    public async Task<UserDto> DeleteAsync(long id)
    {
        var user = await this._unitOfWork.Users.GetAsync(id);

        if (user is null)
            throw new Exception("User service delete error");
        await this._unitOfWork.Users.DeleteAsync(user);
        await this._unitOfWork.SaveChangesAsync(); 
        var result = this._mapper.Map<UserDto>(user) ;
        return result;
    }        

    public async Task<UserDto> GetAsync(long id)
    {  
         var user = await this._unitOfWork.Users.GetAsync(id);
        if (user is null)
            throw new Exception("User service Get error");
        var result = this._mapper.Map<UserDto>(user); 
        return result; 

    } 

    public async Task<PagedResult<UserDto>> GetListAsync(int pageNumber, int pageSize)
    {
        var query = this._unitOfWork.Users.Entities.AsQueryable();

        var paged = PagedResult<User>.Paginate(query, pageNumber, pageSize); 

        var userDto = this._mapper.Map<List<UserDto>>(paged.Items);

        return new PagedResult<UserDto>
        (
            userDto,
            paged.TotalRecords,
            paged.PageNumber,
            paged.PageSize
        );
    }

    public async Task<UserDto> UpdateAsync(UpdateUserDto dto)
    {
        var user = this._mapper.Map<User>(dto);
        await this._unitOfWork.Users.UpdateAsync(user);
        await this._unitOfWork.SaveChangesAsync();
        var result = this._mapper.Map<UserDto>(user);
        return result;
    }
}
