﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CCAgenda.UI.Content
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Recent : ContentPage
	{
		public Recent ()
		{
            InitializeComponent ();
            TesteBanco();

        }

        public void TesteBanco()
        {
            Nome.Text = new DAL.DBConn().getName;
        }
	}
}