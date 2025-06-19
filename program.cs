using lab04.Data.Contexts;
using lab04.Data.Models;
using lab04.Forms.Admin;
using lab04.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace lab04
{
    internal static class Program
    {
        public static IServiceProvider ServiceProvider { get; private set; } = null!;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var services = new ServiceCollection();
            ConfigureServices(services);

            ServiceProvider = services.BuildServiceProvider();

            try
            {
                InitializeDatabase();

                var loginForm = ServiceProvider.GetRequiredService<LoginForm>();
                Application.Run(loginForm);
            }
            catch (Exception ex)
            {
                ShowErrorAndExit($"Wystąpił błąd uruchamiania aplikacji:\n{ex.Message}");
            }
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<DatabaseContext>(options =>
                options.UseInMemoryDatabase("WydarzeniaDb"));

            // Usługi aplikacji
            services.AddScoped<UserService>();
            services.AddScoped<EventService>();
            services.AddScoped<RegistrationService>();

            // Formularze
            services.AddTransient<LoginForm>();
            services.AddTransient<RegisterForm>();
            services.AddTransient<AdminManageUsersForm>();
        }

        private static void InitializeDatabase()
        {
            var dbContext = ServiceProvider.GetRequiredService<DatabaseContext>();

            if (!dbContext.Database.CanConnect())
            {
                ShowErrorAndExit("Nie można połączyć się z bazą danych.");
            }

            dbContext.Database.EnsureCreated();

            var userService = ServiceProvider.GetRequiredService<UserService>();

            if (!dbContext.Users.Any(u => u.Login == "admin"))
            {
                var admin = new User
                {
                    Login = "admin",
                    Password = "admin",
                    Email = "admin@admin.com",
                    FirstName = "Admin",
                    LastName = "Admin",
                    Permissions = 0
                };

                userService.AddUser(admin, out _);
            }
        }

        private static void ShowErrorAndExit(string message)
        {
            MessageBox.Show(message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Environment.Exit(1);
        }
    }
}
