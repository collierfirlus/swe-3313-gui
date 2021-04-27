using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace swe_3313_gui
{
    public partial class TableView : Form
    {
        public TableView()
        {
            InitializeComponent();
        }

        private void Button1A_Click(object sender, EventArgs e)
        {
            ///send to event handler done in TableView.Designer.cs
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }
    }
}
