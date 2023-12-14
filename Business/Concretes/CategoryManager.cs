using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.CategoryRequest;
using Business.Dtos.Responses.CategoryResponse;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concretes
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;
        private readonly IMapper _mapper;


        public CategoryManager(ICategoryDal categoryDal, IMapper mapper)
        {
            _categoryDal = categoryDal;
            _mapper = mapper;

        }
        public async Task<Paginate<GetListCategoryResponse>> GetListAsync()
        {
            var result = await _categoryDal.GetListAsync();
            return _mapper.Map<Paginate<GetListCategoryResponse>>(result);
        }

        public async Task<CreatedCategoryResponse> Add(CreateCategoryRequest createCategoryRequest)
        {
            Category category = _mapper.Map<Category>(createCategoryRequest);
            Category createCategory = await _categoryDal.AddAsync(category);
            return _mapper.Map<CreatedCategoryResponse>(createCategory);

        }

        public async Task<UpdatedCategoryResponse> Update(UpdateCategoryRequest updateCategoryRequest)
        {

            Category category = await _categoryDal.GetAsync(predicate: c => c.Id == updateCategoryRequest.Id);
            category.Name = updateCategoryRequest.Name;
            Category updateCategory = await _categoryDal.UpdateAsync(category);

            return _mapper.Map<UpdatedCategoryResponse>(updateCategory);
        }

        public async Task<DeletedCategoryResponse> Delete(DeleteCategoryRequest deleteCategoryRequest)
        {
            Category category = await _categoryDal.GetAsync(predicate: c => c.Id == deleteCategoryRequest.Id);
            Category deleteCategory = await _categoryDal.DeleteAsync(category);
            return _mapper.Map<DeletedCategoryResponse>(deleteCategory);
        }
    }
}
