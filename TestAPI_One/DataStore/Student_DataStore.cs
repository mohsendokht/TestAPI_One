using TestAPI_One.Model;

namespace TestAPI_One.DataStore
{
    public class Student_DataStore
    {
        private string[] TestLevels = new string[] { "L1", "L2", "L3" };
        private string[] TestCourses = new string[] {"Course 1", "Course 2", "Course 3" };
        public IEnumerable<StudentDto> Students { get; set; } = new List<StudentDto>();

        public static Student_DataStore TestData = new Student_DataStore();
        public Student_DataStore()
        {
            Students = new List<StudentDto>();
            Students = GetTestData();

        }

        private IEnumerable<StudentDto> GetTestData()
        {
            return Enumerable.Range(1, 10).Select(Index => new StudentDto
            {
                Id = Index,
                Name = $"Student {Random.Shared.Next()}",
                Level = TestLevels[Random.Shared.Next(TestLevels.Length)],
                Courses = Enumerable.Range(0,Random.Shared.Next(TestCourses.Length)).Select(Indesx => new CourseDto
                {
                    Id = Indesx,
                    Name = TestCourses[Indesx],
                    Point = Indesx
                }).ToList()
            });
        }
    }
}
