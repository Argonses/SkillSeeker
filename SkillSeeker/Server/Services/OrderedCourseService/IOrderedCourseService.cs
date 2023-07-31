using SkillSeeker.Shared;

namespace SkillSeeker.Server.Services.OrderedCourseService
{
    public interface IOrderedCourseService
    {
        Task<List<OrderedCourse>> GetAllOrderedCourses();
        Task<OrderedCourse> AddCourse(OrderedCourse course);
        Task LeaveCourse(int id);
    }
}
