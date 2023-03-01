using CourseExplorerAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CourseExplorerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private CoursesDbContext dbContext = new CoursesDbContext();

        [HttpGet]
        public List<Course> GetAll()
        {
            return dbContext.Courses.ToList();
        }
    }
}
