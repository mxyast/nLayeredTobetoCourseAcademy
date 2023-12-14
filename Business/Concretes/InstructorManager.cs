using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.InstructorRequest;
using Business.Dtos.Responses.InstructorRespons;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concretes
{
    public class InstructorManager : IInstructorService
    {
        IInstructorDal _instructorDal;
        private readonly IMapper _mapper;

        public InstructorManager(IInstructorDal instructorDal, IMapper mapper)
        {
            _instructorDal = instructorDal;
            _mapper = mapper;

        }
        public async Task<Paginate<GetListInstructorResponse>> GetListAsync()
        {
            var result = await _instructorDal.GetListAsync();
            return _mapper.Map<Paginate<GetListInstructorResponse>>(result);
        }

        public async Task<CreatedInstructorResponse> Add(CreateInstructorRequest createInstructorRequest)
        {
            Instructor instructor = _mapper.Map<Instructor>(createInstructorRequest);
            var createInstructor = await _instructorDal.AddAsync(instructor);
            return _mapper.Map<CreatedInstructorResponse>(createInstructor);

        }

        public async Task<UpdatedInstructorResponse> Update(UpdateInstructorRequest updateCategoryRequest)
        {
            Instructor instructor = await _instructorDal.GetAsync(predicate: i => i.Id == updateCategoryRequest.Id);
            instructor.Name = updateCategoryRequest.Name;

            Instructor updateInstructor = await _instructorDal.UpdateAsync(instructor);
            return _mapper.Map<UpdatedInstructorResponse>(updateInstructor);
        }

        public async Task<DeletedInstructorResponse> Delete(DeleteInstructorRequest deleteCategoryRequest)
        {
            Instructor instructor = await _instructorDal.GetAsync(predicate: i => i.Id == deleteCategoryRequest.Id);
            Instructor deleteInstructor = await _instructorDal.UpdateAsync(instructor);

            return _mapper.Map<DeletedInstructorResponse>(deleteInstructor);

        }
    }
}
