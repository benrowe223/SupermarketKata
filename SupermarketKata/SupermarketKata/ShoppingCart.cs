using System;
using System.Collections.Generic;
using System.Text;

namespace SupermarketKata
{
   public class ShoppingCart
    {
        private double _totalPrice;
        public double TotalPrice
        {
            get
            {
                if (totalBookOne >=1 && totalBookTwo >= 1)
                {
                    return _totalPrice * 0.95;
                }
                return _totalPrice;
            }
        }

        public int totalBookOne;
        public int totalBookTwo;

        public void AddBook1()
        {
            totalBookOne++;
            _totalPrice += 8;
        }

        public void AddBook2()
        {
            totalBookTwo++;
            _totalPrice += 8;
        }
    }
}
