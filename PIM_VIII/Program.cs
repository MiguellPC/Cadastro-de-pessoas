using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PIM_VIII.Data;

namespace PIM_VIII
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            //builder.Services.AddDbContext<PIM_VIIIContext>(options =>
            //    options.UseSqlServer(builder.Configuration.GetConnectionString("PIM_VIIIContext"), builder => 
            //        builder.MigrationsAssembly("PIM_VIII")));

            builder.Services.AddDbContext<PIM_VIIIContext>(options => 
                options.UseSqlite(builder.Configuration.GetConnectionString("PIM_VIIIDB"), builder => 
                    builder.MigrationsAssembly("PIM_VIII")));

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
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