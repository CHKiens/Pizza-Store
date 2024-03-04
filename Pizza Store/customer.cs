using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Pizza_Store
{
    internal class customer
    {
        private string _customerID; // could be used to identify customers in the customer club, is not used in this code however
        private string _customerName;
        private bool _membershipstatus;
        

        public string CustomerID
        {
            get { return _customerID; }
        }

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

        public override string ToString()
        {
            return $"Customer: {CustomerName} - Membership: {MembershipStatus}";
        }
    }
}
