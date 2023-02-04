using iTextSharp.text;
using Org.BouncyCastle.Asn1.X509;
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
    public partial class Consumption : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-0D2M39V;Initial Catalog=HCooperative;Integrated Security=True");

        public Consumption()
        {
            InitializeComponent();
        }

 
        private void Consumption_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand com = new SqlCommand(@"SELECT Appartment.House_Num AS Номер_будинку, Appartment.Appartment_Num AS Номер_квартири, Holder.Initial AS ПІБ, Meter_reading.value_mr - Meter_reading.value_mr_last AS Показники, Services.Type_services AS Вид_послуги , Meter_reading.date_mr AS Дата_передачі_показань
                            FROM            Appartment INNER JOIN
                         AppartmentServices ON Appartment.id_appartment = AppartmentServices.id_appartment INNER JOIN
                         Meter_reading ON AppartmentServices.id_appartmentServices = Meter_reading.id_appartmentServices INNER JOIN
                         Holder ON Appartment.id_holder = Holder.id_holder INNER JOIN
                         Services ON AppartmentServices.id_services = Services.id_services  ", con);
            SqlDataAdapter adapter = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
           con.Close(); 

          

            }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            con.Open();
            if (checkBox1.Checked == true)
            {
                SqlCommand com1 = new SqlCommand(@"SELECT Appartment.House_Num, Appartment.Appartment_Num, Holder.Initial, Meter_reading.value_mr - Meter_reading.value_mr_last AS Expr1, Services.Type_services, Meter_reading.date_mr
                            FROM            Appartment INNER JOIN
                         AppartmentServices ON Appartment.id_appartment = AppartmentServices.id_appartment INNER JOIN
                         Meter_reading ON AppartmentServices.id_appartmentServices = Meter_reading.id_appartmentServices INNER JOIN
                         Holder ON Appartment.id_holder = Holder.id_holder INNER JOIN
                         Services ON AppartmentServices.id_services = Services.id_services where type_services = 'Електропостачання'  ", con);
                SqlDataAdapter adapter1 = new SqlDataAdapter(com1);
                DataSet ds1 = new DataSet();
                adapter1.Fill(ds1);
                dataGridView1.DataSource = ds1.Tables[0];

            }
            else
            {
                SqlCommand com = new SqlCommand(@"SELECT Appartment.House_Num, Appartment.Appartment_Num, Holder.Initial, Meter_reading.value_mr - Meter_reading.value_mr_last AS Expr1, Services.Type_services, Meter_reading.date_mr
                            FROM            Appartment INNER JOIN
                         AppartmentServices ON Appartment.id_appartment = AppartmentServices.id_appartment INNER JOIN
                         Meter_reading ON AppartmentServices.id_appartmentServices = Meter_reading.id_appartmentServices INNER JOIN
                         Holder ON Appartment.id_holder = Holder.id_holder INNER JOIN
                         Services ON AppartmentServices.id_services = Services.id_services  ", con);
                SqlDataAdapter adapter = new SqlDataAdapter(com);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            con.Close();

        }

        private void checkBox2_Click(object sender, EventArgs e)
        {
            con.Open();
            if (checkBox2.Checked == true)
            {
                SqlCommand com1 = new SqlCommand(@"SELECT Appartment.House_Num, Appartment.Appartment_Num, Holder.Initial, Meter_reading.value_mr - Meter_reading.value_mr_last AS Expr1, Services.Type_services, Meter_reading.date_mr
                            FROM            Appartment INNER JOIN
                         AppartmentServices ON Appartment.id_appartment = AppartmentServices.id_appartment INNER JOIN
                         Meter_reading ON AppartmentServices.id_appartmentServices = Meter_reading.id_appartmentServices INNER JOIN
                         Holder ON Appartment.id_holder = Holder.id_holder INNER JOIN
                         Services ON AppartmentServices.id_services = Services.id_services where type_services = 'Газопостачання'  ", con);
                SqlDataAdapter adapter1 = new SqlDataAdapter(com1);
                DataSet ds1 = new DataSet();
                adapter1.Fill(ds1);
                dataGridView1.DataSource = ds1.Tables[0];

            }
            else
            {
                SqlCommand com = new SqlCommand(@"SELECT Appartment.House_Num, Appartment.Appartment_Num, Holder.Initial, Meter_reading.value_mr - Meter_reading.value_mr_last AS Expr1, Services.Type_services, Meter_reading.date_mr
                            FROM            Appartment INNER JOIN
                         AppartmentServices ON Appartment.id_appartment = AppartmentServices.id_appartment INNER JOIN
                         Meter_reading ON AppartmentServices.id_appartmentServices = Meter_reading.id_appartmentServices INNER JOIN
                         Holder ON Appartment.id_holder = Holder.id_holder INNER JOIN
                         Services ON AppartmentServices.id_services = Services.id_services  ", con);
                SqlDataAdapter adapter = new SqlDataAdapter(com);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            con.Close();

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            con.Open();
            if (checkBox3.Checked == true)
            {
                SqlCommand com1 = new SqlCommand(@"SELECT Appartment.House_Num, Appartment.Appartment_Num, Holder.Initial, Meter_reading.value_mr - Meter_reading.value_mr_last AS Expr1, Services.Type_services, Meter_reading.date_mr
                            FROM            Appartment INNER JOIN
                         AppartmentServices ON Appartment.id_appartment = AppartmentServices.id_appartment INNER JOIN
                         Meter_reading ON AppartmentServices.id_appartmentServices = Meter_reading.id_appartmentServices INNER JOIN
                         Holder ON Appartment.id_holder = Holder.id_holder INNER JOIN
                         Services ON AppartmentServices.id_services = Services.id_services where type_services = 'Водопостачання'  ", con);
                SqlDataAdapter adapter1 = new SqlDataAdapter(com1);
                DataSet ds1 = new DataSet();
                adapter1.Fill(ds1);
                dataGridView1.DataSource = ds1.Tables[0];
            }
            else
            {
                SqlCommand com = new SqlCommand(@"SELECT Appartment.House_Num, Appartment.Appartment_Num, Holder.Initial, Meter_reading.value_mr - Meter_reading.value_mr_last AS Expr1, Services.Type_services, Meter_reading.date_mr
                            FROM            Appartment INNER JOIN
                         AppartmentServices ON Appartment.id_appartment = AppartmentServices.id_appartment INNER JOIN
                         Meter_reading ON AppartmentServices.id_appartmentServices = Meter_reading.id_appartmentServices INNER JOIN
                         Holder ON Appartment.id_holder = Holder.id_holder INNER JOIN
                         Services ON AppartmentServices.id_services = Services.id_services  ", con);
                SqlDataAdapter adapter = new SqlDataAdapter(com);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            con.Close();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            AdminForm inf = new AdminForm();
            this.Hide();
            inf.ShowDialog();

        }
    }
   }

    

