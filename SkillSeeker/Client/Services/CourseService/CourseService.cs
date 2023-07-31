using SkillSeeker.Shared;
using System.Net.Http.Json;

namespace SkillSeeker.Client.Services.CourseService
{
    public class CourseService : ICourseService
    {
        private readonly HttpClient _http;

        public CourseService(HttpClient http)
        {
            _http = http;
        }

        public List<Course> Courses { get; set; } = new List<Course>();

        public async Task<Course> GetCourseById(int id)
        {
            var result = await _http.GetFromJsonAsync<Course>($"api/Courses/{id}");
            return result;
        }

        public async Task GetCourses()
        {
            Courses = await _http.GetFromJsonAsync<List<Course>>("api/Courses");
        }
    }
}
