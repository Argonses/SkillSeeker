using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SkillSeeker.Server.Data;
using SkillSeeker.Server.Services.CourseService;
using SkillSeeker.Shared;

namespace SkillSeeker.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        private readonly ICourseService _service;

        public CoursesController(ICourseService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<List<Course>> GetCourses()
        {
            return await _service.GetCourses();
        }
    }
}
