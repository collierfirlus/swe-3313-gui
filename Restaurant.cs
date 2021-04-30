using System;
using System.Collections.Generic;
using System.Text;

namespace swe_3313_gui
{
    class Restaurant
    {
        List<Table> Tables = new List<Table>();
        private int orderNumber = 1;

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

        public int IncrementOrderNumber()
        {
            orderNumber++;
            return orderNumber - 1;
        }

    }
}
