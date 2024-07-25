using IndexIce;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace TestCoffeeOrder
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestOrderNumber()
        {
            CoffeeOrder order = new CoffeeOrder("ORD1234", "Latte", "Large", "Alice", 4.50);
            Assert.AreEqual(order[0], "ORD1234");
            Assert.AreEqual(order["orderNumber"], "ORD1234");
        }

        [TestMethod]
        public void TestCoffeeType()
        {
            CoffeeOrder order = new CoffeeOrder("ORD1234", "Latte", "Large", "Alice", 4.50);
            Assert.AreEqual(order[1], "Latte");
            Assert.AreEqual(order["coffeeType"], "Latte");
        }

        [TestMethod]
        public void TestSize()
        {
            CoffeeOrder order = new CoffeeOrder("ORD1234", "Latte", "Large", "Alice", 4.50);
            Assert.AreEqual(order[2], "Large");
            Assert.AreEqual(order["size"], "Large");
        }

        [TestMethod]
        public void TestCustomerName()
        {
            CoffeeOrder order = new CoffeeOrder("ORD1234", "Latte", "Large", "Alice", 4.50);
            Assert.AreEqual(order[3], "Alice");
            Assert.AreEqual(order["customerName"], "Alice");
        }

        [TestMethod]
        public void TestPrice()
        {
            CoffeeOrder order = new CoffeeOrder("ORD1234", "Latte", "Large", "Alice", 4.50);
            Assert.AreEqual(order[4], 4.50);
            Assert.AreEqual(order["price"], 4.50);
        }

        [TestMethod]
        public void TestUpdateOrderNumber()
        {
            CoffeeOrder order = new CoffeeOrder("ORD1234", "Latte", "Large", "Alice", 4.50);
            order[0] = "ORD5678";
            Assert.AreEqual(order[0], "ORD5678");
            Assert.AreEqual(order["orderNumber"], "ORD5678");
        }

        [TestMethod]
        public void TestUpdateCoffeeType()
        {
            CoffeeOrder order = new CoffeeOrder("ORD1234", "Latte", "Large", "Alice", 4.50);
            order[1] = "Cappuccino";
            Assert.AreEqual(order[1], "Cappuccino");
            Assert.AreEqual(order["coffeeType"], "Cappuccino");
        }

        [TestMethod]
        public void TestUpdateSize()
        {
            CoffeeOrder order = new CoffeeOrder("ORD1234", "Latte", "Large", "Alice", 4.50);
            order[2] = "Medium";
            Assert.AreEqual(order[2], "Medium");
            Assert.AreEqual(order["size"], "Medium");
        }

        [TestMethod]
        public void TestUpdateCustomerName()
        {
            CoffeeOrder order = new CoffeeOrder("ORD1234", "Latte", "Large", "Alice", 4.50);
            order[3] = "Courteney";
            Assert.AreEqual(order[3], "Courteney");
            Assert.AreEqual(order["customerName"], "Courteney");
        }

        [TestMethod]
        public void TestUpdatePrice()
        {
            CoffeeOrder order = new CoffeeOrder("ORD1234", "Latte", "Large", "Alice", 4.50);
            order[4] = 5.00;
            Assert.AreEqual(order[4], 5.00);
            Assert.AreEqual(order["price"], 5.00);
        }
    }
}