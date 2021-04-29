using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace swe_3313_gui
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void login_button_Click(object sender, EventArgs e)
        {
            string username_input = passwordBox.Text;
            string password_input = usernameBox.Text;

            //login to be changed later by using an Employee object in the ProgramControl class

            if (usernameBox.Text == "a")//"a" for ease of testing
            {
                if (passwordBox.Text == "a")
                {
                    ///login and proceed to next page, hide current page
                    ProgramControl.GetInstance().TableView.Show();
                    ProgramControl.GetInstance().LoginView.Hide();
                }
                else
                {
                    InvalidCredentialsText.Text = "Invalid password. Try again.";
                }
            }
            else
            {
                InvalidCredentialsText.Text = "Invalid username. Try again.";
            }
        }

    }
}
