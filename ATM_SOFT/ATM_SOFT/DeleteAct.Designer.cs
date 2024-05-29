namespace ATM_SOFT
{
    partial class DeleteAct
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
            this.delete = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.F_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.F_actno = new System.Windows.Forms.TextBox();
            this.F_showpass = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.F_pass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.White;
            this.delete.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete.Location = new System.Drawing.Point(512, 298);
            this.delete.Name = "delete";
            this.delete.Padding = new System.Windows.Forms.Padding(5);
            this.delete.Size = new System.Drawing.Size(123, 51);
            this.delete.TabIndex = 5;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(460, 160);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 23);
            this.label11.TabIndex = 53;
            this.label11.Text = "Name : ";
            // 
            // F_name
            // 
            this.F_name.Location = new System.Drawing.Point(551, 157);
            this.F_name.MaxLength = 50;
            this.F_name.Name = "F_name";
            this.F_name.Size = new System.Drawing.Size(250, 26);
            this.F_name.TabIndex = 2;
            this.F_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.F_name_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(393, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 23);
            this.label3.TabIndex = 51;
            this.label3.Text = "Account No.  : ";
            // 
            // F_actno
            // 
            this.F_actno.Location = new System.Drawing.Point(551, 103);
            this.F_actno.MaxLength = 12;
            this.F_actno.Name = "F_actno";
            this.F_actno.Size = new System.Drawing.Size(250, 26);
            this.F_actno.TabIndex = 1;
            this.F_actno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.F_actno_KeyPress);
            // 
            // F_showpass
            // 
            this.F_showpass.AutoSize = true;
            this.F_showpass.Location = new System.Drawing.Point(551, 236);
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
            this.label1.Location = new System.Drawing.Point(422, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 23);
            this.label1.TabIndex = 88;
            this.label1.Text = "Password : ";
            // 
            // F_pass
            // 
            this.F_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.F_pass.Location = new System.Drawing.Point(551, 204);
            this.F_pass.MaxLength = 8;
            this.F_pass.Name = "F_pass";
            this.F_pass.Size = new System.Drawing.Size(207, 26);
            this.F_pass.TabIndex = 3;
            // 
            // DeleteAct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(168)))), ((int)(((byte)(201)))));
            this.Controls.Add(this.F_showpass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.F_pass);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.F_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.F_actno);
            this.Name = "DeleteAct";
            this.Size = new System.Drawing.Size(1189, 498);
            this.Load += new System.EventHandler(this.DeleteAct_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox F_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox F_actno;
        private System.Windows.Forms.CheckBox F_showpass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox F_pass;
    }
}
