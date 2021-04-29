using System;
using System.Collections.Generic;
using System.Text;

namespace swe_3313_gui
{
    class OrderItem
    {
        private string itemName;
        private double cost;
        private string itemDescription;
        private List<string> specialRequests;

        public double Cost
        {
            get { return cost; }
            set { cost = value; }
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
