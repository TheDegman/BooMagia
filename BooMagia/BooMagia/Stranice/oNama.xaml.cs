using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BooMagia.Stranice
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class oNama : ContentPage
    {
        public oNama()
        {
            InitializeComponent();
        }
		private async void OnImage_Tapped(object sender, EventArgs e)
		{
			
			
				if (Device.RuntimePlatform == Device.Android)
				{
					await Launcher.OpenAsync("geo:0,0?q=eugena+kumičića+55+slavonski+brod");
				}
				if (Device.RuntimePlatform == Device.iOS)
				{
					await Launcher.OpenAsync("http://maps.apple.com/?q=eugena+kumičića+55+slavonski+brod");
				}
			
			
		}
	}
}