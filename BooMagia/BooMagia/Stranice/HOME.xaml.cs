using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BooMagia.Stranice
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HOME : ContentPage
    {
        public HOME()
        {
            InitializeComponent();
        }

        private async void LOGO_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Core.AppShell());


        }
    }
}