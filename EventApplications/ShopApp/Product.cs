using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp
{
	class Product
	{
		private string name;

        public double Price { get; set; }

        public int Quantity { get; set; }

		public int Id { get; set; }

		public Product(int id, double price, string name, int q)
		{
			this.Id = id;
			this.Price = price;
			this.name = name;
			this.Quantity = q;
		}

		public string Info()
		{
			return name + ": " + Price + "€ " + "  x" + Quantity;
		}
	}
}
