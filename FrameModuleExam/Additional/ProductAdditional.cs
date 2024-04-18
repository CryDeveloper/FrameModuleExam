using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace FrameModuleExam.Models
{
	public partial class Product
	{
		public string AboutCount => ProductQuantityInStock > 5 ? "много" : String.Format("{0} шт.", ProductQuantityInStock);
	}
}
