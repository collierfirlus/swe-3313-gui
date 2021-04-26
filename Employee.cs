using System;
using System.Collections.Generic;
using System.Text;

namespace swe_3313_gui
{
    class Employee
    {
        private int employee_id;
        public int Employee_id
        {
            get { return employee_id; }
            set { employee_id = value; }
        }
        private string role, first_name, last_name, password, username;
        public string Role
        {
            get { return role; }
            set { role = value; }
        }
        public string First_name
        {
            get { return first_name; }
            set { first_name = value; }
        }
        public string Last_name
        {
            get { return last_name; }
            set { last_name = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public Employee() ///default constructor
        {
            employee_id = 0;
            role = "default_role";
            first_name = "default_fname";
            last_name = "default_lname";
            password = null;
            username = null;
        }
        public Employee(string role, string fname, string lname)
        {
            this.role = role;
            first_name = fname;
            last_name = lname;
        }
    }
}
