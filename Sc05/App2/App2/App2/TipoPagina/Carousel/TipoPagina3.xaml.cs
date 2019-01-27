using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.IO;

namespace App2.TipoPagina.Carousel
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TipoPagina3 : ContentPage
	{
		public TipoPagina3 ()
		{
			InitializeComponent ();
          
            
        
        }

        private void LoadImage(string img)
        {

        }

        private void MudarPagina (object sender, EventArgs args)
        {
            LoadImage("play.png");
            //App.Current.MainPage = new NavigationPage(new Navigation.Pagina1());
            
        }
    }
}