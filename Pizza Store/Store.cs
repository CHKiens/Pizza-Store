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
            customer customer1 = new customer("Erik");
            customer customer2 = new customer("Lise");
            customer customer3 = new customer("Hans");


            menuitems pizza1 = new menuitems("1", "Pepperoni", 85);
            menuitems pizza2 = new menuitems("2", "Margherita", 80);
            menuitems pizza3 = new menuitems("3", "Kebab", 90);

            Console.WriteLine($"{customer1.CustomerName} is a member? = {customer1.MembershipStatus}");
            Console.WriteLine($"{customer2.CustomerName} is a member? = {customer2.MembershipStatus}");
            

            customer1.joinClub();
            Console.WriteLine($"{customer1.CustomerName} joins the club");
            Console.WriteLine($"{customer1.CustomerName} is a member? = {customer1.MembershipStatus}");
            Console.WriteLine($"{customer2.CustomerName} is a member? = {customer2.MembershipStatus}");
            
        }

    }
}
