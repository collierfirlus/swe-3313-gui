using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace swe_3313_gui
{
    public partial class DessertView : Form
    {
        public DessertView()
        {
            InitializeComponent();
        }

        private void AppetizerButton_Click(object sender, EventArgs e)
        {
            ProgramControl.GetInstance().menuView.Show();
            ProgramControl.GetInstance().dessertView.Hide();
        }

        private void SoupSaladButton_Click(object sender, EventArgs e)
        {
            ProgramControl.GetInstance().soupsaladView.Show();
            ProgramControl.GetInstance().dessertView.Hide();
        }

        private void EntreeButton_Click(object sender, EventArgs e)
        {
            ProgramControl.GetInstance().entreeView.Show();
            ProgramControl.GetInstance().dessertView.Hide();
        }

        private void BeverageButton_Click(object sender, EventArgs e)
        {
            ProgramControl.GetInstance().beverageView.Show();
            ProgramControl.GetInstance().dessertView.Hide();
        }

        private void MenuBackButton_Click(object sender, EventArgs e)
        {
            ProgramControl.GetInstance().OrderView.Show();
            ProgramControl.GetInstance().dessertView.Hide();
        }

        private void AddCheesecakeBtn_Click(object sender, EventArgs e)
        {
            ProgramControl.GetInstance().TableCurrentlySelected.GetTableOrder().AddItem("Cheesecake", 7.00);
        }

        private void AddChocCakeBtn_Click(object sender, EventArgs e)
        {
            ProgramControl.GetInstance().TableCurrentlySelected.GetTableOrder().AddItem("Chocolate Cake", 6.00);
        }
    }
}
