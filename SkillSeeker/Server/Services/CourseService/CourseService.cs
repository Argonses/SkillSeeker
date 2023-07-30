using Microsoft.EntityFrameworkCore;
using SkillSeeker.Server.Data;
using SkillSeeker.Shared;

namespace SkillSeeker.Server.Services.CourseService
{
    public class CourseService : ICourseService
    {
        private readonly ApplicationDbContext _context;

        public CourseService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Course>> GetCourses()
        {
            return await _context.Courses.ToListAsync();
        }
    }
}
