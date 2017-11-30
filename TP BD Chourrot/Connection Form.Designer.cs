namespace TP_BD_Chourrot
{
    partial class Connection_Form
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
            this.BTN_Connect = new System.Windows.Forms.Button();
            this.BTN_Cancel = new System.Windows.Forms.Button();
            this.LB_Username = new System.Windows.Forms.Label();
            this.LB_Password = new System.Windows.Forms.Label();
            this.TB_Username = new System.Windows.Forms.TextBox();
            this.TB_Password = new System.Windows.Forms.TextBox();
            this.LB_Connect = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTN_Connect
            // 
            this.BTN_Connect.Location = new System.Drawing.Point(67, 72);
            this.BTN_Connect.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTN_Connect.Name = "BTN_Connect";
            this.BTN_Connect.Size = new System.Drawing.Size(71, 27);
            this.BTN_Connect.TabIndex = 0;
            this.BTN_Connect.Text = "Connection";
            this.BTN_Connect.UseVisualStyleBackColor = true;
            this.BTN_Connect.Click += new System.EventHandler(this.BTN_Connect_Click);
            // 
            // BTN_Cancel
            // 
            this.BTN_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTN_Cancel.Location = new System.Drawing.Point(142, 72);
            this.BTN_Cancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTN_Cancel.Name = "BTN_Cancel";
            this.BTN_Cancel.Size = new System.Drawing.Size(68, 27);
            this.BTN_Cancel.TabIndex = 1;
            this.BTN_Cancel.Text = "Annuler";
            this.BTN_Cancel.UseVisualStyleBackColor = true;
            this.BTN_Cancel.Click += new System.EventHandler(this.BTN_Cancel_Click);
            // 
            // LB_Username
            // 
            this.LB_Username.AutoSize = true;
            this.LB_Username.Location = new System.Drawing.Point(14, 7);
            this.LB_Username.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_Username.Name = "LB_Username";
            this.LB_Username.Size = new System.Drawing.Size(66, 13);
            this.LB_Username.TabIndex = 2;
            this.LB_Username.Text = "Nom Usager";
            // 
            // LB_Password
            // 
            this.LB_Password.AutoSize = true;
            this.LB_Password.Location = new System.Drawing.Point(9, 32);
            this.LB_Password.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_Password.Name = "LB_Password";
            this.LB_Password.Size = new System.Drawing.Size(72, 13);
            this.LB_Password.TabIndex = 3;
            this.LB_Password.Text = "Mot de Passe";
            // 
            // TB_Username
            // 
            this.TB_Username.Location = new System.Drawing.Point(84, 5);
            this.TB_Username.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TB_Username.Name = "TB_Username";
            this.TB_Username.Size = new System.Drawing.Size(127, 20);
            this.TB_Username.TabIndex = 4;
            // 
            // TB_Password
            // 
            this.TB_Password.Location = new System.Drawing.Point(84, 30);
            this.TB_Password.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TB_Password.Name = "TB_Password";
            this.TB_Password.PasswordChar = '*';
            this.TB_Password.Size = new System.Drawing.Size(127, 20);
            this.TB_Password.TabIndex = 5;
            // 
            // LB_Connect
            // 
            this.LB_Connect.AutoSize = true;
            this.LB_Connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Connect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LB_Connect.Location = new System.Drawing.Point(88, 53);
            this.LB_Connect.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_Connect.Name = "LB_Connect";
            this.LB_Connect.Size = new System.Drawing.Size(127, 17);
            this.LB_Connect.TabIndex = 10;
            this.LB_Connect.Text = "Connection fermée";
            // 
            // Connection_Form
            // 
            this.AcceptButton = this.BTN_Connect;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BTN_Cancel;
            this.ClientSize = new System.Drawing.Size(342, 212);
            this.Controls.Add(this.LB_Connect);
            this.Controls.Add(this.TB_Password);
            this.Controls.Add(this.TB_Username);
            this.Controls.Add(this.LB_Password);
            this.Controls.Add(this.LB_Username);
            this.Controls.Add(this.BTN_Cancel);
            this.Controls.Add(this.BTN_Connect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Connection_Form";
            this.Text = "Fenêtre de Connexion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_Connect;
        private System.Windows.Forms.Button BTN_Cancel;
        private System.Windows.Forms.Label LB_Username;
        private System.Windows.Forms.Label LB_Password;
        private System.Windows.Forms.TextBox TB_Username;
        private System.Windows.Forms.TextBox TB_Password;
        private System.Windows.Forms.Label LB_Connect;
    }
}