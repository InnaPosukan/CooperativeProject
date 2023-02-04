using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CooperativeProject
{
    public partial class Overpayment : Form
    {
        public Overpayment()
        {
            InitializeComponent();
            Data();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-0D2M39V;Initial Catalog=HCooperative;Integrated Security=True");


        private void Data()
        {

            con.Open();
            SqlCommand com = new SqlCommand(@"SELECT  Holder.Initial AS ПІБ,Appartment.Street AS Вулиця, Appartment.House_num AS Номер_будинку, 
                         Appartment.Appartment_NUM AS Номер_квартири, Phone As Телефон, Receipt.paid_sum - Receipt.accrued_sum AS Переплата, 
                         Payment_date As Дата_останньої_оплати, paid_sum As Сума_останьої_оплати
                         FROM Appartment INNER JOIN
                         AppartmentServices ON Appartment.id_appartment = AppartmentServices.id_appartment INNER JOIN
                         Holder ON Appartment.id_holder = Holder.id_holder INNER JOIN
                         Receipt ON AppartmentServices.id_appartmentServices = Receipt.id_appartmentServices
                         WHERE (Receipt.paid_sum - Receipt.accrued_sum )>0 order by (Receipt.paid_sum - Receipt.accrued_sum ) ASC ", con);
            SqlDataAdapter adapter = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Data();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AdminForm inf = new AdminForm();
            this.Hide();
            inf.ShowDialog();

        }
    }
}
