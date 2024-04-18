using FrameModuleExam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameModuleExam.Basket
{
	public class ProductInBasket
	{
		Product product;
		int count;

		public ProductInBasket(Product product)
		{
			this.product = product;
			count = 1;
		}

		public int Count { get => count; set => count = value; }
		public Product Product { get => product; set => product = value; }
	}
}
