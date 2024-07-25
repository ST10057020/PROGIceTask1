using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexIce
{
    public class CoffeeOrder
    {
        string orderNumber, coffeeType, size, customerName;
        double price;

        public CoffeeOrder(string orderNumber, string coffeeType, string size, string customerName, double price)
        {
            this.orderNumber = orderNumber;
            this.coffeeType = coffeeType;
            this.size = size;
            this.customerName = customerName;
            this.price = price;
        }

        public object this[int index]
        {
            get
            {
                if (index == 0)
                    return this.orderNumber;
                else if (index == 1)
                    return this.coffeeType;
                else if (index == 2)
                    return this.size;
                else if (index == 3)
                    return this.customerName;
                else if (index == 4)
                    return this.price;
                return null;
            }

            set
            {
                if (index == 0)
                    this.orderNumber = (string)value;
                else if (index == 1)
                    this.coffeeType = (string)value;
                else if (index == 2)
                    this.size = (string)value;
                else if (index == 3)
                    this.customerName = (string)value;
                else if (index == 4)
                    this.price = (double)value;
            }
        }

        public object this[string attrName]
        {
            get
            {
                if (attrName.ToLower().Equals("ordernumber"))
                    return this.orderNumber;
                if (attrName.ToLower().Equals("coffeetype"))
                    return this.coffeeType;
                if (attrName.ToLower().Equals("size"))
                    return this.size;
                if (attrName.ToLower().Equals("customername"))
                    return this.customerName;
                if (attrName.ToLower().Equals("price"))
                    return this.price;
                return null;
            }

            set
            {
                if (attrName.ToLower().Equals("ordernumber"))
                    this.orderNumber = (string)value;
                if (attrName.ToLower().Equals("coffeetype"))
                    this.coffeeType = (string)value;
                if (attrName.ToLower().Equals("size"))
                    this.size = (string)value;
                if (attrName.ToLower().Equals("customername"))
                    this.customerName = (string)value;
                if (attrName.ToLower().Equals("price"))
                    this.price = (double)value;
            }
        }
    }
}
