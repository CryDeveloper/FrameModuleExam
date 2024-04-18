using FrameModuleExam.Basket;
using FrameModuleExam.Models;
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
	/// Логика взаимодействия для CatalogPage.xaml
	/// </summary>
	public partial class CatalogPage : Page
	{
		List<Product> products = new List<Product>();
		public CatalogPage()
		{
			InitializeComponent();
			products = DbConnect.Connection.Product.ToList();
			CatalogList.ItemsSource = products;
		}

		private void AddToBasket_Click(object sender, RoutedEventArgs e)
		{
			Button button = (Button)sender;
			string articleProduct = button.Tag.ToString();
			Window mainWindow = Window.GetWindow(this);
			Basket.Basket basket = (Basket.Basket)mainWindow.DataContext;
			basket.AddProduct(articleProduct);
        }
    }
}
