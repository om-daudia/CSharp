using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_SOFT
{
    public partial class index_form : Form
    {
        public index_form()
        {
            InitializeComponent();    
        }

        private void index_form_Load(object sender, EventArgs e)
        {
            slidy.BackColor = Color.Transparent;
        }

        private void change(UserControl user)
        {
            user.Dock = DockStyle.Fill;
            pnl_Main.Controls.Clear();
            pnl_Main.Controls.Add(user);
            user.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateAct f = new CreateAct();
            slidy.Width = button1.Width;
            slidy.BackColor = Color.Black;
            slidy.Left = button1.Left;
            change(f);
        }


        private void button4_Click(object sender, EventArgs e)
        {
            Transaction f = new Transaction();
            slidy.Width = button4.Width;
            slidy.BackColor = Color.Black;
            slidy.Left = button4.Left;
            change(f);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UpdateAct f = new UpdateAct();
            slidy.Width = button2.Width;
            slidy.BackColor = Color.Black;
            slidy.Left = button2.Left;
            change(f);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            BalanceCheckAct f = new BalanceCheckAct();
            change(f);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DeleteAct f = new DeleteAct();
            slidy.Width = button3.Width;
            slidy.BackColor = Color.Black;
            slidy.Left = button3.Left;
            change(f);
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            Home f = new Home();
            slidy.BackColor = Color.Transparent;
            change(f);
        }
    }
}
