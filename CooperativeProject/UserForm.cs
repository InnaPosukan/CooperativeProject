using CooperativeProject.HCooperativeDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace CooperativeProject
{
    public partial class UserForm : Form
    {
        public string id_appart;
        public object id_app_serv;
        public object id_max_value;
        public string id_serv;
        public int value_mr_last;
        public int value_mr_last2;
        public object qv;
        public object rez;
        public string id_serve;


        SqlConnection con = new SqlConnection("Data Source=DESKTOP-0D2M39V;Initial Catalog=HCooperative;Integrated Security=True");

        public UserForm()
        {

            InitializeComponent();
            label7.Text = Convert.ToString(Program.num_appartment_transfer);
            Convert.ToString(Program.password_appartment_transfer);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < dataGridView1.RowCount - 1; i++)

            {
                if (dataGridView1[5, i].Value.ToString() == Convert.ToString(Program.num_appartment_transfer) && dataGridView1[1, i].Value.ToString() == Convert.ToString(Program.password_appartment_transfer))

                {
                    Program.Appart_id = dataGridView1[0, i].Value.ToString();
                }
            }

            int index = type_servicesComboBox.SelectedIndex;
            switch (index)
            {
                case 1:
                    break;
            }

            this.meter_readingTableAdapter1.Fill(this.hCooperativeDataSet1.Meter_reading);

            for (int i = 0; i < dataGridView1.RowCount - 1; i++)

            {
                if (dataGridView1[5, i].Value.ToString() == Convert.ToString(Program.num_appartment_transfer) && dataGridView1[1, i].Value.ToString() == Convert.ToString(Program.password_appartment_transfer))

                {
                    id_appart = dataGridView1[0, i].Value.ToString();
                    id_app_serv = appartmentServicesTableAdapter1.ScalarQuery();
                    id_serv = Convert.ToString(type_servicesComboBox.SelectedValue);
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    DataTable table = new DataTable();
                    string querystring = $"select id_appartmentServices, id_appartment, id_services from AppartmentServices where id_appartment =  '{id_appart}' and id_services = '{id_serv}'";
                    SqlCommand command = new SqlCommand(querystring, con);
                    adapter.SelectCommand = command;
                    adapter.Fill(table);
                    if (table.Rows.Count != 0)
                    {
                        value_mr_last = Convert.ToInt32(table.Rows[table.Rows.Count - 1][0]);
                    }
                    else
                    {
                        value_mr_last = 0;
                    }
                    SqlDataAdapter adapter1 = new SqlDataAdapter();
                    DataTable table1 = new DataTable();
                    string querystring1 = $"select value_mr From Meter_reading where id_appartmentServices =  '{value_mr_last}'";
                    SqlCommand command1 = new SqlCommand(querystring1, con);
                    adapter1.SelectCommand = command1;
                    adapter1.Fill(table1);
                    if (table1.Rows.Count != 0)
                    {
                        value_mr_last2 = Convert.ToInt32(table1.Rows[0][0].ToString());
                    }
                    else
                    {
                        value_mr_last2 = 0;
                    }
                    int select = Convert.ToInt32(type_servicesComboBox.SelectedValue);
                    //MessageBox.Show(select.ToString());
                    if (select == 5)
                    {
                        appartmentServicesTableAdapter1.InsertQuery(Convert.ToInt32(Program.Appart_id), 5);
                        this.meter_readingTableAdapter1.Fill(hCooperativeDataSet1.Meter_reading);
                        qv = appartmentServicesTableAdapter1.ScalarQuery();
                        meter_readingTableAdapter1.InsertQuery1(2, dateTimePicker1.Value, Convert.ToInt32(qv), 1);

                    }
                    else if (select == 49)
                    {
                        appartmentServicesTableAdapter1.InsertQuery(Convert.ToInt32(Program.Appart_id), 49);
                        this.meter_readingTableAdapter1.Fill(hCooperativeDataSet1.Meter_reading);
                        qv = appartmentServicesTableAdapter1.ScalarQuery();
                        meter_readingTableAdapter1.InsertQuery1(2, dateTimePicker1.Value, Convert.ToInt32(qv), 1);
                    }
                    else if (select > 49)
                    {
                        appartmentServicesTableAdapter1.InsertQuery(Convert.ToInt32(Program.Appart_id), select);
                        this.meter_readingTableAdapter1.Fill(hCooperativeDataSet1.Meter_reading);
                        qv = appartmentServicesTableAdapter1.ScalarQuery();
                        meter_readingTableAdapter1.InsertQuery1(2, dateTimePicker1.Value, Convert.ToInt32(qv), 1);
                    }
                    else
                    {


                        appartmentServicesTableAdapter1.InsertQuery(Convert.ToInt32(id_appart), Convert.ToInt32(type_servicesComboBox.SelectedValue));
                        this.meter_readingTableAdapter1.Fill(hCooperativeDataSet1.Meter_reading);
                        qv = appartmentServicesTableAdapter1.ScalarQuery();
                        meter_readingTableAdapter1.InsertQuery1(Convert.ToInt32(textBox1.Text), dateTimePicker1.Value, Convert.ToInt32(qv), value_mr_last2);
                    }
                }
            }
        }

        private void UserForm_Load(object sender, EventArgs e)
        {   // TODO: данная строка кода позволяет загрузить данные в таблицу "hCooperativeDataSet1.Services". При необходимости она может быть перемещена или удалена.
            this.servicesTableAdapter.Fill(this.hCooperativeDataSet1.Services);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hCooperativeDataSet1.Appartment". При необходимости она может быть перемещена или удалена.
            this.appartmentTableAdapter.Fill(this.hCooperativeDataSet1.Appartment);

            dtgv();

        }
        private void button3_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < dataGridView1.RowCount - 1; i++)

            {
                if (dataGridView1[5, i].Value.ToString() == Convert.ToString(Program.num_appartment_transfer) && dataGridView1[1, i].Value.ToString() == Convert.ToString(Program.password_appartment_transfer))

                {
                    Program.Appart_id = dataGridView1[0, i].Value.ToString();
                }
            }

            


            SqlDataAdapter adapter4 = new SqlDataAdapter();
            DataTable table4 = new DataTable();
            string querystring4 = $"select id_services from Services";
            SqlCommand command4 = new SqlCommand(querystring4, con);
            adapter4.SelectCommand = command4;
            adapter4.Fill(table4);
            Program.count_services = table4.Rows.Count;
            Payment pay = new Payment();
            pay.ShowDialog();
            this.Hide();
        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.servicesTableAdapter.FillBy1(this.hCooperativeDataSet1.Services);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void dtgv()
        {

            for (int i = 0; i < dataGridView1.RowCount - 1; i++)

            {
                if (dataGridView1[5, i].Value.ToString() == Convert.ToString(Program.num_appartment_transfer) && dataGridView1[1, i].Value.ToString() == Convert.ToString(Program.password_appartment_transfer))

                {
                    Program.Appart_id = dataGridView1[0, i].Value.ToString();
                }
            }
            con.Open();
            //MessageBox.Show(Program.Appart_id);
            SqlCommand com = new SqlCommand($"SELECT        Meter_reading.value_mr, Meter_reading.date_mr, Meter_reading.value_mr_last, Services.Type_services\r\nFROM            Meter_reading INNER JOIN\r\n                         AppartmentServices ON Meter_reading.id_appartmentServices = AppartmentServices.id_appartmentServices INNER JOIN\r\n                         Services ON AppartmentServices.id_services = Services.id_services where id_appartment =  '{Program.Appart_id}'", con);
            SqlDataAdapter adapter = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];


        }
        private void type_servicesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (type_servicesComboBox.SelectedIndex > 2)
            {
                textBox1.Enabled= false;    
            }
            else { 
            textBox1.Enabled = true;
            }
        }

    }
 }