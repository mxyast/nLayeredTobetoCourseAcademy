using Entities.Concretes;

namespace Business.Dtos.Responses.CourseResponse
{
    public class UpdatedCourseResponse
    {
        public Guid Id { get; set; }
        public Guid CategoryId { get; set; }
        public Category Category { get; set; }
        public Guid InstructorId { get; set; }
        public Instructor Instructor { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal UnitPrice { get; set; }
    }
}

