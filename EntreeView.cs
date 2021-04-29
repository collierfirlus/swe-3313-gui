using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace swe_3313_gui
{
    public partial class EntreeView : Form
    {
        public EntreeView()
        {
            InitializeComponent();
        }

        private void AppetizerButton_Click(object sender, EventArgs e)
        {
            ProgramControl.GetInstance().menuView.Show();
            ProgramControl.GetInstance().entreeView.Hide();
        }

        private void SoupSaladButton_Click(object sender, EventArgs e)
        {
            ProgramControl.GetInstance().soupsaladView.Show();
            ProgramControl.GetInstance().entreeView.Hide();
        }

        private void DessertButton_Click(object sender, EventArgs e)
        {
            ProgramControl.GetInstance().dessertView.Show();
            ProgramControl.GetInstance().entreeView.Hide();
        }

        private void BeverageButton_Click(object sender, EventArgs e)
        {
            ProgramControl.GetInstance().beverageView.Show();
            ProgramControl.GetInstance().entreeView.Hide();
        }

        private void MenuBackButton_Click(object sender, EventArgs e)
        {
            ProgramControl.GetInstance().OrderView.Show();
            ProgramControl.GetInstance().entreeView.Hide();
        }

        private void AddSpaghettiBtn_Click(object sender, EventArgs e)
        {
            ProgramControl.GetInstance().TableCurrentlySelected.GetTableOrder().AddItem("Spaghetti and Meatballs", 12.00);
        }

        private void AddBurgerBtn_Click(object sender, EventArgs e)
        {
            ProgramControl.GetInstance().TableCurrentlySelected.GetTableOrder().AddItem("Bacon Cheeseburger", 13.00);
        }
    }
}
