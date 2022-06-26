using Microsoft.AspNetCore.Mvc;
using TestAPI_One.Model;
using TestAPI_One.DataStore;

namespace TestAPI_One.Controllers
{
    [ApiController]
    [Route("Students")]
    
    public class StudentsController : ControllerBase
    {
        private Student_DataStore _testDataStore = Student_DataStore.TestData;

        

        [HttpGet]
        public ActionResult<IEnumerable<StudentDto>> GetStudents()
        {               
            return new JsonResult(_testDataStore.Students);
        }

        [HttpGet]
        [Route("{Id}")]
        public ActionResult<StudentDto> GetStudent(int Id)
        {
            var student = _testDataStore.Students?.FirstOrDefault(s => s.Id == Id);
            if (student == null)
            {
                return NotFound();
            }

            return Ok(student);
        }
        
    }
}
