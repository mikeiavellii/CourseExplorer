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

        //[HttpGet("GetAlCategories")]
        //public List<Course> SerarchByCGetAlCategoriesategories()
        //{
        //    return dbContext.Courses.
        //}

        [HttpGet("SerarchByCategories")]
        public List<Course> SerarchByCategories(string cat)
        {
            return dbContext.Courses.Where(c => c.CatDes == cat || c.Cat == cat).ToList();
        }

    }
}
