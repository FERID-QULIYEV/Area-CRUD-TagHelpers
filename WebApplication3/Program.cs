namespace WebApplication3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            var app = builder.Build();

            app.UseRouting();
            app.UseStaticFiles();

            app.MapControllerRoute("Default", "{Controller=Home}/{Action=Index}/{id?}");
            app.Run();
        }
    }
}