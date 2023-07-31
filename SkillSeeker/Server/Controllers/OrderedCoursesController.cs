using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SkillSeeker.Server.Data;
using SkillSeeker.Server.Services.OrderedCourseService;
using SkillSeeker.Shared;

namespace SkillSeeker.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderedCoursesController : ControllerBase
    {
        private readonly IOrderedCourseService _service;

        public OrderedCoursesController(IOrderedCourseService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<List<OrderedCourse>> GetOrderedCourses()
        {
            return await _service.GetAllOrderedCourses();
        }

        [HttpPost]
        public async Task<OrderedCourse> AddCourse(OrderedCourse course)
        {
            return await _service.AddCourse(course);
        }
    }
}
