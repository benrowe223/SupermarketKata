using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SupermarketKata.Tests
{
    [TestClass]
    public class ShoppingCartTests
    {
        [TestMethod]
        public void PurchaseBook_SingleBook_CorrectTotalPrice()
        {
            ShoppingCart shoppingCart = new ShoppingCart();

            shoppingCart.AddBook1();

            Assert.IsTrue(shoppingCart.TotalPrice == 8);
        }

        [TestMethod]
        public void PurchaseBook_NoBooks_ZeroTotalPrice()
        {
            ShoppingCart shoppingCart = new ShoppingCart();

            Assert.IsTrue(shoppingCart.TotalPrice == 0);
        }

        [TestMethod]
        public void PurchaseBook_ThreeBooks_CorrectTotalPrice()
        {
            ShoppingCart shoppingCart = new ShoppingCart();

            shoppingCart.AddBook1();
            shoppingCart.AddBook1();
            shoppingCart.AddBook1();

            Assert.IsTrue(shoppingCart.TotalPrice == 24);
        }

        [TestMethod]
        public void PurchaseBook_TwoBookTypes_CorrectTotalPriceWithFivePercentDiscount()
        {
            ShoppingCart shoppingCart = new ShoppingCart();

            shoppingCart.AddBook1();
            shoppingCart.AddBook2();

            Assert.IsTrue(shoppingCart.TotalPrice == 15.2);
        }

        [TestMethod]
        public void PurchaseBook_ThreeBookTypes_CorrectTotalPriceWithTenPercentDiscount()
        {
            ShoppingCart shoppingCart = new ShoppingCart();

            shoppingCart.AddBook1();
            shoppingCart.AddBook2();
            shoppingCart.AddBook3();

            Assert.IsTrue(shoppingCart.TotalPrice == 21.6);
        }

        [TestMethod]
        public void PurchaseBook_FourDifferentBooks_CorrectTotalPriceWithTwentyPercentDiscount()
        {
            ShoppingCart shoppingCart = new ShoppingCart();

            shoppingCart.AddBook1();
            shoppingCart.AddBook2();
            shoppingCart.AddBook3();
            shoppingCart.AddBook4();

            Assert.IsTrue(shoppingCart.TotalPrice == 25.6);
        }

        [TestMethod]
        public void PurchaseBook_FiveDifferentBooks_CorrectTotalPriceWithTwentyFivePercentDiscount()
        {
            ShoppingCart shoppingCart = new ShoppingCart();

            shoppingCart.AddBook1();
            shoppingCart.AddBook2();
            shoppingCart.AddBook3();
            shoppingCart.AddBook4();
            shoppingCart.AddBook5();

            Assert.IsTrue(shoppingCart.TotalPrice == 30);
        }


    }
}
