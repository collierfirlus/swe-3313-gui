﻿
namespace swe_3313_gui
{
    partial class OrderView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.AmountDueLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TableNumLabel = new System.Windows.Forms.Label();
            this.CheckOutButton = new System.Windows.Forms.Button();
            this.PrintTicketButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.OrderNumberLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.AddItemButton = new System.Windows.Forms.Button();
            this.SubmitOrderChangesButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightGray;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(-14, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(339, 783);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightGray;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(76, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Table # ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.Maroon;
            this.BackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BackButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackButton.Location = new System.Drawing.Point(12, 693);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(272, 47);
            this.BackButton.TabIndex = 30;
            this.BackButton.Text = "< Back";
            this.BackButton.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightGray;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(39, 359);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 37);
            this.label2.TabIndex = 31;
            this.label2.Text = "Total";
            // 
            // AmountDueLabel
            // 
            this.AmountDueLabel.AutoSize = true;
            this.AmountDueLabel.BackColor = System.Drawing.Color.LightGray;
            this.AmountDueLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AmountDueLabel.Location = new System.Drawing.Point(201, 433);
            this.AmountDueLabel.Name = "AmountDueLabel";
            this.AmountDueLabel.Size = new System.Drawing.Size(83, 37);
            this.AmountDueLabel.TabIndex = 32;
            this.AmountDueLabel.Text = "$0.00\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightGray;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(201, 359);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 37);
            this.label3.TabIndex = 33;
            this.label3.Text = "$0.00\r\n";
            // 
            // TableNumLabel
            // 
            this.TableNumLabel.AutoSize = true;
            this.TableNumLabel.BackColor = System.Drawing.Color.LightGray;
            this.TableNumLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TableNumLabel.Location = new System.Drawing.Point(175, 267);
            this.TableNumLabel.Name = "TableNumLabel";
            this.TableNumLabel.Size = new System.Drawing.Size(49, 37);
            this.TableNumLabel.TabIndex = 34;
            this.TableNumLabel.Text = "0A";
            // 
            // CheckOutButton
            // 
            this.CheckOutButton.BackColor = System.Drawing.Color.Maroon;
            this.CheckOutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CheckOutButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CheckOutButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CheckOutButton.Location = new System.Drawing.Point(12, 599);
            this.CheckOutButton.Name = "CheckOutButton";
            this.CheckOutButton.Size = new System.Drawing.Size(272, 47);
            this.CheckOutButton.TabIndex = 35;
            this.CheckOutButton.Text = "Check Out";
            this.CheckOutButton.UseVisualStyleBackColor = false;
            // 
            // PrintTicketButton
            // 
            this.PrintTicketButton.BackColor = System.Drawing.Color.Maroon;
            this.PrintTicketButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PrintTicketButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.PrintTicketButton.Location = new System.Drawing.Point(12, 534);
            this.PrintTicketButton.Name = "PrintTicketButton";
            this.PrintTicketButton.Size = new System.Drawing.Size(272, 47);
            this.PrintTicketButton.TabIndex = 36;
            this.PrintTicketButton.Text = "Print Ticket";
            this.PrintTicketButton.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightGray;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(39, 433);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 37);
            this.label4.TabIndex = 37;
            this.label4.Text = "Due";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightGray;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(2, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(314, 32);
            this.label5.TabIndex = 38;
            this.label5.Text = "______________________________";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(478, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 37);
            this.label6.TabIndex = 39;
            this.label6.Text = "Order #";
            // 
            // OrderNumberLabel
            // 
            this.OrderNumberLabel.AutoSize = true;
            this.OrderNumberLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OrderNumberLabel.Location = new System.Drawing.Point(581, 18);
            this.OrderNumberLabel.Name = "OrderNumberLabel";
            this.OrderNumberLabel.Size = new System.Drawing.Size(77, 37);
            this.OrderNumberLabel.TabIndex = 40;
            this.OrderNumberLabel.Text = "0000";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(420, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(314, 32);
            this.label8.TabIndex = 43;
            this.label8.Text = "______________________________";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(1005, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(314, 32);
            this.label7.TabIndex = 44;
            this.label7.Text = "______________________________";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(1093, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 37);
            this.label9.TabIndex = 45;
            this.label9.Text = "Edit Order";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox2.Location = new System.Drawing.Point(871, 18);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(10, 751);
            this.pictureBox2.TabIndex = 46;
            this.pictureBox2.TabStop = false;
            // 
            // AddItemButton
            // 
            this.AddItemButton.BackColor = System.Drawing.Color.Maroon;
            this.AddItemButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AddItemButton.Location = new System.Drawing.Point(1029, 599);
            this.AddItemButton.Name = "AddItemButton";
            this.AddItemButton.Size = new System.Drawing.Size(272, 47);
            this.AddItemButton.TabIndex = 47;
            this.AddItemButton.Text = "Add Item";
            this.AddItemButton.UseVisualStyleBackColor = false;
            // 
            // SubmitOrderChangesButton
            // 
            this.SubmitOrderChangesButton.BackColor = System.Drawing.Color.Maroon;
            this.SubmitOrderChangesButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SubmitOrderChangesButton.Location = new System.Drawing.Point(1029, 693);
            this.SubmitOrderChangesButton.Name = "SubmitOrderChangesButton";
            this.SubmitOrderChangesButton.Size = new System.Drawing.Size(272, 47);
            this.SubmitOrderChangesButton.TabIndex = 48;
            this.SubmitOrderChangesButton.Text = "Submit\r\n";
            this.SubmitOrderChangesButton.UseVisualStyleBackColor = false;
            // 
            // OrderView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1420, 805);
            this.Controls.Add(this.SubmitOrderChangesButton);
            this.Controls.Add(this.AddItemButton);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.OrderNumberLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PrintTicketButton);
            this.Controls.Add(this.CheckOutButton);
            this.Controls.Add(this.TableNumLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AmountDueLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "OrderView";
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label AmountDueLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label TableNumLabel;
        private System.Windows.Forms.Button CheckOutButton;
        private System.Windows.Forms.Button PrintTicketButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label OrderNumberLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button AddItemButton;
        private System.Windows.Forms.Button SubmitOrderChangesButton;
    }
}