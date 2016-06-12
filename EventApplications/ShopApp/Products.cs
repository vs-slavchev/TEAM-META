using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp
{
	class Products
	{
		private double price;
		private string name;
		private int q;
		
		public double Price
		{
			get { return price; }
			set { value = price; }
		}

		public int Quantity
		{
			get { return q; }
			set { value = q; }
		}

		public int Id { get; set; }

		public Products(int id, double price, string name, int q)
		{
			this.Id = id;
			this.price = price;
			this.name = name;
			this.q = q;
		}

		public string Info()
		{
			return name + ": " + price + "€ " + "  x" + q;


		}
	}
}
