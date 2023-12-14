using AutoMapper;
using Business.Dtos.Requests.CourseRequest;
using Business.Dtos.Responses.CourseResponse;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Mapping
{
    public class CourseMapping : Profile
    {
        public CourseMapping()
        {


            CreateMap<Course, CreateCourseRequest>().ReverseMap();
            CreateMap<Course, UpdateCourseRequest>().ReverseMap();
            CreateMap<Course, DeleteCourseRequest>().ReverseMap();

            CreateMap<Course, CreatedCourseResponse>().ReverseMap();
            CreateMap<Course, DeletedCourseResponse>().ReverseMap();
            CreateMap<Course, UpdatedCourseResponse>().ReverseMap();

            CreateMap<Course, GetListCourseResponse>()
                .ForMember(destinationMember: c => c.CategoryName,
                           memberOptions: opt => opt.MapFrom(c => c.Category.Name)).ReverseMap();
            CreateMap<Course, GetListCourseResponse>()
                .ForMember(destinationMember: c => c.InstructorName,
                           memberOptions: opt => opt.MapFrom(c => c.Instructor.Name)).ReverseMap();


            CreateMap<Paginate<Course>, Paginate<GetListCourseResponse>>().ReverseMap();
        }
    }
}
