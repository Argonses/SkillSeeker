using SkillSeeker.Shared;

namespace SkillSeeker.Client.Services.CourseService
{
    public interface ICourseService
    {
        List<Course> Courses { get; set; }
        Task GetCourses();
        Task<Course> GetCourseById(int id);
    }
}
