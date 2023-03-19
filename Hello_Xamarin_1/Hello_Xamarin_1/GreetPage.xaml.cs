using System;

using Xamarin.Forms;
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
        }

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            label.Text = String.Format(" Value is {0:F2}", e.NewValue);   
        }

        
    }
}