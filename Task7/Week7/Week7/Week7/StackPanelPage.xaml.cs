﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Week7
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class StackPanelPage : ContentPage
	{
		public StackPanelPage ()
		{
			InitializeComponent ();

            Content = new StackPanel();
        }

	}
}