using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace complextask
{
    public class Electronics : Product
    {
        double _storage;
        public double Storage { get { return _storage; }  
            set {
                if (value < 0) 
                {
                    throw new Exception("Invalid value");
                }
                _storage = value;
            }
        }
        
        public Electronics(string n, double p, double storage, double d) : base(n, p)
        {
            Storage = storage;
            Price = p;
            Name = n;
            Discount = d;
        }

        public override double CountDiscount()
        {
            if (Discount == 0)
            {
                return Price;
            }
            Price = Price * (1-Discount/100);
            return Price;
        }
    }
}
