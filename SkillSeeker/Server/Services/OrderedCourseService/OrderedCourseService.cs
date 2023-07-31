using Microsoft.EntityFrameworkCore;
using SkillSeeker.Server.Data;
using SkillSeeker.Shared;

namespace SkillSeeker.Server.Services.OrderedCourseService
{
    public class OrderedCourseService : IOrderedCourseService
    {
        private readonly ApplicationDbContext _context;

        public OrderedCourseService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<OrderedCourse> AddCourse(OrderedCourse course)
        {
           _context.OrderedCourses.Add(course);
            await _context.SaveChangesAsync();
            return course;
        }

        public async Task<List<OrderedCourse>> GetAllOrderedCourses()
        {
           return await _context.OrderedCourses.ToListAsync();
        }

        public async Task LeaveCourse(int id)
        {
            var course = await _context.OrderedCourses.FindAsync(id);
            if (course == null)
            {
                throw new Exception("Course is null!");
            }

            _context.OrderedCourses.Remove(course);
            await _context.SaveChangesAsync();
        }
    }
}
