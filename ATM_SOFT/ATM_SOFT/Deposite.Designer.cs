namespace ATM_SOFT
{
    partial class Deposite
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
            this.deposite_btn = new System.Windows.Forms.Button();
            this.lable3 = new System.Windows.Forms.Label();
            this.F_rs = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.F_actno = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // deposite_btn
            // 
            this.deposite_btn.BackColor = System.Drawing.Color.White;
            this.deposite_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.deposite_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.deposite_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deposite_btn.Location = new System.Drawing.Point(544, 228);
            this.deposite_btn.Name = "deposite_btn";
            this.deposite_btn.Padding = new System.Windows.Forms.Padding(5);
            this.deposite_btn.Size = new System.Drawing.Size(146, 51);
            this.deposite_btn.TabIndex = 5;
            this.deposite_btn.Text = "Deposite";
            this.deposite_btn.UseVisualStyleBackColor = false;
            this.deposite_btn.Click += new System.EventHandler(this.deposite_btn_Click);
            // 
            // lable3
            // 
            this.lable3.AutoSize = true;
            this.lable3.BackColor = System.Drawing.Color.Transparent;
            this.lable3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable3.Location = new System.Drawing.Point(707, 98);
            this.lable3.Name = "lable3";
            this.lable3.Size = new System.Drawing.Size(101, 23);
            this.lable3.TabIndex = 97;
            this.lable3.Text = "Amount : ";
            // 
            // F_rs
            // 
            this.F_rs.Location = new System.Drawing.Point(816, 98);
            this.F_rs.MaxLength = 50;
            this.F_rs.Name = "F_rs";
            this.F_rs.Size = new System.Drawing.Size(250, 26);
            this.F_rs.TabIndex = 4;
            this.F_rs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.F_actno_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(162, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 23);
            this.label3.TabIndex = 96;
            this.label3.Text = "Account No.  : ";
            // 
            // F_actno
            // 
            this.F_actno.Location = new System.Drawing.Point(320, 98);
            this.F_actno.MaxLength = 12;
            this.F_actno.Name = "F_actno";
            this.F_actno.Size = new System.Drawing.Size(250, 26);
            this.F_actno.TabIndex = 1;
            this.F_actno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.F_actno_KeyPress);
            // 
            // Deposite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(168)))), ((int)(((byte)(201)))));
            this.Controls.Add(this.lable3);
            this.Controls.Add(this.F_rs);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.F_actno);
            this.Controls.Add(this.deposite_btn);
            this.Name = "Deposite";
            this.Size = new System.Drawing.Size(1183, 376);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button deposite_btn;
        private System.Windows.Forms.Label lable3;
        private System.Windows.Forms.TextBox F_rs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox F_actno;
    }
}
