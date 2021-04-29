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

        public Table() { }

        public Table(string Id, int TableCapacity)
        {
            this.tableId = Id;
            this.capacity = TableCapacity;
            status = null;
        }

        public string TableId
        {
            get
            {
                return this.tableId;
            }
        }
    }
}
