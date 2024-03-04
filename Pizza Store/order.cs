using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Store
{
    internal class order
    {
        private int _orderID;
        // private double _price;  not used
        // private string _notes;  not used
        private static int _orderNumber = 1;
        private menuitems menuitems;
        private customer customer;

       
        public order(customer _customer, menuitems _menuitems)
        {
            _orderID = _orderNumber++;
            customer = _customer;
            menuitems = _menuitems;
            
        }
        public override string ToString()
        {
            return $"Order ID: {_orderID} - {menuitems} - {customer}";
        }
        public double CalculateTotalPrice()
        {
            // Assuming Price includes tax, add delivery cost
            return menuitems.Price + 40;
        }
    }
}
