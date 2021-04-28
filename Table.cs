using System;
using System.Collections.Generic;
using System.Text;

namespace swe_3313_gui
{
    class Table
    {
        private string tableID;
        private int capacity;
        private string status;

        public Table() { }

        public Table(string ID, int TableCapacity)
        {
            this.tableID = ID;
            this.capacity = TableCapacity;
            status = null;
        }

        public string TableID
        {
            get
            {
                return this.tableID;
            }
        }
    }
}
