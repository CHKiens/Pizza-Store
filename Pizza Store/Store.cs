using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Store
{
    internal class Store
    {
        public void Start()
        {
            customer erik = new customer("Erik");
            customer lise = new customer("Lise");
            customer hans = new customer("Hans");


            menuitems pepperoni = new menuitems("1", "Pepperoni", 85);
            menuitems margherita = new menuitems("2", "Margherita", 80);
            menuitems kebab = new menuitems("3", "Kebab", 90);

            order order1 = new order(erik, kebab);
            order order2 = new order(lise, margherita);
            order order3 = new order(hans, pepperoni);

            hans.joinClub();

            Console.WriteLine(order1);
            Console.WriteLine($"Total Price: {order1.CalculateTotalPrice():C}\n");

            Console.WriteLine(order2);
            Console.WriteLine($"Total Price: {order2.CalculateTotalPrice():C}\n");

            Console.WriteLine(order3);
            Console.WriteLine($"Total Price: {order3.CalculateTotalPrice():C}\n");
        }

    }
}
