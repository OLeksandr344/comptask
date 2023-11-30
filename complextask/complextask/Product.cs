using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace complextask
{
    public abstract class Product : IProduct
    {
        private double _price;
        private string _name;
        private double _discount;
        public string Name { get { return _name; }
            set
            {
                if (_name == "")
                {
                    throw new Exception("Ім'я не вказано.");
                }
                _name = value;
            }
        }
        public double Price
        {
            get { return _price; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Ціна не може бути від'ємною.");
                }
                _price = value;
            }
        }

        public double Discount { get { return _discount; } 
            set
            {
                if(value < 0 && value > 100)
                {
                    throw new Exception("не можливе значення знижки.");
                }
                _discount = value;
            } 
        }
        public abstract double CountDiscount();
        
        public Product(string n, double p) 
        {
            Name = n;
            Price = p;
        }
    }
}
