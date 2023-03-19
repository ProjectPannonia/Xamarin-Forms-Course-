using System;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.Xaml;

namespace Hello_Xamarin_1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GreetPage : ContentPage
    {
        public GreetPage()
        {
            InitializeComponent();
            slider.Value = 0.5;

            // Dealing with platform differencies 1.
            if (Device.OS == TargetPlatform.iOS)
                Padding = new Thickness(0, 20, 0, 0);
            else if (Device.OS == TargetPlatform.Android)
                Padding = new Thickness(10, 20, 0, 0);
            else if (Device.OS == TargetPlatform.WinPhone)
                Padding = new Thickness(30, 20, 0, 0);

            // Dealing with platform differencies 2.
            Padding = Device.OnPlatform(
                        iOS: new Thickness(0, 20, 0, 0),
                        Android: new Thickness(10, 20, 0, 0),
                        WinPhone: new Thickness(30, 20, 0, 0)
                      );

            // Dealing with platform differencies 3.
            Device.OnPlatform(
                iOS: () => {
                    Padding = new Thickness(0, 20, 0, 0);
                },
                Android: () => {
                    // ...
                });
        }

        
    }
}