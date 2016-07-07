using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonClasses;

namespace ShopApp
{
	class Product
	{
		public string Name { get; set; }

        public double Price { get; set; }

        public int Quantity { get; set; }

		public int Id { get; set; }

		public Product(int id, double price, string name, int q)
		{
			this.Id = id;
			this.Price = price;
			this.Name = name;
			this.Quantity = q;
		}

		public string Info()
		{
			return Name + ": " + String.Format(Queries.MONEY_FORMAT, Price) + "  x" + Quantity;
		}
	}
}
