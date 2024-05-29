using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ATM_SOFT
{
    public partial class UpdateAct : UserControl
    {
        //DataBase Connnection               
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\C#\ATM_SOFT\ATM_SOFT\BANK_DB.mdf;Integrated Security=True");

        public UpdateAct()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void F_actno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 48 && e.KeyChar <= 57 || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void F_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 65 && e.KeyChar <= 90 || e.KeyChar >= 97 && e.KeyChar <= 122 || e.KeyChar == 8 || e.KeyChar == 32)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void F_add_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 65 && e.KeyChar <= 90 || e.KeyChar >= 97 && e.KeyChar <= 122 || e.KeyChar >= 48 && e.KeyChar <= 57 || e.KeyChar == 44 || e.KeyChar == 45 || e.KeyChar == 8 || e.KeyChar == 32)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void F_pone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 48 && e.KeyChar <= 57 || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void F_email_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 65 && e.KeyChar <= 90 || e.KeyChar >= 97 && e.KeyChar <= 122 || e.KeyChar == 46 || e.KeyChar == '@' || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }


        private void UpdateAct_Load(object sender, EventArgs e)
        {
            F_pass.UseSystemPasswordChar = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void F_showpass_CheckedChanged(object sender, EventArgs e)
        {
            if (F_showpass.Checked == true)
            {
                F_pass.UseSystemPasswordChar = false;
            }
            else
            {
                F_pass.UseSystemPasswordChar = true;
            }
        }

        private void F_pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void next_btn_Click(object sender, EventArgs e)
        {
            if (F_actno.Text != "" && F_name.Text != "" && F_pass.Text != "")
            {
                conn.Open();

                string qry1 = "SELECT * FROM BANK_TBL WHERE (account_no = @ACT) AND (name = @NAME) AND (password = @PASS)";

                SqlCommand cm1 = new SqlCommand(qry1, conn);

                cm1.Parameters.AddWithValue("@ACT", F_actno.Text);
                cm1.Parameters.AddWithValue("@NAME", F_name.Text);
                cm1.Parameters.AddWithValue("@PASS", F_pass.Text);

                SqlDataReader sdr = cm1.ExecuteReader();
                if (sdr.Read())
                {
                    update_panel.Visible = true;
                    update_panel1.Enabled = false;

                    F_upname.Text = sdr[1].ToString();
                    F_add.Text = sdr[3].ToString();
                    F_phone.Text = sdr[4].ToString();
                    F_date.Text = sdr[5].ToString();

                    string val = sdr[6].ToString();
                    // MessageBox.Show(val);
                    if (val == "M")
                    {
                        F_mail.Checked = true;
                    }
                    else if (val == "F")
                    {
                        F_femail.Checked = true;
                    }
                    else if (val == "O")
                    {
                        F_other.Checked = true;
                    }
                    // MessageBox.Show(sdr[8].ToString());

                    F_photo.ImageLocation = sdr[8].ToString();
                    F_email.Text = sdr[7].ToString();
                }
                else
                {
                    MessageBox.Show("Record Not Found");
                }
                conn.Close();
            }
            else { MessageBox.Show("Details Incomplete", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }

        private void update_Click(object sender, EventArgs e)
        {
            if (F_upname.Text != "" && F_add.Text != "" && F_phone.Text != "" && F_phone.Text.Length == 10 && F_date.Text != "" && F_email.Text != "" && F_photo.ImageLocation != "" && F_photo.ImageLocation != null)
            {
                conn.Open();

                string qry2 = "UPDATE BANK_TBL SET name = @NAME, address = @ADD, phone = @PHONE, dob = @DATE, gender = @GEN, email = @EMAIL, image = @IMG WHERE account_no = @ACT ";

                SqlCommand cm2 = new SqlCommand(qry2, conn);
                cm2.Parameters.AddWithValue("@NAME", F_upname.Text);
                cm2.Parameters.AddWithValue("@ADD", F_add.Text);
                cm2.Parameters.AddWithValue("@PHONE", F_phone.Text);
                cm2.Parameters.AddWithValue("@DATE", F_Seldate.Text);

                char g;
                if (F_mail.Checked)
                {
                    g = 'M';
                }
                else if (F_femail.Checked)
                {
                    g = 'F';
                }
                else
                {
                    g = 'O';
                }

                cm2.Parameters.AddWithValue("@GEN", g);
                cm2.Parameters.AddWithValue("@EMAIL", F_email.Text);
                cm2.Parameters.AddWithValue("@IMG", F_photo.ImageLocation);
                cm2.Parameters.AddWithValue("@ACT", F_actno.Text);

                int flag = cm2.ExecuteNonQuery();

                if (flag == 1)
                {
                    MessageBox.Show("Record updated");
                }
                else
                {
                    MessageBox.Show("Try Again");
                }
                conn.Close();
            }
            else { MessageBox.Show("Details Incomplete", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }

        private void F_browse_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            if (openFileDialog1.SafeFileName == "" || openFileDialog1.SafeFileName == null)
            {
                MessageBox.Show("Please seect file");
            }
            else {
                F_photo.ImageLocation = openFileDialog1.FileName;
            }
        }

        private void F_Seldate_ValueChanged(object sender, EventArgs e)
        {
            F_date.Text = F_Seldate.Text;
        }
    }
}
