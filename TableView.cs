using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

namespace swe_3313_gui
{
    public partial class TableView : Form
    {
        private List<Button> tableButtons = new List<Button>();

        public TableView()
        {
            InitializeComponent();
            PopulateTableButtons();
        }

        protected override void OnVisibleChanged(EventArgs e)
        {
            ///when the screen becomes visible, then change the text
            base.OnVisibleChanged(e);

            foreach (Button tableButton in tableButtons)
            {
                tableButton.BackColor = 
                    GetColorFromStatus(ProgramControl.GetInstance().Restaurant.GetTableById(tableButton.Text).Status);
            }

            if (ProgramControl.GetInstance().EmployeeSignedIn.Role == EmployeeRole.Server)
            {
                foreach (Button tableButton in tableButtons)
                {
                    if (!tableButton.Text.Contains("F"))
                    {
                        tableButton.Enabled = false;
                        Color tableButtonPreviousColor = tableButton.BackColor;
                        tableButton.BackColor = Color.FromArgb(70, tableButtonPreviousColor);
                    }
                }
            }
            else
            {
                foreach (Button tableButton in tableButtons)
                {
                    tableButton.Enabled = true;
                }
            }

            foreach (Button tableButton in tableButtons)
            {
                tableButton.Click += tableButtonClicked;
            }

            BackButton.Click += BackButton_Click;
        }

        private Color GetColorFromStatus(TableStatus tableStatus)
        {
            switch (tableStatus)
            {
                case TableStatus.Dirty:
                    return Color.Salmon;
                case TableStatus.Occupied:
                    return Color.Gold;
                case TableStatus.Open:
                    return Color.Chartreuse;
            }
            return Color.Fuchsia;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            ProgramControl.GetInstance().LoginView.Show();
            ProgramControl.GetInstance().TableView.Hide();
        }
        
        private void tableButtonClicked(object sender, System.EventArgs e)
        {
            string tableId = (sender as Button).Text;
            ///Set the table instance to the ProgramControl.
            ProgramControl.GetInstance().TableCurrentlySelected = 
                ProgramControl.GetInstance().Restaurant.GetTableById(tableId);
            
            if (ProgramControl.GetInstance().TableCurrentlySelected.Status == TableStatus.Dirty)
            {
                ProgramControl.GetInstance().TableCurrentlySelected.Status = TableStatus.Open;
                ProgramControl.GetInstance().TableView.Hide();
                ProgramControl.GetInstance().TableView.Show();
            }
            else
            {
                ProgramControl.GetInstance().TableView.Hide();
                ProgramControl.GetInstance().OrderView.Show();
            }

        }

        private void PopulateTableButtons()
        {
            List<Button> buttons = new List<Button>();
            buttons.Add(Button1A);
            buttons.Add(Button2A);
            buttons.Add(Button3A);
            buttons.Add(Button4A);
            buttons.Add(Button5A);
            buttons.Add(Button6A);
            
            buttons.Add(Button1B);
            buttons.Add(Button2B);
            buttons.Add(Button3B);
            buttons.Add(Button4B);
            buttons.Add(Button5B);
            buttons.Add(Button6B);
            
            buttons.Add(Button5C);
            buttons.Add(Button6C);
            
            buttons.Add(Button5D);
            buttons.Add(Button6D);
            
            buttons.Add(Button1E);
            buttons.Add(Button2E);
            buttons.Add(Button3E);
            buttons.Add(Button4E);
            buttons.Add(Button5E);
            buttons.Add(Button6E);
            
            
            buttons.Add(Button1F);
            buttons.Add(Button2F);
            buttons.Add(Button3F);
            buttons.Add(Button4F);
            buttons.Add(Button5F);
            buttons.Add(Button6F);
            
            
            tableButtons = buttons;
        }
    }
}
