using SkillSeeker.Shared;

namespace SkillSeeker.Client.Services.OrderedCourseService
{
    public interface IOrderedCourseService
    {
        List<OrderedCourse> OrderedCourses { get; set; }
        Task GetAllOrderedCourses();
        Task LeaveCourse(int id);
    }
}
