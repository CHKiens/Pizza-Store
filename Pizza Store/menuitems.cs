using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Store
{
    internal class menuitems
    {
        private string _itemID;
        private string _itemName;
        private string _itemDescription;
        private double _price;

        public string ItemID
        {
            get { return _itemID; }
            
        }
        public string ItemName
        { 
            get { return _itemName; }
            
        }
        public string ItemDescription
        { 
            get { return _itemDescription; } 
        }

        public double Price
        { 
            get { return _price; }
        }

        public menuitems(string ItemID, string ItemName, double Price)
        {
            _itemDescription = ItemID;
            _itemName = ItemName;
            _price = Price;
        }

        public void AddItem()
        {
            
        }
    }
}
