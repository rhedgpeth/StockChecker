using Xamarin.Forms;

using Microsoft.Azure.Mobile;
using Microsoft.Azure.Mobile.Analytics;
using Microsoft.Azure.Mobile.Crashes;

namespace StockChecker
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new StockCheckerPage();
        }

        protected override void OnStart()
        {
			MobileCenter.Start("ios=31834509-ddc5-4030-ac13-7049a57a57b8;" +
				   //"uwp={Your UWP App secret here};",
				   typeof(Analytics), typeof(Crashes));
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
