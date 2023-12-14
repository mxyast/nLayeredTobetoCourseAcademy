using AutoMapper;
using Business.Dtos.Requests.CategoryRequest;
using Business.Dtos.Responses.CategoryResponse;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Mapping
{
    public class CategoryMapping : Profile
    {
        public CategoryMapping()
        {
            CreateMap<Category, CreatedCategoryResponse>().ReverseMap();
            CreateMap<Category, DeletedCategoryResponse>().ReverseMap();
            CreateMap<Category, UpdatedCategoryResponse>().ReverseMap();
            CreateMap<Category, GetListCategoryResponse>().ReverseMap();


            CreateMap<Category, CreateCategoryRequest>().ReverseMap();
            CreateMap<Category, UpdateCategoryRequest>().ReverseMap();
            CreateMap<Category, DeleteCategoryRequest>().ReverseMap();


            CreateMap<Paginate<Category>, Paginate<GetListCategoryResponse>>().ReverseMap();
        }


    }
}
