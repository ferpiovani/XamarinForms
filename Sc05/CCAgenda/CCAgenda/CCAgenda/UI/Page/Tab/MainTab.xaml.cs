﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CCAgenda.UI.Page.Tab
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainTab : TabbedPage
	{
		public MainTab ()
		{
			InitializeComponent ();
		}
	}
}