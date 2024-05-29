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
    public partial class BalanceCheckAct : UserControl
    {
        //DataBase Connnection
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\C#\ATM_SOFT\ATM_SOFT\BANK_DB.mdf;Integrated Security=True");

        public BalanceCheckAct()
        {
            InitializeComponent();
            F_pass.UseSystemPasswordChar = true;     
        }

        private void F_actno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 48 && e.KeyChar <= 57)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
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

        private void check_Click(object sender, EventArgs e)
        {
            if (F_actno.Text != "" && F_pass.Text != "")
            {
                conn.Open();

                string qry1 = "SELECT amount FROM BANK_TBL WHERE (account_no = @ACT) AND (password = @PASS)";
                SqlCommand cm1 = new SqlCommand(qry1, conn);
                cm1.Parameters.AddWithValue("@ACT", F_actno.Text);
                cm1.Parameters.AddWithValue("@PASS", F_pass.Text);

                SqlDataReader sdr = cm1.ExecuteReader();
                if (sdr.Read())
                {
                    bal_panel.Visible = true;
                    F_balance.Text = sdr[0].ToString();
                }
                else
                {
                    MessageBox.Show("User Not Exist");
                }
                conn.Close();
            }
            else { MessageBox.Show("Details Incomplete", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }
    }
}
