using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace swe_3313_gui
{
    public partial class SoupsSaladsView : Form
    {
        public SoupsSaladsView()
        {
            InitializeComponent();
        }

        private void SoupsSaladsView_Load(object sender, EventArgs e)
        {
            
        }

        private void AppetizerButton_Click(object sender, EventArgs e)
        {
            ProgramControl.GetInstance().menuView.Show();
            ProgramControl.GetInstance().soupsaladView.Hide();
        }

        private void EntreeButton_Click(object sender, EventArgs e)
        {
            ProgramControl.GetInstance().entreeView.Show();
            ProgramControl.GetInstance().soupsaladView.Hide();
        }

        private void DessertButton_Click(object sender, EventArgs e)
        {
            ProgramControl.GetInstance().dessertView.Show();
            ProgramControl.GetInstance().soupsaladView.Hide();
        }

        private void BeverageButton_Click(object sender, EventArgs e)
        {
            ProgramControl.GetInstance().beverageView.Show();
            ProgramControl.GetInstance().soupsaladView.Hide();
        }

        private void MenuBackButton_Click(object sender, EventArgs e)
        {
            ProgramControl.GetInstance().OrderView.Show();
            ProgramControl.GetInstance().soupsaladView.Hide();
        }

        private void AddSoupBtn_Click(object sender, EventArgs e)
        {
            ProgramControl.GetInstance().TableCurrentlySelected.GetTableOrder().AddItem("French Onion Soup", 8.00);
        }

        private void AddSaladBtn_Click(object sender, EventArgs e)
        {
            ProgramControl.GetInstance().TableCurrentlySelected.GetTableOrder().AddItem("Caesar Salad", 6.00);
        }
    }
}
