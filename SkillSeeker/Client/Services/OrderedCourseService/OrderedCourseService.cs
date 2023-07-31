using SkillSeeker.Shared;
using System.Net.Http.Json;

namespace SkillSeeker.Client.Services.OrderedCourseService
{
    public class OrderedCourseService : IOrderedCourseService
    {
        private readonly HttpClient _http;

        public OrderedCourseService(HttpClient http)
        {
            _http = http;
        }

        public List<OrderedCourse> OrderedCourses { get; set; } = new List<OrderedCourse>();

        public async Task GetAllOrderedCourses()
        {
            OrderedCourses = await _http.GetFromJsonAsync<List<OrderedCourse>>("api/OrderedCourses");
        }
    }
}
