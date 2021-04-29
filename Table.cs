using System;
using System.Collections.Generic;
using System.Text;

namespace swe_3313_gui
{
    class Table
    {
        private string tableId;
        private int capacity;
        private string status;
        private Order tableOrder;

        public Table() { }

        public Table(string Id, int TableCapacity)
        {
            this.tableId = Id;
            this.capacity = TableCapacity;
            status = null;
            tableOrder = new Order();
        }

        public string Status
        {
            set { status = value; }
            get { return status; }
        }
        public string TableId
        {
            get
            {
                return this.tableId;
            }
        }

        public Order GetTableOrder()
        {
            return tableOrder;
        }
    }
}
