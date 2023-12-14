using Business.Dtos.Requests.CourseRequest;
using Business.Dtos.Responses.CourseResponse;
using Core.DataAccess.Paging;

namespace Business.Abstracts
{
    public interface ICourseSevice
    {
        Task<Paginate<GetListCourseResponse>> GetListAsync();
        Task<CreatedCourseResponse> Add(CreateCourseRequest createCourseRequest);
        Task<UpdatedCourseResponse> Update(UpdateCourseRequest updateCourseRequest);
        Task<DeletedCourseResponse> Delete(DeleteCourseRequest deleteCourseRequest);

    }
}
