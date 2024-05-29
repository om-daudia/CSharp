namespace ATM_SOFT
{
    partial class Transaction
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.top_panel = new System.Windows.Forms.Panel();
            this.bal_check_btn = new System.Windows.Forms.Button();
            this.withdraw_btn = new System.Windows.Forms.Button();
            this.deposite_btn = new System.Windows.Forms.Button();
            this.pnl_Main = new System.Windows.Forms.Panel();
            this.top_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // top_panel
            // 
            this.top_panel.Controls.Add(this.bal_check_btn);
            this.top_panel.Controls.Add(this.withdraw_btn);
            this.top_panel.Controls.Add(this.deposite_btn);
            this.top_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.top_panel.Location = new System.Drawing.Point(0, 0);
            this.top_panel.Name = "top_panel";
            this.top_panel.Size = new System.Drawing.Size(1189, 113);
            this.top_panel.TabIndex = 0;
            // 
            // bal_check_btn
            // 
            this.bal_check_btn.BackColor = System.Drawing.Color.White;
            this.bal_check_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bal_check_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bal_check_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bal_check_btn.Location = new System.Drawing.Point(856, 31);
            this.bal_check_btn.Name = "bal_check_btn";
            this.bal_check_btn.Padding = new System.Windows.Forms.Padding(5);
            this.bal_check_btn.Size = new System.Drawing.Size(157, 51);
            this.bal_check_btn.TabIndex = 13;
            this.bal_check_btn.Text = "Check Balance";
            this.bal_check_btn.UseVisualStyleBackColor = false;
            this.bal_check_btn.Click += new System.EventHandler(this.bal_check_btn_Click);
            // 
            // withdraw_btn
            // 
            this.withdraw_btn.BackColor = System.Drawing.Color.White;
            this.withdraw_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.withdraw_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.withdraw_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.withdraw_btn.Location = new System.Drawing.Point(548, 31);
            this.withdraw_btn.Name = "withdraw_btn";
            this.withdraw_btn.Padding = new System.Windows.Forms.Padding(5);
            this.withdraw_btn.Size = new System.Drawing.Size(145, 51);
            this.withdraw_btn.TabIndex = 12;
            this.withdraw_btn.Text = "Withdraw";
            this.withdraw_btn.UseVisualStyleBackColor = false;
            this.withdraw_btn.Click += new System.EventHandler(this.withdraw_btn_Click);
            // 
            // deposite_btn
            // 
            this.deposite_btn.BackColor = System.Drawing.Color.White;
            this.deposite_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.deposite_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.deposite_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deposite_btn.Location = new System.Drawing.Point(239, 31);
            this.deposite_btn.Name = "deposite_btn";
            this.deposite_btn.Padding = new System.Windows.Forms.Padding(5);
            this.deposite_btn.Size = new System.Drawing.Size(146, 51);
            this.deposite_btn.TabIndex = 11;
            this.deposite_btn.Text = "Deposite";
            this.deposite_btn.UseVisualStyleBackColor = false;
            this.deposite_btn.Click += new System.EventHandler(this.deposite_btn_Click);
            // 
            // pnl_Main
            // 
            this.pnl_Main.Location = new System.Drawing.Point(3, 119);
            this.pnl_Main.Name = "pnl_Main";
            this.pnl_Main.Size = new System.Drawing.Size(1183, 376);
            this.pnl_Main.TabIndex = 1;
            // 
            // Transaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(168)))), ((int)(((byte)(201)))));
            this.Controls.Add(this.pnl_Main);
            this.Controls.Add(this.top_panel);
            this.Name = "Transaction";
            this.Size = new System.Drawing.Size(1189, 498);
            this.top_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel top_panel;
        private System.Windows.Forms.Button bal_check_btn;
        private System.Windows.Forms.Button withdraw_btn;
        private System.Windows.Forms.Button deposite_btn;
        private System.Windows.Forms.Panel pnl_Main;

    }
}
