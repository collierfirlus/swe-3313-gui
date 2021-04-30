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
        
        protected override void OnVisibleChanged(EventArgs e)
        {
            ///when the screen becomes visible, then change the text
            base.OnVisibleChanged(e);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void login_button_Click(object sender, EventArgs e)
        {
            string usernameInput = usernameBox.Text;
            string passwordInput = passwordBox.Text;


            if (ProgramControl.GetInstance().Restaurant.AuthenticateEmployee(usernameInput, passwordInput))
            {
                ProgramControl.GetInstance().TableView.Show();
                ProgramControl.GetInstance().LoginView.Hide();
            }
            else
            {
                InvalidCredentialsText.Text = "Invalid credentials. Try again.";
            }
            
            
        }

    }
}
