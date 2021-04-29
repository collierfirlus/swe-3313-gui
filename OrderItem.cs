using System;
using System.Collections.Generic;
using System.Text;

namespace swe_3313_gui
{
    class OrderItem
    {
        private string itemName;
        private double cost;
        private List<string> specialRequests;

        public string ItemName
        {
            get
            {
                return itemName;
            }
        }

        public double Cost
        {
            get { return cost; }
            set { cost = value; }
        }
        public OrderItem(string name, double cost)
        {
            itemName = name;
            this.cost = cost;
        }
        public void AddSpecialRequest(string specialRequest)
        {
            specialRequests.Add(specialRequest);
        }

        public List<string> GetSpecialRequests()
        {
            return specialRequests;
        }
    }
}
