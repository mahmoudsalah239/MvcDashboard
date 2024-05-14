using Microsoft.EntityFrameworkCore;
using TranningCenter.DataAccessLayer;
using TranningCenter.interfaces;
using TranningCenter.Repositeries;

namespace TranningCenter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddDbContext<Context>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("cs"));
            }
            );
            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddScoped<IinstructorRepositery, InstructorRepositery>();
            builder.Services.AddScoped<IcourseRepositery, courseRepositery>();
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
