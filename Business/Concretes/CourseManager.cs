using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.CourseRequest;
using Business.Dtos.Responses.CourseResponse;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;
using Microsoft.EntityFrameworkCore;

namespace Business.Concretes
{
    public class CourseManager : ICourseSevice
    {
        ICourseDal _courseDal;
        private readonly IMapper _mapper;

        public CourseManager(ICourseDal courseDal, IMapper mapper)
        {
            _courseDal = courseDal;
            _mapper = mapper;

        }
        public async Task<Paginate<GetListCourseResponse>> GetListAsync()
        {
            var result = await _courseDal.GetListAsync(
                include: p => p.Include(p => p.Category)
                             .Include(p => p.Instructor));
            return _mapper.Map<Paginate<GetListCourseResponse>>(result);
        }



        public async Task<CreatedCourseResponse> Add(CreateCourseRequest createCourseRequest)
        {
            Course course = _mapper.Map<Course>(createCourseRequest);
            var createCourse = await _courseDal.AddAsync(course);
            return _mapper.Map<CreatedCourseResponse>(createCourse);

        }

        public async Task<UpdatedCourseResponse> Update(UpdateCourseRequest updateCourseRequest)
        {
            //Course course = await _courseDal.GetAsync(predicate: c => c.Id == updateCourseRequest.Id,
            //                                          include: p => p.Include(p => p.Category)
            //                                                      .Include(p => p.Instructor));
            Course course = _mapper.Map<Course>(updateCourseRequest);


            Course updateCourse = await _courseDal.UpdateAsync(course);
            return _mapper.Map<UpdatedCourseResponse>(updateCourse);

        }

        public async Task<DeletedCourseResponse> Delete(DeleteCourseRequest deleteCourseRequest)
        {
            Course course = await _courseDal.GetAsync(predicate: c => c.Id == deleteCourseRequest.Id);
            Course deletedCourse = await _courseDal.DeleteAsync(course);
            return _mapper.Map<DeletedCourseResponse>(deletedCourse);
        }
    }
}
