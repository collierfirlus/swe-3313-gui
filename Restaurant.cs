using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace swe_3313_gui
{
    class Restaurant
    {
        List<Table> tables = new List<Table>();
        public Queue<Order> ordersToFulfil = new Queue<Order>();
        public List<Employee> Employees;
        
        // public void LoadEmployees()
        // {
        //     Employees = GetSeedEmployees();
        // }

        public Restaurant()
        {
            Employees = GetSeedEmployees();
        }

        public Table GetTableById(string TargetID)
        {
            Table FoundTable = null;
            foreach(Table table in tables)
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
            this.tables = tables; 
        }

        public void PrintOrdersToFulfil()
        {
            int i = 1;
            foreach (var order in this.ordersToFulfil)
            {
                Console.WriteLine("Priority: " + i);
                Console.WriteLine("Items: ");
                order.PrintSubmittedOrder();
                i++;
            }
        }

        public bool AuthenticateEmployee(string username, string password)
        {
            foreach (var employee in Employees)
            {
                if (employee.username == username)
                {
                    ProgramControl.GetInstance().LoginView.Hide();
                    if (employee.password == password)
                    {
                        ProgramControl.GetInstance().EmployeeSignedIn = employee;
                        return true;
                    }
                }
            }
            return false;
        }
        
        private static List<Employee> GetSeedEmployees()
        {
            List<Employee> employees = new List<Employee>();
            Employee server = new Employee(EmployeeRole.Server, "Jane", "Tabon");
            server.username = "server";
            server.password = "server";
            employees.Add(server);
            Employee manager = new Employee(EmployeeRole.Server, "Richard", "Gesick");
            manager.username = "manager";
            manager.password = "manager";
            employees.Add(manager);
            return employees;
        }
    }
}
