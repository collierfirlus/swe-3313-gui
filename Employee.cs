using System;
using System.Collections.Generic;
using System.Text;

namespace swe_3313_gui
{
    class Employee
    {
        private int employee_id;
        //TODO: Create a boolean for manager class. isManager.
        public int Employee_id
        {
            get { return employee_id; }
            set { employee_id = value; }
        }
        public string firstName, lastName, password, username;

        public EmployeeRole Role = EmployeeRole.Server;
        
        public Employee() ///default constructor
        {
            employee_id = 0;
            Role = EmployeeRole.Server;
            firstName = "default_fname";
            firstName = "default_lname";
            password = null;
            username = null;
        }
        public Employee(EmployeeRole role, string firstName, string lastName)
        {
            this.Role = role;
            this.firstName = firstName;
            this.lastName = lastName;
        }
    }
}
