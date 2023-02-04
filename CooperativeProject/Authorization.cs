using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CooperativeProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-0D2M39V;Initial Catalog=HCooperative;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin")
            {
                AdminForm frm1 = new AdminForm();
                this.Hide();
                frm1.ShowDialog();
                this.Show();

            }
            else
            {
                var loginUser = textBox1.Text;
                Program.num_appartment_transfer = Convert.ToInt32(textBox1.Text);
                var loginPassword = textBox2.Text;
                Program.password_appartment_transfer = Convert.ToInt32(textBox2.Text);

                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable table = new DataTable();
                string querystring = $"select Appartment_Num, Password from Appartment where Appartment_Num = '{loginUser}' and Password = '{loginPassword}'";
                SqlCommand command = new SqlCommand(querystring, con);
                adapter.SelectCommand = command;
                adapter.Fill(table);

                if (table.Rows.Count == 1)
                {
                    UserForm frm = new UserForm();
                    this.Hide();
                    frm.ShowDialog();
                    this.Show();

                }

                else
                {
                    MessageBox.Show("-");
                }

            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }
    }
}
      