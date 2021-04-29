using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace swe_3313_gui
{
    class ProgramControl ///singleton data class used to instantiate objects
    {
        //TODO make getters & setters, public BAD

        public Table TableCurrentlySelected = new Table("_init_table", 0);
        public Restaurant Restaurant = new Restaurant();
        public Employee Employee;

        //Screens
        public Login LoginView = new Login();
        public TableView TableView = new TableView();
        public OrderView OrderView = new OrderView();

        private static ProgramControl instance = null;
        //private static readonly object padlock = new object();

        public static ProgramControl GetInstance()
        {
            //lock (padlock)
            //{
                if (instance == null)
                {
                    instance = new ProgramControl();
                }
                return instance;
            //}
        }

        private ProgramControl()
        {
            Restaurant.SetTables(GetSeedTables());
        }

        private List<Table> GetSeedTables() //1F-6F for now, add rest later
        {
            List<Table> tables = new List<Table>();
            tables.Add(new Table("1F", 4));
            tables.Add(new Table("2F", 4));
            tables.Add(new Table("3F", 4));
            tables.Add(new Table("4F", 4));
            tables.Add(new Table("5F", 4));
            tables.Add(new Table("6F", 4));
            return tables;
        }

        
    }
}
