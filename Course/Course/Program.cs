using Course.View;
using Microsoft.Extensions.DependencyInjection;
using static Course.ViewModel.CourseViewModel;

namespace Course.ViewModel
{
	public static class Program
	{
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			var services = new ServiceCollection();
			ConfigureServices(services);

			var serviceProvider = services.BuildServiceProvider();
			Application.Run(serviceProvider.GetRequiredService<MainForm>()); }
		private static void ConfigureServices (IServiceCollection services)
		{
			services.AddSingleton<ICourseViewModel, CourseViewModel>();
			
			services.AddTransient<MainForm>();
		}
			// To customize application configuration such as set high DPI settings or default font,
			// see https://aka.ms/applicationconfiguration.
			
		}
	}
