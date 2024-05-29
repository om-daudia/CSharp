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
    public partial class DeleteAct : UserControl
    {
        //DataBase Connnection
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\C#\ATM_SOFT\ATM_SOFT\BANK_DB.mdf;Integrated Security=True");

        public DeleteAct()
        {
            InitializeComponent();
            F_pass.UseSystemPasswordChar = true;
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

        private void F_phone_KeyPress(object sender, KeyPressEventArgs e)
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


        private void DeleteAct_Load(object sender, EventArgs e)
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

        private void delete_Click(object sender, EventArgs e)
        {
            if (F_actno.Text != "" && F_name.Text != "" && F_pass.Text != "")
            {

                conn.Open();

                string qry1 = "DELETE FROM BANK_TBL WHERE (account_no = @acc) AND (name = @name) AND (password = @pass)";
                SqlCommand cm1 = new SqlCommand(qry1, conn);
                cm1.Parameters.AddWithValue("@acc", F_actno.Text);
                cm1.Parameters.AddWithValue("@name", F_name.Text);
                cm1.Parameters.AddWithValue("@pass", F_pass.Text);

                int flag = cm1.ExecuteNonQuery();
                if (flag == 1)
                {
                    MessageBox.Show("Record deleted");
                }
                else
                {
                    MessageBox.Show("Record Not Exist");
                }
                conn.Close();
            }
            else { MessageBox.Show("Details Incomplete", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }
    }
}
