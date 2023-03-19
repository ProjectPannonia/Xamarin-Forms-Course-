using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Hello_Xamarin_1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new StackLayoutExercise();
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
