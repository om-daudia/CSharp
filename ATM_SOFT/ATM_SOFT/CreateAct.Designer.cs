namespace ATM_SOFT
{
    partial class CreateAct
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
            this.create = new System.Windows.Forms.Button();
            this.F_photo = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.F_email = new System.Windows.Forms.TextBox();
            this.F_date = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.F_femail = new System.Windows.Forms.RadioButton();
            this.F_other = new System.Windows.Forms.RadioButton();
            this.F_mail = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.F_add = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.F_phone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.F_name = new System.Windows.Forms.TextBox();
            this.F_browse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.F_pass = new System.Windows.Forms.TextBox();
            this.F_showpass = new System.Windows.Forms.CheckBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.F_photo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // create
            // 
            this.create.BackColor = System.Drawing.Color.White;
            this.create.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.create.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.create.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.create.Location = new System.Drawing.Point(504, 391);
            this.create.Name = "create";
            this.create.Padding = new System.Windows.Forms.Padding(5);
            this.create.Size = new System.Drawing.Size(123, 51);
            this.create.TabIndex = 10;
            this.create.Text = "Submit";
            this.create.UseVisualStyleBackColor = false;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // F_photo
            // 
            this.F_photo.BackColor = System.Drawing.Color.Transparent;
            this.F_photo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.F_photo.Location = new System.Drawing.Point(829, 269);
            this.F_photo.Name = "F_photo";
            this.F_photo.Size = new System.Drawing.Size(181, 138);
            this.F_photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.F_photo.TabIndex = 36;
            this.F_photo.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(622, 269);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 23);
            this.label9.TabIndex = 34;
            this.label9.Text = "Image :  ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(206, 295);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 23);
            this.label8.TabIndex = 33;
            this.label8.Text = "Email : ";
            // 
            // F_email
            // 
            this.F_email.Location = new System.Drawing.Point(297, 295);
            this.F_email.MaxLength = 20;
            this.F_email.Name = "F_email";
            this.F_email.Size = new System.Drawing.Size(250, 26);
            this.F_email.TabIndex = 8;
            this.F_email.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.F_email_KeyPress);
            // 
            // F_date
            // 
            this.F_date.Location = new System.Drawing.Point(297, 235);
            this.F_date.Name = "F_date";
            this.F_date.Size = new System.Drawing.Size(200, 26);
            this.F_date.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(220, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 23);
            this.label7.TabIndex = 32;
            this.label7.Text = "DOB : ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.F_femail);
            this.panel1.Controls.Add(this.F_other);
            this.panel1.Controls.Add(this.F_mail);
            this.panel1.Location = new System.Drawing.Point(719, 199);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 36);
            this.panel1.TabIndex = 7;
            // 
            // F_femail
            // 
            this.F_femail.Appearance = System.Windows.Forms.Appearance.Button;
            this.F_femail.AutoSize = true;
            this.F_femail.Location = new System.Drawing.Point(75, 0);
            this.F_femail.Name = "F_femail";
            this.F_femail.Size = new System.Drawing.Size(66, 30);
            this.F_femail.TabIndex = 2;
            this.F_femail.Text = "Femail";
            this.F_femail.UseVisualStyleBackColor = true;
            // 
            // F_other
            // 
            this.F_other.Appearance = System.Windows.Forms.Appearance.Button;
            this.F_other.AutoSize = true;
            this.F_other.Location = new System.Drawing.Point(160, 0);
            this.F_other.Name = "F_other";
            this.F_other.Size = new System.Drawing.Size(67, 30);
            this.F_other.TabIndex = 1;
            this.F_other.Text = "Others";
            this.F_other.UseVisualStyleBackColor = true;
            // 
            // F_mail
            // 
            this.F_mail.Appearance = System.Windows.Forms.Appearance.Button;
            this.F_mail.AutoSize = true;
            this.F_mail.Checked = true;
            this.F_mail.Location = new System.Drawing.Point(9, 0);
            this.F_mail.Name = "F_mail";
            this.F_mail.Size = new System.Drawing.Size(47, 30);
            this.F_mail.TabIndex = 0;
            this.F_mail.TabStop = true;
            this.F_mail.Text = "Mail";
            this.F_mail.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(613, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 31;
            this.label6.Text = "Gender : ";
            // 
            // F_add
            // 
            this.F_add.Location = new System.Drawing.Point(297, 138);
            this.F_add.MaxLength = 200;
            this.F_add.Multiline = true;
            this.F_add.Name = "F_add";
            this.F_add.Size = new System.Drawing.Size(250, 71);
            this.F_add.TabIndex = 4;
            this.F_add.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.F_add_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(182, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 23);
            this.label5.TabIndex = 30;
            this.label5.Text = "Address : ";
            // 
            // F_phone
            // 
            this.F_phone.Location = new System.Drawing.Point(719, 143);
            this.F_phone.MaxLength = 10;
            this.F_phone.Name = "F_phone";
            this.F_phone.Size = new System.Drawing.Size(250, 26);
            this.F_phone.TabIndex = 5;
            this.F_phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.F_phone_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(626, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 23);
            this.label4.TabIndex = 29;
            this.label4.Text = "Phone : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(200, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 23);
            this.label3.TabIndex = 28;
            this.label3.Text = "Name : ";
            // 
            // F_name
            // 
            this.F_name.Location = new System.Drawing.Point(297, 82);
            this.F_name.MaxLength = 50;
            this.F_name.Name = "F_name";
            this.F_name.Size = new System.Drawing.Size(250, 26);
            this.F_name.TabIndex = 1;
            this.F_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.F_name_KeyPress);
            // 
            // F_browse
            // 
            this.F_browse.BackColor = System.Drawing.Color.White;
            this.F_browse.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.F_browse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.F_browse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.F_browse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.F_browse.Location = new System.Drawing.Point(722, 269);
            this.F_browse.Name = "F_browse";
            this.F_browse.Padding = new System.Windows.Forms.Padding(5);
            this.F_browse.Size = new System.Drawing.Size(105, 52);
            this.F_browse.TabIndex = 9;
            this.F_browse.Text = "Browse";
            this.F_browse.UseVisualStyleBackColor = false;
            this.F_browse.Click += new System.EventHandler(this.F_browse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(587, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 23);
            this.label1.TabIndex = 81;
            this.label1.Text = "Password : ";
            // 
            // F_pass
            // 
            this.F_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.F_pass.Location = new System.Drawing.Point(722, 82);
            this.F_pass.MaxLength = 8;
            this.F_pass.Name = "F_pass";
            this.F_pass.Size = new System.Drawing.Size(207, 26);
            this.F_pass.TabIndex = 2;
            // 
            // F_showpass
            // 
            this.F_showpass.AutoSize = true;
            this.F_showpass.Location = new System.Drawing.Point(935, 84);
            this.F_showpass.Name = "F_showpass";
            this.F_showpass.Size = new System.Drawing.Size(75, 24);
            this.F_showpass.TabIndex = 3;
            this.F_showpass.Text = "Show";
            this.F_showpass.UseVisualStyleBackColor = true;
            this.F_showpass.CheckedChanged += new System.EventHandler(this.F_showpass_CheckedChanged_1);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // CreateAct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(168)))), ((int)(((byte)(201)))));
            this.Controls.Add(this.F_showpass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.F_pass);
            this.Controls.Add(this.F_browse);
            this.Controls.Add(this.create);
            this.Controls.Add(this.F_photo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.F_email);
            this.Controls.Add(this.F_date);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.F_add);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.F_phone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.F_name);
            this.Name = "CreateAct";
            this.Size = new System.Drawing.Size(1189, 498);
            this.Load += new System.EventHandler(this.CreateAct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.F_photo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button create;
        private System.Windows.Forms.PictureBox F_photo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox F_email;
        private System.Windows.Forms.DateTimePicker F_date;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton F_femail;
        private System.Windows.Forms.RadioButton F_other;
        private System.Windows.Forms.RadioButton F_mail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox F_add;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox F_phone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox F_name;
        private System.Windows.Forms.Button F_browse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox F_pass;
        private System.Windows.Forms.CheckBox F_showpass;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
