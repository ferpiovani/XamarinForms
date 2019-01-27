﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2.TipoPagina.Navigation
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Pagina1 : ContentPage
	{
		public Pagina1 ()
		{
			InitializeComponent ();
		}

        private void MudarPagina2(object sender, EventArgs args)
        {
            Navigation.PushAsync(new Pagina2());
        }

        private void ChamarModal(object sender, EventArgs arg)
        {
            Navigation.PushModalAsync(new Modal());
        }

        private void ChamarMaster(object sender, EventArgs arg)
        {
            App.Current.MainPage = new Master.Master();
        }

    }
}