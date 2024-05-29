namespace ATM_SOFT
{
    partial class BalanceCheckAct
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
            this.label4 = new System.Windows.Forms.Label();
            this.check = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.F_actno = new System.Windows.Forms.TextBox();
            this.F_showpass = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.F_pass = new System.Windows.Forms.TextBox();
            this.F_balance = new System.Windows.Forms.Label();
            this.bal_panel = new System.Windows.Forms.Panel();
            this.bal_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 23);
            this.label4.TabIndex = 68;
            this.label4.Text = "Balanace : ";
            // 
            // check
            // 
            this.check.BackColor = System.Drawing.Color.White;
            this.check.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.check.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.check.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.check.Location = new System.Drawing.Point(594, 255);
            this.check.Name = "check";
            this.check.Padding = new System.Windows.Forms.Padding(5);
            this.check.Size = new System.Drawing.Size(123, 51);
            this.check.TabIndex = 6;
            this.check.Text = "Check";
            this.check.UseVisualStyleBackColor = false;
            this.check.Click += new System.EventHandler(this.check_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(177, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 23);
            this.label3.TabIndex = 63;
            this.label3.Text = "Account No.  : ";
            // 
            // F_actno
            // 
            this.F_actno.Location = new System.Drawing.Point(335, 105);
            this.F_actno.MaxLength = 12;
            this.F_actno.Name = "F_actno";
            this.F_actno.Size = new System.Drawing.Size(250, 26);
            this.F_actno.TabIndex = 1;
            this.F_actno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.F_actno_KeyPress);
            // 
            // F_showpass
            // 
            this.F_showpass.AutoSize = true;
            this.F_showpass.Location = new System.Drawing.Point(816, 134);
            this.F_showpass.Name = "F_showpass";
            this.F_showpass.Size = new System.Drawing.Size(75, 24);
            this.F_showpass.TabIndex = 4;
            this.F_showpass.Text = "Show";
            this.F_showpass.UseVisualStyleBackColor = true;
            this.F_showpass.CheckedChanged += new System.EventHandler(this.F_showpass_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(687, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 23);
            this.label1.TabIndex = 91;
            this.label1.Text = "Password : ";
            // 
            // F_pass
            // 
            this.F_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.F_pass.Location = new System.Drawing.Point(816, 102);
            this.F_pass.MaxLength = 8;
            this.F_pass.Name = "F_pass";
            this.F_pass.Size = new System.Drawing.Size(250, 26);
            this.F_pass.TabIndex = 3;
            // 
            // F_balance
            // 
            this.F_balance.BackColor = System.Drawing.Color.White;
            this.F_balance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.F_balance.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.F_balance.Location = new System.Drawing.Point(151, 24);
            this.F_balance.Name = "F_balance";
            this.F_balance.Size = new System.Drawing.Size(250, 29);
            this.F_balance.TabIndex = 92;
            this.F_balance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bal_panel
            // 
            this.bal_panel.Controls.Add(this.F_balance);
            this.bal_panel.Controls.Add(this.label4);
            this.bal_panel.Location = new System.Drawing.Point(181, 158);
            this.bal_panel.Name = "bal_panel";
            this.bal_panel.Size = new System.Drawing.Size(404, 63);
            this.bal_panel.TabIndex = 93;
            this.bal_panel.Visible = false;
            // 
            // BalanceCheckAct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(168)))), ((int)(((byte)(201)))));
            this.Controls.Add(this.bal_panel);
            this.Controls.Add(this.F_showpass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.F_pass);
            this.Controls.Add(this.check);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.F_actno);
            this.Name = "BalanceCheckAct";
            this.Size = new System.Drawing.Size(1183, 376);
            this.bal_panel.ResumeLayout(false);
            this.bal_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button check;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox F_actno;
        private System.Windows.Forms.CheckBox F_showpass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox F_pass;
        private System.Windows.Forms.Label F_balance;
        private System.Windows.Forms.Panel bal_panel;
    }
}
