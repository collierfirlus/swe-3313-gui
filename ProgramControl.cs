using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace swe_3313_gui
{
    class ProgramControl ///singleton data class used to instantiate objects
    {
        public Table TableCurrentlySelected = new Table("_init_table", 0);
        public Restaurant Restaurant = new Restaurant();
        public Employee EmployeeSignedIn;

        ///Screens
        public Login LoginView = new Login();
        public TableView TableView = new TableView();
        public OrderView OrderView = new OrderView();
        public MenuView menuView = new MenuView();
        public SoupsSaladsView soupsaladView = new SoupsSaladsView();
        public EntreeView entreeView = new EntreeView();
        public DessertView dessertView = new DessertView();
        public BeverageView beverageView = new BeverageView();

        private static ProgramControl instance = null;

        public static ProgramControl GetInstance()
        {
                if (instance == null)
                {
                    instance = new ProgramControl();
                }
                return instance;
        }

        private ProgramControl()
        {
            Restaurant.SetTables(GetSeedTables());
        }

        private List<Table> GetSeedTables() 
        {
            List<Table> tables = new List<Table>();

            tables.Add(new Table("1A", 4));
            tables.Add(new Table("2A", 4));
            tables.Add(new Table("3A", 4));
            tables.Add(new Table("4A", 4));
            tables.Add(new Table("5A", 4));
            tables.Add(new Table("6A", 4));
            
            tables.Add(new Table("1B", 4));
            tables.Add(new Table("2B", 4));
            tables.Add(new Table("3B", 4));
            tables.Add(new Table("4B", 4));
            tables.Add(new Table("5B", 4));
            tables.Add(new Table("6B", 4));
            
            tables.Add(new Table("5C", 4));
            tables.Add(new Table("6C", 4));
            
            tables.Add(new Table("5D", 4));
            tables.Add(new Table("6D", 4));
            
            tables.Add(new Table("1E", 4));
            tables.Add(new Table("2E", 4));
            tables.Add(new Table("3E", 4));
            tables.Add(new Table("4E", 4));
            tables.Add(new Table("5E", 4));
            tables.Add(new Table("6E", 4));
            
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
