using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loaning_materialsApp
{
    class Material
    {
        private string name;
        public string Name { get; set; }
        private int id;
        public int ID { get; set; }
        private decimal price;
        public decimal Price { get; set; }
        private string renter;
        public string Renter { get; set; }
    }
}
