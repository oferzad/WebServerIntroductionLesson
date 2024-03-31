
namespace WebServerIntroductionLesson
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            
            var app = builder.Build();

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.Map("/testmap", () => "Wow! It is working");

            app.MapGet("/users/{userId}/books/{bookId}",
                             (int userId, int bookId) => $"The user id is {userId} and book id is {bookId}");

            app.Run();
        }
    }
}