using SkillSeeker.Shared;

namespace SkillSeeker.Server.Services.CourseService
{
    public interface ICourseService
    {
        Task<List<Course>> GetCourses();
        Task<Course> GetCourseById(int id);
    }
}
