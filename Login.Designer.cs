
namespace swe_3313_gui
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.BottomPanel = new System.Windows.Forms.PictureBox();
            this.EnterUsrPassText = new System.Windows.Forms.Label();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.JsCornerImgBox = new System.Windows.Forms.PictureBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.InvalidCredentialsText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BottomPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.JsCornerImgBox)).BeginInit();
            this.SuspendLayout();
            // 
            // BottomPanel
            // 
            this.BottomPanel.BackColor = System.Drawing.Color.Maroon;
            this.BottomPanel.Location = new System.Drawing.Point(-11, 471);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(1282, 333);
            this.BottomPanel.TabIndex = 0;
            this.BottomPanel.TabStop = false;
            // 
            // EnterUsrPassText
            // 
            this.EnterUsrPassText.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EnterUsrPassText.ForeColor = System.Drawing.Color.Maroon;
            this.EnterUsrPassText.Location = new System.Drawing.Point(368, 98);
            this.EnterUsrPassText.Name = "EnterUsrPassText";
            this.EnterUsrPassText.Size = new System.Drawing.Size(546, 54);
            this.EnterUsrPassText.TabIndex = 1;
            this.EnterUsrPassText.Text = "Enter User and Pass";
            this.EnterUsrPassText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // usernameBox
            // 
            this.usernameBox.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.usernameBox.Location = new System.Drawing.Point(509, 241);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(261, 34);
            this.usernameBox.TabIndex = 2;
            this.usernameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // JsCornerImgBox
            // 
            this.JsCornerImgBox.Image = ((System.Drawing.Image)(resources.GetObject("JsCornerImgBox.Image")));
            this.JsCornerImgBox.Location = new System.Drawing.Point(12, 12);
            this.JsCornerImgBox.Name = "JsCornerImgBox";
            this.JsCornerImgBox.Size = new System.Drawing.Size(406, 289);
            this.JsCornerImgBox.TabIndex = 3;
            this.JsCornerImgBox.TabStop = false;
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.Maroon;
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LoginButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LoginButton.Location = new System.Drawing.Point(585, 372);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(111, 43);
            this.LoginButton.TabIndex = 4;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.login_button_Click);
            // 
            // passwordBox
            // 
            this.passwordBox.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordBox.Location = new System.Drawing.Point(509, 307);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.Size = new System.Drawing.Size(261, 34);
            this.passwordBox.TabIndex = 5;
            this.passwordBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // InvalidCredentialsText
            // 
            this.InvalidCredentialsText.AutoSize = true;
            this.InvalidCredentialsText.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InvalidCredentialsText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.InvalidCredentialsText.Location = new System.Drawing.Point(495, 441);
            this.InvalidCredentialsText.Name = "InvalidCredentialsText";
            this.InvalidCredentialsText.Size = new System.Drawing.Size(0, 25);
            this.InvalidCredentialsText.TabIndex = 6;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1264, 772);
            this.Controls.Add(this.InvalidCredentialsText);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.JsCornerImgBox);
            this.Controls.Add(this.usernameBox);
            this.Controls.Add(this.EnterUsrPassText);
            this.Controls.Add(this.BottomPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BottomPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.JsCornerImgBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox BottomPanel;
        private System.Windows.Forms.Label EnterUsrPassText;
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.PictureBox JsCornerImgBox;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Label InvalidCredentialsText;
    }
}

