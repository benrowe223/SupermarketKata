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

        private int _totalPrice;


        public double TotalPrice
        {
            get
            {

                if (_cart.Distinct().Count() == 3)
                {
                    return _totalPrice * 0.9;
                }
                if (_cart.Distinct().Count() == 2)
                {
                    return _totalPrice * 0.95;
                }

                return _totalPrice;
            }
        }


        public void AddBook1()
        {
            _cart.Add('A');
            _totalPrice += 8;
        }

        public void AddBook2()
        {
            _cart.Add('B');
            _totalPrice += 8;
        }

        public void AddBook3()
        {
            _cart.Add('C');
            _totalPrice += 8;
        }

    }
}
