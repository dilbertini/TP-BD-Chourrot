namespace TP_BD_Chourrot
{
    partial class Form1
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
            this.BTN_Deconnect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTN_Connect
            // 
            this.BTN_Connect.Location = new System.Drawing.Point(116, 24);
            this.BTN_Connect.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTN_Connect.Name = "BTN_Connect";
            this.BTN_Connect.Size = new System.Drawing.Size(69, 19);
            this.BTN_Connect.TabIndex = 0;
            this.BTN_Connect.Text = "Connection";
            this.BTN_Connect.UseVisualStyleBackColor = true;
            this.BTN_Connect.Click += new System.EventHandler(this.BTN_Connect_Click);
            // 
            // BTN_Deconnect
            // 
            this.BTN_Deconnect.Location = new System.Drawing.Point(206, 23);
            this.BTN_Deconnect.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTN_Deconnect.Name = "BTN_Deconnect";
            this.BTN_Deconnect.Size = new System.Drawing.Size(56, 19);
            this.BTN_Deconnect.TabIndex = 1;
            this.BTN_Deconnect.Text = "Quitter";
            this.BTN_Deconnect.UseVisualStyleBackColor = true;
            this.BTN_Deconnect.Click += new System.EventHandler(this.BTN_Deconnect_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 408);
            this.Controls.Add(this.BTN_Deconnect);
            this.Controls.Add(this.BTN_Connect);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTN_Connect;
        private System.Windows.Forms.Button BTN_Deconnect;
    }
}

