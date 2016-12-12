using Xamarin.Forms;

namespace AK.Xamarin.Plugins.Sample
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			MainPage = new AK.Xamarin.Plugins.SamplePage();
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}
