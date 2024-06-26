﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FrameModuleExam.Pages
{
	/// <summary>
	/// Логика взаимодействия для ReceiptPage.xaml
	/// </summary>
	public partial class ReceiptPage : Page
	{
		public ReceiptPage()
		{
			InitializeComponent();
		}

		private void Back_Button(object sender, RoutedEventArgs e)
		{
			if(this.NavigationService.CanGoBack)
			{
				this.NavigationService.GoBack();
				this.NavigationService.RemoveBackEntry();
			}
        }
    }
}
