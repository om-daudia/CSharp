using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace ATM_SOFT
{
    public partial class CreateAct : UserControl
    {
        //DataBase Connnection                  
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\C#\ATM_SOFT\ATM_SOFT\BANK_DB.mdf;Integrated Security=True");


        public CreateAct()
        {
            InitializeComponent();
        }

        private void CreateAct_Load(object sender, EventArgs e)
        {
            F_pass.UseSystemPasswordChar = true;
        }

        //VALIDATION

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

        private void F_showpass_CheckedChanged_1(object sender, EventArgs e)
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

        //VALIDATION OVER

        private void create_Click(object sender, EventArgs e)
        {
            if (F_name.Text != "" && F_pass.Text != "" && F_add.Text != "" && F_phone.Text != "" && F_phone.Text.Length == 10 && F_date.Text != "" && F_email.Text != "" && F_photo.ImageLocation != "" && F_photo.ImageLocation != null)
            {
                try
                {
                    conn.Open();
                    Random Rand = new Random();

                    int Val = Rand.Next();
                    string qry1 = "INSERT INTO BANK_TBL (account_no,name,password,address,phone,dob,gender,email,image) VALUES(@account_no,@name,@password,@address,@phone,@dob,@gender,@email,@IMG)";

                    SqlCommand cm1 = new SqlCommand(qry1, conn);

                    cm1.Parameters.AddWithValue("@account_no", Val);
                    cm1.Parameters.AddWithValue("@name", F_name.Text);
                    cm1.Parameters.AddWithValue("@password", F_pass.Text);
                    cm1.Parameters.AddWithValue("@address", F_add.Text);
                    cm1.Parameters.AddWithValue("@phone", F_phone.Text);
                    cm1.Parameters.AddWithValue("@dob", F_date.Text);

                    //radio buttons
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
                    cm1.Parameters.AddWithValue("@gender", g);
                    cm1.Parameters.AddWithValue("@email", F_email.Text);

                    //image

                    string path = Application.StartupPath.ToString();
                    int rnd = Rand.Next();

                    if (File.Exists(path.Substring(0, path.Length - 10) + "/Images_DB/" + openFileDialog1.SafeFileName))
                    {
                        //MessageBox.Show("Already Exist");
                        File.Copy(F_photo.ImageLocation, path.Substring(0, path.Length - 10) + "/Images_DB/" + rnd + openFileDialog1.SafeFileName);
                    }
                    else
                    {
                        File.Copy(F_photo.ImageLocation, path.Substring(0, path.Length - 10) + "/Images_DB/" + openFileDialog1.SafeFileName);
                    }
                    string IMG_Path = path.Substring(0, path.Length - 10) + "\\Images_DB\\" + rnd + openFileDialog1.SafeFileName.ToString();

                    cm1.Parameters.AddWithValue("@IMG", IMG_Path);

                    //MessageBox.Show("Photo Inserted");


                    int flag = cm1.ExecuteNonQuery();

                    if (flag == 1)
                    {
                        MessageBox.Show("Record Inserted");
                    }
                    else
                    {
                        MessageBox.Show("Please Insert Record");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("try again");
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
                MessageBox.Show("please select file");
            }
            else
            {
                F_photo.ImageLocation = openFileDialog1.FileName;
            }
        }       
    }
}
