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

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var services = new ServiceCollection();
            ConfigureServices(services);
            ServiceProvider = services.BuildServiceProvider();
            
            // Aplikacja kliencka nie powinna tworzyć bazy danych ani migracji.
            // Migracje powinny być stosowane przed uruchomieniem aplikacji klienckiej.
            try
            {
                // Sprawdź połączenie z bazą danych
                var dbContext = ServiceProvider.GetRequiredService<DatabaseContext>();
                if (!dbContext.Database.CanConnect())
                {
                    Console.WriteLine("Database connection failed. Please check your connection string.");
                    MessageBox.Show($"Błąd połączenia z bazą danych", "Błąd",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Environment.Exit(1);
                }
                dbContext.Database.EnsureCreated();
                var userService = ServiceProvider.GetRequiredService<UserService>();
                if (!dbContext.Users.Any(u => u.Login == "admin"))
                {
                    var admin = new Data.Models.User
                    {
                        Password = "admin",
                        Email = "admin@admin.com",
                        FirstName = "Admin",
                        LastName = "Admin",
                        Login = "admin",
                        Permissions = 0,
                    };
                    userService.AddUser(admin, out _);
                }

                var loginForm = ServiceProvider.GetRequiredService<LoginForm>();
                Application.Run(loginForm);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd: {ex.Message}", "Błąd",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Metoda konfigurująca usługi aplikacji, wykorzystując dependency injection. Dodając singletony usług.
        /// </summary>
        /// <param name="services"></param>
        private static void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<DatabaseContext>(options => options.UseInMemoryDatabase("WydarzeniaDb"));

            // Rejestracja usług
            services.AddScoped<UserService>();
            services.AddScoped<EventService>();
            services.AddScoped<RegistrationService>();

            // Rejestracja formularzy
            services.AddTransient<LoginForm>();
            services.AddTransient<RegisterForm>();
            services.AddTransient<AdminManageUsersForm>();
        }
    }
}
