using FrameModuleExam.Basket;
using FrameModuleExam.Pages;
using FrameModuleExam.Service;
using System;
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

namespace FrameModuleExam
{
	/// <summary>
	/// Логика взаимодействия для MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		Basket.Basket basket = new Basket.Basket();

		public MainWindow()
		{
			InitializeComponent();
			DataContext = basket;
			PageLoader.Page = FrameForPages;
			PageLoader.Page.Navigate(new CatalogPage());
		}

		private void GoToBasket_Click(object sender, RoutedEventArgs e)
		{
			PageLoader.Page.Navigate(new BusketPage(basket));
		}
	}
}
