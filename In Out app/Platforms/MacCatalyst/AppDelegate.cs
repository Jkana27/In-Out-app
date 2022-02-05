using Foundation;
using Microsoft.Maui;
using Microsoft.Maui.Hosting;

namespace In_Out_app
{
	[Register("AppDelegate")]
	public class AppDelegate : MauiUIApplicationDelegate
	{
		protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
	}
}