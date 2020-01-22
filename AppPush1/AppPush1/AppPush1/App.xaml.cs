using System;


namespace AppPush1
{
    using Xamarin.Forms;
    using Xamarin.Forms.Xaml;
    using AppPush1.Services;
    using AppPush1.Views;

    //
    using Microsoft.AppCenter;
    using Microsoft.AppCenter.Push;

    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new MainPage();
        }

        protected async  override void OnStart()
        {
            //Ris 5 
            //Byron 6
            AppCenter.Start("423df0fd-8da1-4146-840b-d23c6634f75a", typeof(Push));
            bool datos = await Push.IsEnabledAsync();

        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
