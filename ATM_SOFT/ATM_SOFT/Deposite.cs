﻿using System;
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
    public partial class Deposite : UserControl
    {
        //DataBase Connnection
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\C#\ATM_SOFT\ATM_SOFT\BANK_DB.mdf;Integrated Security=True");

        public Deposite()
        {
            InitializeComponent();
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
      

        private void deposite_btn_Click(object sender, EventArgs e)
        {
            if (F_actno.Text != "" && F_rs.Text != "")
            {
                conn.Open();

                string qry1 = "UPDATE BANK_TBL SET amount += @AMT WHERE account_no = @ACT";
                SqlCommand cm1 = new SqlCommand(qry1, conn);

                cm1.Parameters.AddWithValue("@ACT", F_actno.Text);

                cm1.Parameters.AddWithValue("@AMT", int.Parse(F_rs.Text));
                //  cm1.ExecuteNonQuery();

                if (Convert.ToInt32(F_rs.Text) > 0)
                {
                    int flag = cm1.ExecuteNonQuery();
                    if (flag == 1)
                    {
                        MessageBox.Show(F_rs.Text + " is Credited");
                    }
                    else
                    {
                        MessageBox.Show("Some thing is Wrong");
                    }
                }
                else
                {
                    MessageBox.Show("Please Enter valid amount");
                }
                conn.Close();
            }
            else { MessageBox.Show("Details Incomplete", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }
    }
}
