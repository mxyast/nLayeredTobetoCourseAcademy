namespace Business.Dtos.Requests.CourseRequest
{
    public class CreateCourseRequest
    {
        public Guid CategoryId { get; set; }
        public Guid InstructorId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
