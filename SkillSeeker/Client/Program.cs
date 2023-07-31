using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using SkillSeeker.Client;
using SkillSeeker.Client.Services.CourseService;
using SkillSeeker.Client.Services.OrderedCourseService;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddHttpClient("SkillSeeker.ServerAPI", client => client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress))
    .AddHttpMessageHandler<BaseAddressAuthorizationMessageHandler>();

// Supply HttpClient instances that include access tokens when making requests to the server project
builder.Services.AddScoped(sp => sp.GetRequiredService<IHttpClientFactory>().CreateClient("SkillSeeker.ServerAPI"));
builder.Services.AddScoped<ICourseService, CourseService>();
builder.Services.AddScoped<IOrderedCourseService, OrderedCourseService>();

builder.Services.AddApiAuthorization();

await builder.Build().RunAsync();
