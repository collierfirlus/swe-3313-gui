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
        
        protected override void OnVisibleChanged(EventArgs e)
        {
            ///when the screen becomes visible, then change the text
            base.OnVisibleChanged(e);
            Button1F.BackColor = GetColorFromStatus(ProgramControl.GetInstance().Restaurant.GetTableById("1F").Status);
            Button2F.BackColor = GetColorFromStatus(ProgramControl.GetInstance().Restaurant.GetTableById("2F").Status);
            Button3F.BackColor = GetColorFromStatus(ProgramControl.GetInstance().Restaurant.GetTableById("3F").Status);
            Button4F.BackColor = GetColorFromStatus(ProgramControl.GetInstance().Restaurant.GetTableById("4F").Status);
            Button5F.BackColor = GetColorFromStatus(ProgramControl.GetInstance().Restaurant.GetTableById("5F").Status);
            Button6F.BackColor = GetColorFromStatus(ProgramControl.GetInstance().Restaurant.GetTableById("6F").Status);
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

        
        //TODO: Add GetTableDisabled result to each table.
        
        //Return isDisabled
        private bool GetTableDisabled(string tableId)
        {
            List<string> serverTables = new List<string>();
            serverTables.Add("1F");
            serverTables.Add("2F");
            serverTables.Add("3F");
            serverTables.Add("4F");
            serverTables.Add("5F");
            serverTables.Add("6F");
            
            if (ProgramControl.GetInstance().EmployeeSignedIn.Role == EmployeeRole.Server)
            {
                if (!serverTables.Contains(tableId))
                {
                    return true; // Which disables the table.
                }
            }

            return false; // Which enables the table.
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            ProgramControl.GetInstance().LoginView.Show();
            ProgramControl.GetInstance().TableView.Hide();
        }
    }
}
