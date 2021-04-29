using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace swe_3313_gui
{
    public partial class BeverageView : Form
    {
        public BeverageView()
        {
            InitializeComponent();
        }

        private void AppetizerButton_Click(object sender, EventArgs e)
        {
            ProgramControl.GetInstance().menuView.Show();
            ProgramControl.GetInstance().beverageView.Hide();
        }

        private void SoupSaladButton_Click(object sender, EventArgs e)
        {
            ProgramControl.GetInstance().soupsaladView.Show();
            ProgramControl.GetInstance().beverageView.Hide();
        }

        private void EntreeButton_Click(object sender, EventArgs e)
        {
            ProgramControl.GetInstance().entreeView.Show();
            ProgramControl.GetInstance().beverageView.Hide();
        }

        private void DessertButton_Click(object sender, EventArgs e)
        {
            ProgramControl.GetInstance().dessertView.Show();
            ProgramControl.GetInstance().beverageView.Hide();
        }

        private void MenuBackButton_Click(object sender, EventArgs e)
        {
            ProgramControl.GetInstance().OrderView.Show();
            ProgramControl.GetInstance().beverageView.Hide();
        }

        private void AddWaterBtn_Click(object sender, EventArgs e)
        {
            ProgramControl.GetInstance().TableCurrentlySelected.GetTableOrder().AddItem("Water", 0.00);
        }

        private void AddFountainDrinkBtn_Click(object sender, EventArgs e)
        {
            ProgramControl.GetInstance().TableCurrentlySelected.GetTableOrder().AddItem("Fountain Drink", 2.00);
        }
    }
}
