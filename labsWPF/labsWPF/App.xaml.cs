using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace labsWPF
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage =new Results();
        }

        protected override void OnStart()
        {
        } 
        protected override void OnSleep()
        {
        }
        protected override void OnResume()
        {
        }
    }
}
