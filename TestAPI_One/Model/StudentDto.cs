namespace TestAPI_One.Model
{
    public class StudentDto : PersonDto
    {
        public string Level { get; set; } = string.Empty;

        public ICollection<CourseDto> Courses { get; set; } = new List<CourseDto>();
    }
}
