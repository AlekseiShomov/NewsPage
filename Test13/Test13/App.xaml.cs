using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Test13
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            Page page = new NavigationPage(new MainPage());
            MainPage = page;

            //MainPage = new MainPage();

            //ContentPage Page1 = new ContentPage();
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
