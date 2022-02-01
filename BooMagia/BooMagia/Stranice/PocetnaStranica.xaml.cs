using BooMagia.Stilovi;
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
    public partial class PocetnaStranica : ContentPage
    {
        int i = 1;

        public PocetnaStranica()
        {
            InitializeComponent();
            //List<LOKACIJE> izvor = new List<LOKACIJE>();
            //izvor.Add(new LOKACIJE
            //{
            //    SOURCE = "img1.jpg"
            //});
            //izvor.Add(new LOKACIJE
            //{
            //    SOURCE = "img2.jpg"
            //});
            //izvor.Add(new LOKACIJE
            //{
            //    SOURCE = "img3.jpg"
            //});
            //izvor.Add(new LOKACIJE
            //{
            //    SOURCE = "img4.jpg"
            //});
            //izvor.Add(new LOKACIJE
            //{
            //    SOURCE = "img5.jpg"
            //});
            //izvor.Add(new LOKACIJE
            //{
            //    SOURCE = "img6.jpg"
            //});
        }

        private void NAPRIJED_Clicked(object sender, EventArgs e)
        {
            i++;
            if (i > 6)
            {
                i = 1;
            }
            SLIKA.Source = string.Format($"img{i}.jpg");
           
            

        }

        private void NAZAD_Clicked(object sender, EventArgs e)
        {
            i--;
            if (i < 1)
            {
                i = 6;
            }
            SLIKA.Source = string.Format($"img{i}.jpg");

        }


        
        

        
        
        

    }
    
}