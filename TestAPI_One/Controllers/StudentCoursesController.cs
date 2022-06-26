using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestAPI_One.DataStore;
using TestAPI_One.Model;

namespace TestAPI_One.Controllers
{
    [Route("Students/{StudentId}/StudentCourses")]
    [ApiController]
    public class StudentCoursesController : ControllerBase
    {

        [HttpGet]
        public ActionResult<CourseDto> Get(int StudentId)
        {
            var student = Student_DataStore.TestData.Students.Where(s => s.Id == StudentId).FirstOrDefault();

            if (student == null)
            { return NotFound("Wrong student id"); }

            return Ok(student.Courses);
        }
    }
}
