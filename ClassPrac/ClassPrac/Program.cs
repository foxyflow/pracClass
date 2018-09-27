using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPrac
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
    class Pizza
    {
        public bool Cheese { get; set; }
        public  string Crust { get; set; }
        public string Sause { get; set; }
        public decimal Price { get; set; }
        public decimal Discount { get; set; }

        public Pizza(bool _cheese, string _crust, string _sause, decimal _price, decimal _discount)
        {
            Cheese = _cheese;
            Crust = _crust;
            Sause = _sause;
            Price = _price;
            Discount = _discount;
        }
        public bool 
      
    }

}  
