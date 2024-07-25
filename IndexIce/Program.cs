namespace IndexIce
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CoffeeOrder order = new CoffeeOrder("ORD1234", "Latte", "Large", "Alice", 4.50);

            Console.WriteLine(order[0]);
            Console.WriteLine(order[1]);
            Console.WriteLine(order[2]);
            Console.WriteLine(order[3]);
            Console.WriteLine(order[4]);

            Console.WriteLine("Order Number: " + order["orderNumber"]);
            Console.WriteLine("Coffee Type: " + order["coffeeType"]);
            Console.WriteLine("Size: " + order["size"]);
            Console.WriteLine("Customer Name: " + order["customerName"]);
            Console.WriteLine("Price: " + order["price"]);
        }
    }
}

