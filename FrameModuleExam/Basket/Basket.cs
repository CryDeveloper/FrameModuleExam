using FrameModuleExam.Models;
using FrameModuleExam.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameModuleExam.Basket
{
	public class Basket : INotifyPropertyChanged
	{
		List<ProductInBasket> products = new List<ProductInBasket>();
		int amountProductInBasket;
		
		public List<ProductInBasket> Products { get => products; set => products = value; }
		public int AmountProductInBasket
		{
			get
			{
				int amount = 0;
				foreach (var product in products)
				{
					amount += product.Count;
				}
				return amount;
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
		/// Добавление продукта в корзину.
		/// </summary>
		/// <param name="idProduct">Id продукта.</param>
		public void AddProduct(string idProduct)
		{
			Product product = DbConnect.Connection.Product.FirstOrDefault(x => x.ProductArticleNumber == idProduct);
			ProductInBasket productInBasket = Products.FirstOrDefault(x => x.Product == product);
			if(productInBasket == null)
			{
				productInBasket = new ProductInBasket(product);
				Products.Add(productInBasket);
			}
			else
			{
				int idInBasket = products.IndexOf(productInBasket);
				Products[idInBasket].Count++;
			}
			PropertyChanged.Invoke(this, new PropertyChangedEventArgs(nameof(AmountProductInBasket)));
		}
	}
}
