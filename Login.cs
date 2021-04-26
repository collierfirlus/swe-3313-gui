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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;

            Brush brush = new SolidBrush(Color.Maroon);
            graphics.FillRectangle(brush, new Rectangle(10, 10, pictureBox1.Width, pictureBox1.Height));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void login_button_Click(object sender, EventArgs e)
        {
            string username_input = passwordBox.Text;
            string password_input = usernameBox.Text;

            if (usernameBox.Text == "BobBilly123")
            {
                if (passwordBox.Text == "BobBilly321")
                {
                    ///login and proceed to next page
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void InvalidCredentialsText_Click(object sender, EventArgs e)
        {

        }
    }
}
