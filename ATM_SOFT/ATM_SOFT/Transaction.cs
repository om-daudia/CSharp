using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_SOFT
{
    public partial class Transaction : UserControl
    {
        public Transaction()
        {
            InitializeComponent();
        }
        private void change(UserControl user)
        {
            user.Dock = DockStyle.Fill;
            pnl_Main.Controls.Clear();
            pnl_Main.Controls.Add(user);
            user.BringToFront();
        }

        private void deposite_btn_Click(object sender, EventArgs e)
        {
            Deposite f = new Deposite();
            change(f);
        }

        private void withdraw_btn_Click(object sender, EventArgs e)
        {
            withdraw_btn f = new withdraw_btn();
            change(f);
        }

        private void bal_check_btn_Click(object sender, EventArgs e)
        {
            BalanceCheckAct f = new BalanceCheckAct();
            change(f);
        }
    }
}
