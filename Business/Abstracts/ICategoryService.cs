using Business.Dtos.Requests.CategoryRequest;
using Business.Dtos.Responses.CategoryResponse;
using Core.DataAccess.Paging;

namespace Business.Abstracts
{
    public interface ICategoryService
    {
        Task<Paginate<GetListCategoryResponse>> GetListAsync();
        Task<CreatedCategoryResponse> Add(CreateCategoryRequest createCategoryRequest);
        Task<UpdatedCategoryResponse> Update(UpdateCategoryRequest updateCategoryRequest);
        Task<DeletedCategoryResponse> Delete(DeleteCategoryRequest deleteCategoryRequest);
    }
}
