using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CooperativeProject
{
    public partial class SumConsump : Form
    {
        public SumConsump()
        {
            InitializeComponent();
            Data();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-0D2M39V;Initial Catalog=HCooperative;Integrated Security=True");



        private void Data()
        {
            con.Open();
            SqlCommand com = new SqlCommand(@" SELECT (Meter_reading.value_mr - Meter_reading.value_mr_last) * Tariff.value_tariff AS Сума, Services.Type_services AS Вид_послуги , Initial As ПІБ, street As Вулиця, house_num AS Номер_будинку, appartment_num As Номер_квартири
                      from    Meter_reading INNER JOIN
                         AppartmentServices ON Meter_reading.id_appartmentServices = AppartmentServices.id_appartmentServices INNER JOIN
                         Services ON AppartmentServices.id_services = Services.id_services INNER JOIN
                         Tariff ON Services.id_services = Tariff.id_Services INNER JOIN
                         Appartment ON AppartmentServices.id_appartment = Appartment.id_appartment INNER JOIN
                         Holder ON Appartment.id_holder = Holder.id_holder
                         order by ((Meter_reading.value_mr - Meter_reading.value_mr_last) * Tariff.value_tariff) desc", con);
            SqlDataAdapter adapter = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {

            AdminForm frm1 = new AdminForm();
            this.Hide();
            frm1.ShowDialog();
            this.Show();
        }
    }
}