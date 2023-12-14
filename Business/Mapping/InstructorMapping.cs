using AutoMapper;
using Business.Dtos.Requests.InstructorRequest;
using Business.Dtos.Responses.InstructorRespons;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Mapping
{
    public class InstructorMapping : Profile
    {
        public InstructorMapping()
        {
            CreateMap<Instructor, CreatedInstructorResponse>().ReverseMap();
            CreateMap<Instructor, DeletedInstructorResponse>().ReverseMap();
            CreateMap<Instructor, UpdatedInstructorResponse>().ReverseMap();
            CreateMap<Instructor, GetListInstructorResponse>().ReverseMap();


            CreateMap<Instructor, CreateInstructorRequest>().ReverseMap();
            CreateMap<Instructor, UpdateInstructorRequest>().ReverseMap();
            CreateMap<Instructor, DeleteInstructorRequest>().ReverseMap();

            CreateMap<Paginate<Instructor>, Paginate<GetListInstructorResponse>>().ReverseMap();

        }

    }
}
