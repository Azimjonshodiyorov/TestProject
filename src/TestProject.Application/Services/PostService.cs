using AutoMapper;
using TestProject.Application.DataTransferObject.Post;
using TestProject.Application.DataTransferObject.User;
using TestProject.Application.Services.Interfaces;
using TestProject.Core.Common;
using TestProject.Core.Entities;
using TestProject.Infrastructure.Repositories.Interfaces;

namespace TestProject.Application.Services;

public class PostService : IPostService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public PostService(IUnitOfWork unitOfWork , IMapper mapper)
    {
        this._unitOfWork = unitOfWork;
        this._mapper = mapper;
    }
    public async Task<PostDto> CreateAsync(CreateUserDto dto)
    {
        var post = _mapper.Map<Post>(dto);           
        await this._unitOfWork.Posts.AddAsync(post);
        await this._unitOfWork.SaveChangesAsync();
        var result = this._mapper.Map<PostDto>(post);
        return result;
    }
    public async Task<PostDto> DeleteAsync(long id)
    {
        var post = await this._unitOfWork.Posts.GetAsync(id);
        if (post is null)   throw new Exception("Post Service error is delete");
        await this._unitOfWork.Posts.DeleteAsync(post);
        await this._unitOfWork.SaveChangesAsync();
        var result = _mapper.Map<PostDto>(post);
        return result;
    }
    public async Task<PostDto> GetAsync(long id)
    {
        var post = await _unitOfWork.Posts.GetAsync(id);
        if (post is null) throw new Exception($"Post service error  is {id} : Not found ");
        var result = _mapper.Map<PostDto>(post);
        return result;
    }
    public async Task<PagedResult<PostDto>> GetListAsync(int pageNumber, int pageSize)
    {
        var query = this._unitOfWork.Posts.Entities.AsQueryable();

        var paged = PagedResult<Post>.Paginate(query, pageNumber, pageSize);

        var postDto = this._mapper.Map<List<PostDto>>(paged.Items);

        return new PagedResult<PostDto>
        (
            postDto,
            paged.TotalRecords,
            paged.PageNumber,
            paged.PageSize
        );
    }
    public async Task<PostDto> UpdateAsync(UpdateUserDto dto)
    {
        var post = this._mapper.Map<Post>(dto);
        await  this._unitOfWork.Posts.UpdateAsync(post);
        await this._unitOfWork.SaveChangesAsync();
        var result = this._mapper.Map<PostDto>(post);
        return result;
    }
}
