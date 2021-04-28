using System;
using System.Collections.Generic;
using System.Text;

namespace swe_3313_gui
{
    class Restaurant 
    {
        List<Table> Tables = new List<Table>();

        public Restaurant() { }

        public void AddTable(string ID, int tableCapacity)
        {
            Tables.Add(new Table(ID, tableCapacity));
        }

        public Table GetTableByID(string TargetID)
        {
            Table FoundTable = null;
            foreach(Table table in Tables)
            {
                if(table.TableID == TargetID)
                {
                    FoundTable = table;
                }
            }
            return FoundTable;
        }
    }
}
