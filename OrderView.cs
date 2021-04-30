﻿using System;
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
            this.CartDisplay.Text = ProgramControl.GetInstance().TableCurrentlySelected.GetTableOrder().PrintChangeOrder();
            this.SubmittedOrderLabel.Text = ProgramControl.GetInstance().TableCurrentlySelected.GetTableOrder().PrintSubmittedOrder();
            this.TotalAmtLabel.Text = "$" + Convert.ToString(ProgramControl.GetInstance().TableCurrentlySelected.GetTableOrder().TotalCost);
            this.AmtDueLabel.Text = "$" + Convert.ToString(ProgramControl.GetInstance().TableCurrentlySelected.GetTableOrder().TotalCost);
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            ProgramControl.GetInstance().TableView.Show();
            ProgramControl.GetInstance().OrderView.Hide();
        }

        private void CheckOutButton_Click(object sender, EventArgs e)
        {
            ProgramControl.GetInstance().TableCurrentlySelected.GetTableOrder().CheckOut();
            this.CartDisplay.Text = ProgramControl.GetInstance().TableCurrentlySelected.GetTableOrder().PrintChangeOrder();
            this.SubmittedOrderLabel.Text = ProgramControl.GetInstance().TableCurrentlySelected.GetTableOrder().PrintSubmittedOrder();
            this.TotalAmtLabel.Text = "$" + Convert.ToString(ProgramControl.GetInstance().TableCurrentlySelected.GetTableOrder().TotalCost);
            this.AmtDueLabel.Text = "$" + Convert.ToString(ProgramControl.GetInstance().TableCurrentlySelected.GetTableOrder().TotalCost);
        }

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            ProgramControl.GetInstance().menuView.Show();
            ProgramControl.GetInstance().OrderView.Hide();
        }

        private void SubmitOrderChangesButton_Click(object sender, EventArgs e)
        {
            ProgramControl.GetInstance().TableCurrentlySelected.GetTableOrder().SubmitOrder();
            this.SubmittedOrderLabel.Text = ProgramControl.GetInstance().TableCurrentlySelected.GetTableOrder().PrintSubmittedOrder();
            this.CartDisplay.Text = ProgramControl.GetInstance().TableCurrentlySelected.GetTableOrder().PrintChangeOrder();
            this.TotalAmtLabel.Text = "$" + Convert.ToString(ProgramControl.GetInstance().TableCurrentlySelected.GetTableOrder().TotalCost);
            this.AmtDueLabel.Text = "$" + Convert.ToString(ProgramControl.GetInstance().TableCurrentlySelected.GetTableOrder().TotalCost);
            ProgramControl.GetInstance().Restaurant.ordersToFulfil.Enqueue(ProgramControl.GetInstance().TableCurrentlySelected.GetTableOrder());
            ProgramControl.GetInstance().Restaurant.PrintOrdersToFulfil();
        }

        private void SubmittedOrderLabel_Click(object sender, EventArgs e)
        {

        }

        private void DeleteItemButton_Click(object sender, EventArgs e)
        {
            ProgramControl.GetInstance().TableCurrentlySelected.GetTableOrder().ChangeTableOrder.RemoveAt(0);
            this.CartDisplay.Text = ProgramControl.GetInstance().TableCurrentlySelected.GetTableOrder().PrintChangeOrder();
        }
    }
}
