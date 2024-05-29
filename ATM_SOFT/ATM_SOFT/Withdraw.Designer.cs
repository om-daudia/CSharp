namespace ATM_SOFT
{
    partial class withdraw_btn
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
            this.F_showpass = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.F_pass = new System.Windows.Forms.TextBox();
            this.lable3 = new System.Windows.Forms.Label();
            this.F_rs = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.F_actno = new System.Windows.Forms.TextBox();
            this.deposite_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // F_showpass
            // 
            this.F_showpass.AutoSize = true;
            this.F_showpass.Location = new System.Drawing.Point(762, 133);
            this.F_showpass.Name = "F_showpass";
            this.F_showpass.Size = new System.Drawing.Size(75, 24);
            this.F_showpass.TabIndex = 101;
            this.F_showpass.Text = "Show";
            this.F_showpass.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(633, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 23);
            this.label1.TabIndex = 106;
            this.label1.Text = "Password : ";
            // 
            // F_pass
            // 
            this.F_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.F_pass.Location = new System.Drawing.Point(762, 101);
            this.F_pass.MaxLength = 8;
            this.F_pass.Name = "F_pass";
            this.F_pass.Size = new System.Drawing.Size(250, 26);
            this.F_pass.TabIndex = 100;
            // 
            // lable3
            // 
            this.lable3.AutoSize = true;
            this.lable3.BackColor = System.Drawing.Color.Transparent;
            this.lable3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable3.Location = new System.Drawing.Point(220, 146);
            this.lable3.Name = "lable3";
            this.lable3.Size = new System.Drawing.Size(101, 23);
            this.lable3.TabIndex = 105;
            this.lable3.Text = "Amount : ";
            // 
            // F_rs
            // 
            this.F_rs.Location = new System.Drawing.Point(329, 146);
            this.F_rs.MaxLength = 50;
            this.F_rs.Name = "F_rs";
            this.F_rs.Size = new System.Drawing.Size(250, 26);
            this.F_rs.TabIndex = 102;
            this.F_rs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.F_actno_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(171, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 23);
            this.label3.TabIndex = 104;
            this.label3.Text = "Account No.  : ";
            // 
            // F_actno
            // 
            this.F_actno.Location = new System.Drawing.Point(329, 98);
            this.F_actno.MaxLength = 12;
            this.F_actno.Name = "F_actno";
            this.F_actno.Size = new System.Drawing.Size(250, 26);
            this.F_actno.TabIndex = 99;
            this.F_actno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.F_actno_KeyPress);
            // 
            // deposite_btn
            // 
            this.deposite_btn.BackColor = System.Drawing.Color.White;
            this.deposite_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.deposite_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.deposite_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deposite_btn.Location = new System.Drawing.Point(553, 228);
            this.deposite_btn.Name = "deposite_btn";
            this.deposite_btn.Padding = new System.Windows.Forms.Padding(5);
            this.deposite_btn.Size = new System.Drawing.Size(146, 51);
            this.deposite_btn.TabIndex = 103;
            this.deposite_btn.Text = "Withdraw";
            this.deposite_btn.UseVisualStyleBackColor = false;
            this.deposite_btn.Click += new System.EventHandler(this.withdraw_btn_Click);
            // 
            // withdraw_btn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(168)))), ((int)(((byte)(201)))));
            this.Controls.Add(this.F_showpass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.F_pass);
            this.Controls.Add(this.lable3);
            this.Controls.Add(this.F_rs);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.F_actno);
            this.Controls.Add(this.deposite_btn);
            this.Name = "withdraw_btn";
            this.Size = new System.Drawing.Size(1183, 376);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox F_showpass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox F_pass;
        private System.Windows.Forms.Label lable3;
        private System.Windows.Forms.TextBox F_rs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox F_actno;
        private System.Windows.Forms.Button deposite_btn;

    }
}
