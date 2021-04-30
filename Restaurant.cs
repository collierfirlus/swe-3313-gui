using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace swe_3313_gui
{
    class Restaurant
    {
        List<Table> Tables = new List<Table>();
        Queue<OrderItem> OrderUp = new Queue<OrderItem>();

        public Restaurant() { }

        public void AddTable(string ID, int tableCapacity)
        {
            Tables.Add(new Table(ID, tableCapacity));
        }

        public Table GetTableById(string TargetID)
        {
            Table FoundTable = null;
            foreach(Table table in Tables)
            {
                if(table.TableId == TargetID)
                {
                    FoundTable = table;
                }
            }
            return FoundTable;
        }

        public void SetTables(List<Table> tables)
        {
            this.Tables = tables; 
        }

        public List<Table> GetTables()
        {
            return this.Tables;
        }

        public void AddToQueue(List<OrderItem> orders)
        {
            foreach(OrderItem item in orders)
            {
                OrderUp.Enqueue(item);
                Debug.WriteLine(item.ItemName + "\n");
                Console.WriteLine("test");
            }
        }

    }
}
