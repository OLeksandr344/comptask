using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace complextask
{
    public class Book : Product
    {
        int _pages;
        string _author;
        public string Author
        {
            get { return _author; }
            set
            {
                if (_author == "")
                {
                    throw new Exception("Автора не вказано.");
                }
                _author = value;
            }
        }
        public int Pages
        {
            get { return _pages; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Invalid value");
                }
                _pages = value;
            }
        }

        public Book(string n, double p, string author, int pages, int d) : base(n, p)
        {
            Name = n;
            Price = p;
            Author = author;
            Pages = pages;
            Discount = d;
        }

        public override double CountDiscount()
        {
            this.Price = Price * (1 - Discount / 100);
            return this.Price;
        }
    }
}
