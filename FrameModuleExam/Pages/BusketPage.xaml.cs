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

namespace FrameModuleExam.Pages
{
	/// <summary>
	/// Логика взаимодействия для BusketPage.xaml
	/// </summary>
	public partial class BusketPage : Page
	{
		public BusketPage(Basket.Basket basket)
		{
			InitializeComponent();
			//Window mainWindow = Window.GetWindow(this.Parent);
			//Basket.Basket basket = (Basket.Basket)mainWindow.DataContext;
			BasketList.ItemsSource = basket.Products;
		}

		///Метод для возвращаения на страницу с каталогом.
		private void Back_Button(object sender, RoutedEventArgs e)
		{
			if(this.NavigationService.CanGoBack)
			{
				this.NavigationService.GoBack();
				this.NavigationService.RemoveBackEntry();
			}
        }

		private void CoToCreateOrder_Click(object sender, RoutedEventArgs e)
		{
			PageLoader.Page.Navigate(new ReceiptPage());
		}
	}
}
