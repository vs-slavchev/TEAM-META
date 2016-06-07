using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp
{
	class Products
	{
		private int id;
		private double price;
		private string name;
		
		public double Price
		{
			get { return price; }
			set { value = price; }
		}

		public Products(int id, double price, string name)
		{
			this.id = id;
			this.price = price;
			this.name = name;
			
		}

		public string Info()
		{
			return name + ": " + price + "€";


		}
	}
}
