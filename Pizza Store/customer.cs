using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Store
{
    internal class customer
    {
        // private string _customerID; not used
        private string _customerName;
        private bool _membershipstatus;
        private order _newOrder;

    //    public string CustomerID
    //   {
    //       get { return _customerID; }
    //  }

        public string CustomerName
        {
            get { return _customerName; }
            
        }  
        public bool MembershipStatus
        { 
            get { return _membershipstatus; }
            set { _membershipstatus = value; }
        }

        public customer(string CustomerName)
        {
            _customerName = CustomerName;
            
        }

        public void joinClub()
        {
            if (MembershipStatus ==  false) { MembershipStatus = true; }
        }

        public void placeOrder()
        {
            order _newOrder = new order();
        }
    }
}
