using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace swe_3313_gui
{
    public partial class MenuView : Form
    {
        public MenuView()
        {
            InitializeComponent();
        }

        private void MenuView_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            ProgramControl.GetInstance().entreeView.Show();
            ProgramControl.GetInstance().menuView.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ProgramControl.GetInstance().OrderView.Show();
            ProgramControl.GetInstance().menuView.Hide();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            ProgramControl.GetInstance().TableCurrentlySelected.GetTableOrder().AddItem("Fried Pickles", 6.00);
        }

        private void SoupSaladButton_Click(object sender, EventArgs e)
        {
            ProgramControl.GetInstance().soupsaladView.Show();
            ProgramControl.GetInstance().menuView.Hide();
        }

        private void DessertButton_Click(object sender, EventArgs e)
        {
            ProgramControl.GetInstance().dessertView.Show();
            ProgramControl.GetInstance().menuView.Hide();
        }

        private void BeverageButton_Click(object sender, EventArgs e)
        {
            ProgramControl.GetInstance().beverageView.Show();
            ProgramControl.GetInstance().menuView.Hide();
        }

        private void AddMozzSticksBtn_Click(object sender, EventArgs e)
        {
            ProgramControl.GetInstance().TableCurrentlySelected.GetTableOrder().AddItem("Mozzeralla Sticks", 6.00);
        }
    }
}
