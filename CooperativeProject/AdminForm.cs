using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CooperativeProject
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hCooperativeDataSet.Holder". При необходимости она может быть перемещена или удалена.
            this.holderTableAdapter.Fill(this.hCooperativeDataSet.Holder);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TextBox1 srv = new TextBox1();
            this.Hide();
            srv.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            InfoClient inf = new InfoClient();
            this.Hide();
            inf.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Ower frm1 = new Ower();
            this.Hide();
            frm1.ShowDialog();
            this.Show();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            Consumption frm1 = new Consumption();
            this.Hide();
            frm1.ShowDialog();
            this.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Overpayment frm = new Overpayment();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SumConsump frm = new SumConsump();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }
    }
}
