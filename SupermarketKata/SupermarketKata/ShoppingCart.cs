using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SupermarketKata
{
    public class ShoppingCart
    {
        private int[] _bookTypeCount = new int[4];

        List<char> _cart = new List<char>();


        public double TotalPrice
        {
            get
            {
               var _totalPrice = _cart.Count() * 8;

                if (_cart.Distinct().Count() == 2)
                {
                    return _totalPrice * 0.95;
                }
                if (_cart.Distinct().Count() == 3)
                {
                    return _totalPrice * 0.9;
                }
                if (_cart.Distinct().Count() == 4)
                {
                    return _totalPrice * 0.8;
                }
                if (_cart.Distinct().Count() == 5)
                {
                    return _totalPrice * 0.75;
                }



                return _totalPrice;
            }
        }

        public void AddBook1()
        {
            _cart.Add('A');
        }

        public void AddBook2()
        {
            _cart.Add('B');
        }

        public void AddBook3()
        {
            _cart.Add('C');
        }

        public void AddBook4()
        {
            _cart.Add('D');
        }

        public void AddBook5()
        {
            _cart.Add('E');
        }
    }
}
