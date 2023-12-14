using Business.Dtos.Requests.InstructorRequest;
using Business.Dtos.Responses.InstructorRespons;
using Core.DataAccess.Paging;

namespace Business.Abstracts
{
    public interface IInstructorService
    {
        Task<Paginate<GetListInstructorResponse>> GetListAsync();
        Task<CreatedInstructorResponse> Add(CreateInstructorRequest createInstructorRequest);
        Task<UpdatedInstructorResponse> Update(UpdateInstructorRequest updateCategoryRequest);
        Task<DeletedInstructorResponse> Delete(DeleteInstructorRequest deleteCategoryRequest);
    }
}
