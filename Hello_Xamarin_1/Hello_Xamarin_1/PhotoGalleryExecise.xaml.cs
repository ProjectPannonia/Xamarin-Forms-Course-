using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Hello_Xamarin_1
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PhotoGalleryExecise : ContentPage
	{
        string[] imagePath;
        int counter;
		public PhotoGalleryExecise ()
		{
			InitializeComponent ();
            
            counter = 0;
            imagePath = new string[] {
                "https://www.citibank.com/icg/sa/emea/hungary/assets/img/content/home/200-year.jpg",
                "https://www.citibank.com/icg/sa/emea/hungary/assets/img/content/home/csc-budapest.jpg",
                "https://www.fintechfutures.com/files/2018/11/Citi.jpg",
                "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRDXEFLGj0ZasSOHfklOahnyugG4z7WxyZQLQ&usqp=CAU"

            };
		}

        private void left_Clicked(object sender, EventArgs e)
        {
            if (counter == 0)
                counter = imagePath.Length-1;
            else
                counter--;
            var imageSource = new UriImageSource
            {
                
                Uri = new Uri(imagePath[counter])
            };

            imageContainer.Source = imageSource;
            
        }

        private void right_Clicked(object sender, EventArgs e)
        {
            if (counter >= imagePath.Length - 1)
                counter = 0;
            else
                counter++;
            var imageSource = new UriImageSource
            {
                Uri = new Uri(imagePath[counter])
            };

            imageContainer.Source = imageSource;
        }
    }
}