using System;
using System.Collections.Generic;
using System.Text;

namespace swe_3313_gui
{
    class Order
    {
        private int OrderNumber { get; set; }
        private DateTime TimeSubmitted { get; set; }
        private bool Paid { get; set; }
        private string OrderTableId { get; set; }
        private double TotalCost { get; set; }
        private double AmountDue;

        List<OrderItem> SubmittedTableOrder;
        public List<OrderItem> ChangeTableOrder;

        public Order()
        {

            //OrderTableId = ProgramControl.GetInstance().TableCurrentlySelected.TableId;
            TimeSubmitted = DateTime.Now;
            Paid = false;
            TotalCost = 0;
            SubmittedTableOrder = new List<OrderItem>();
            ChangeTableOrder = new List<OrderItem>(); 
        }

        public void AddItem(string name, double cost) //Execute when menu item is selected in MenuView
        {
            ChangeTableOrder.Add(new OrderItem(name, cost));
            this.TotalCost += cost;
            //update screen to show added item
        }

        public void SubmitOrder() //Execute when Submit buttom is pressed in OrderView
        {
            //this would also send order to cooks screen
            foreach(OrderItem item in ChangeTableOrder)
            {
                SubmittedTableOrder.Add(item);
            }
            ChangeTableOrder.Clear();
        }

        public void CheckOut() //execute when Checkout button is pressed in OrderView
        {
            Paid = true;
            AmountDue = 0.00;
            ProgramControl.GetInstance().TableCurrentlySelected.Status = "Dirty";
            SubmittedTableOrder.Clear();
            ChangeTableOrder.Clear();
        }

        public void RemoveItem(OrderItem item)
        {
            //Remove Item from order
        }

        public string PrintChangeOrder()
        {
            string returnThis = "";
            foreach(OrderItem item in ChangeTableOrder)
            {
                returnThis += item.ItemName + "\n";
            }
            return returnThis;
        }

        public string PrintSubmittedOrder()
        {
            string returnThis = "";
            foreach (OrderItem item in SubmittedTableOrder)
            {
                returnThis += item.ItemName + "\n";
            }
            return returnThis;
        }
    }
}
