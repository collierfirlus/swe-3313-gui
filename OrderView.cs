using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace swe_3313_gui
{
    public partial class OrderView : Form
    {
        public OrderView()
        {
            InitializeComponent();
        }

        protected override void OnVisibleChanged(EventArgs e)
        {
            ///when the screen becomes visible, then change the text
            base.OnVisibleChanged(e);
            this.TableNumLabel.Text = ProgramControl.GetInstance().TableCurrentlySelected.TableId;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            ProgramControl.GetInstance().TableView.Show();
            ProgramControl.GetInstance().OrderView.Hide();
        }

        private void CheckOutButton_Click(object sender, EventArgs e)
        {
            ProgramControl.GetInstance().TableCurrentlySelected.GetTableOrder().CheckOut();
        }

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            ProgramControl.GetInstance().menuView.Show();
            ProgramControl.GetInstance().OrderView.Hide();
        }

    }
}
