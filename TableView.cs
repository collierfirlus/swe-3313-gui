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

        private void BackButton_Click(object sender, EventArgs e)
        {
            ProgramControl.GetInstance().LoginView.Show();
            ProgramControl.GetInstance().TableView.Hide();
        }
    }
}
