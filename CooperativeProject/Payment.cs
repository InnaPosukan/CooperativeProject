using CooperativeProject.HCooperativeDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.IO;
using System.Collections;
using System.Windows.Forms;
using System.Linq.Expressions;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using iTextSharp.text.pdf.codec;
using System.Reflection;
using Font = System.Drawing.Font;

namespace CooperativeProject
{
    public partial class Payment : Form
    {

        public string adress;
        public object servi;
        public int id_app_serv;
        public decimal sum_owed;
        public decimal overp;
        public string[] array = new string[Program.count_services];
        public string[] array1 = new string[Program.count_services];
        public string mas;
        public double rcd = 0;
        public object qv;
        public int value_mr_last;

        public Payment()
        {
            InitializeComponent();
            load_data();



        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-0D2M39V;Initial Catalog=HCooperative;Integrated Security=True");

        private void load_data()
        {
            textBox1.Text = "0";
            lable10();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string querystring = $"select Street, House_Num , Appartment_Num from Appartment where Appartment_Num =  '{Program.num_appartment_transfer}'";
            SqlCommand command = new SqlCommand(querystring, con);
            adapter.SelectCommand = command;
            adapter.Fill(table);
            label1.Text = table.Rows[0][0].ToString();
            label2.Text = table.Rows[0][1].ToString();
            label3.Text = table.Rows[0][2].ToString();

            DataTable table1 = new DataTable();
            querystring = $"select id_services from Services";
            command = new SqlCommand(querystring, con);
            adapter.SelectCommand = command;
            adapter.Fill(table1);

            for (int i = 0; i < table1.Rows.Count; i++)
            {
                array[i] = "0";
                SqlDataAdapter adapter4 = new SqlDataAdapter();
                DataTable table4 = new DataTable();
                string querystring4 = $"select id_appartmentServices, id_appartment , id_services from AppartmentServices where id_appartment = '{Program.Appart_id}' AND id_services = '{table1.Rows[i][0]}'";
                SqlCommand command4 = new SqlCommand(querystring4, con);
                adapter4.SelectCommand = command4;
                adapter4.Fill(table4);
                if (table4.Rows.Count != 0)
                {
                    id_app_serv = Convert.ToInt32(table4.Rows[table4.Rows.Count - 1][0]);
                }
                //MessageBox.Show(table4.Rows.Count.ToString());


                SqlDataAdapter adapter5 = new SqlDataAdapter();
                DataTable table5 = new DataTable();
                string querystring5 = $"SELECT Type_services FROM Services";
                SqlCommand command5 = new SqlCommand(querystring5, con);
                adapter5.SelectCommand = command5;
                adapter5.Fill(table5);
                array1[i] = table5.Rows[i][0].ToString();

                //if (table4.Rows.Count != 0)
                //{

                SqlDataAdapter adapter2 = new SqlDataAdapter();
                DataTable table2 = new DataTable();
                string querystring2 = $"SELECT DISTINCT Tariff.id_Services, AppartmentServices.id_appartmentServices, (Meter_reading.value_mr - Meter_reading.value_mr_last) * Tariff.value_tariff " +
                    $"FROM Meter_reading INNER JOIN AppartmentServices ON Meter_reading.id_appartmentServices = AppartmentServices.id_appartmentServices INNER JOIN\r\n                         Services ON AppartmentServices.id_services = Services.id_services INNER JOIN\r\n                         Tariff ON Services.id_services = Tariff.id_Services" +
                    $"   WHERE Tariff.id_Services = '{table1.Rows[i][0]}' AND  AppartmentServices.id_appartmentServices = '{id_app_serv}'";
                SqlCommand command2 = new SqlCommand(querystring2, con);
                adapter2.SelectCommand = command2;
                adapter2.Fill(table2);
                //MessageBox.Show(table2.Rows[0][2].ToString());
                //MessageBox.Show(table2.Rows.Count.ToString());
                //MessageBox.Show(id_app_serv.ToString());
                if (table2.Rows.Count != 0)
                {
                    if ((Convert.ToInt32(table2.Rows[0][2]) > 288) && (table1.Rows[0][0].ToString() == "3"))
                    {
                        SqlDataAdapter adapter3 = new SqlDataAdapter();
                        DataTable table3 = new DataTable();
                        string querystring3 = $"SELECT DISTINCT Tariff.id_Services , (Meter_reading.value_mr - Meter_reading.value_mr_last) * Tariff.bottom_bound FROM Meter_reading INNER JOIN AppartmentServices ON Meter_reading.id_appartmentServices = AppartmentServices.id_appartmentServices INNER JOIN Services ON AppartmentServices.id_services = Services.id_services INNER JOIN  Tariff ON Services.id_services = Tariff.id_Services WHERE Tariff.id_Services = '{table1.Rows[i][0]}' AND  id_appartmentServices = '{id_app_serv}'";
                        SqlCommand command3 = new SqlCommand(querystring3, con);
                        adapter3.SelectCommand = command3;
                        adapter3.Fill(table3);
                        array[i] = table3.Rows[i][2].ToString();
                        
                    }
                    else
                    {
                        array[i] = table2.Rows[0][2].ToString();

                    }
                }

            }
        
                for (int i = 0; i < array.Length; i++)
                {
                //MessageBox.Show(array[i]);
                    mas = listBox1.Text;
                    listBox1.Items.Add(mas + string.Format(array1[i]));
                    listBox1.Items.Add(mas + string.Format(array[i]));
                    rcd = rcd + Convert.ToDouble(array[i]);

                }
                listBox1.Items.Add(mas + "Загальна сума");
                listBox1.Items.Add(mas + string.Format(rcd.ToString()));
            lable10();

        }
        private void Payment_Load(object sender, EventArgs e)
        {
          using(HCooperativeDataSet db = new HCooperativeDataSet())
            {
                receiptBindingSource.DataSource = db.Receipt.ToList();
            }
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hCooperativeDataSet.Appartment". При необходимости она может быть перемещена или удалена.
            this.appartmentTableAdapter.Fill(this.hCooperativeDataSet.Appartment);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hCooperativeDataSet.Receipt". При необходимости она может быть перемещена или удалена.
            this.receiptTableAdapter.Fill(this.hCooperativeDataSet.Receipt);
            
        }

        private void lable10()
        {
            SqlDataAdapter adapter5 = new SqlDataAdapter();
            DataTable table5 = new DataTable();
            string querystring5 = $"select id_receipt, sum_owed , overpayment from Receipt where id_appartmentServices = '{id_app_serv}'";
            SqlCommand command5 = new SqlCommand(querystring5, con);
            adapter5.SelectCommand = command5;
            adapter5.Fill(table5);

            if (table5.Rows.Count != 0)
            {
                if ((table5.Rows[table5.Rows.Count - 1][1]) is decimal )
                {
                    label10.Text = table5.Rows[table5.Rows.Count - 1][1].ToString();
                }
                else
                {
                    label10.Text = "0";
                }
                if ((table5.Rows[table5.Rows.Count - 1][2]) is decimal)
                {
                    label5.Text = Convert.ToDouble(table5.Rows[table5.Rows.Count - 1][2]).ToString();
                }
                else
                {
                    label5.Text = "0";
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            SqlDataAdapter adapter5 = new SqlDataAdapter();
            DataTable table5 = new DataTable();
            string querystring5 = $"select id_receipt, sum_owed , overpayment from Receipt where id_appartmentServices = '{id_app_serv}'";
            SqlCommand command5 = new SqlCommand(querystring5, con);
            adapter5.SelectCommand = command5;
            adapter5.Fill(table5);

            if (table5.Rows.Count != 0)
            {
                if ((table5.Rows[table5.Rows.Count - 1][1]) is decimal)
                {
                    sum_owed = Convert.ToDecimal(table5.Rows[table5.Rows.Count - 1][1]);
                }
                else
                {
                    sum_owed = 0;
                }
                if (table5.Rows[table5.Rows.Count - 1][2] is decimal)
                {
                    overp = Convert.ToDecimal(table5.Rows[table5.Rows.Count - 1][2]);
                }
                else
                {
                    overp = 0;
                }
            }

            label12.Text = Math.Abs(sum_owed).ToString();

            DateTime now = new DateTime();
            var mounth = DateTime.Now.Month;
            var year = DateTime.Now.Year;
            var first = new DateTime(year, mounth, 1);
            var last = new DateTime(year, mounth, DateTime.Now.Day);


            SqlDataAdapter adapter1 = new SqlDataAdapter();
            DataTable table1 = new DataTable();
            string querystring1 = $"select id_services from Services";
            SqlCommand command1 = new SqlCommand(querystring1, con);
            adapter1.SelectCommand = command1;
            adapter1.Fill(table1);
            SqlDataAdapter adapter4 = new SqlDataAdapter();
            DataTable table4 = new DataTable();
            
            //decimal sum_pay = Convert.ToDecimal(textBox1.Text) + overp - Math.Abs(sum_owed);
            decimal sum_pay1 = ((Convert.ToDecimal(textBox1.Text)) + overp - Math.Abs(sum_owed) - Convert.ToDecimal(listBox1.Items[listBox1.Items.Count - 1]));
            if (sum_pay1  < 0)
            {
                checkBox1.Checked = false;
                checkBox1.Text = "Не оплачено";

       
               
                receiptTableAdapter.InsertQuery(Convert.ToDecimal(listBox1.Items[listBox1.Items.Count - 1]), Convert.ToDecimal(textBox1.Text),
                sum_pay1, checkBox1.Text,
                dateTimePicker1.Value.ToString(), first.ToString(), last.ToString(), id_app_serv);

            }
            else
            {
                checkBox1.Checked = true;
                checkBox1.Text = "Оплачено";
                receiptTableAdapter.InsertQuery1(Convert.ToDecimal(listBox1.Items[listBox1.Items.Count - 1]), Convert.ToDecimal(textBox1.Text),
                sum_pay1, checkBox1.Text, 
                dateTimePicker1.Value.ToString(), first.ToString(), last.ToString(), id_app_serv);
                MessageBox.Show("Ви виплатили за месяц  + ДОЛГИ", dateTimePicker1.Text);
            }

            for (int i = 0; i < table1.Rows.Count; i++)
            {
                string querystring4 = $"Select id_appartmentServices, id_appartment , id_services from AppartmentServices where id_appartment = '{Program.Appart_id}' AND id_services = '{table1.Rows[i][0]}'";
                SqlCommand command4 = new SqlCommand(querystring4, con);
                adapter4.SelectCommand = command4;
                adapter4.Fill(table4);
                id_app_serv = Convert.ToInt32(table4.Rows[table4.Rows.Count - 1][0]);
                paymentTableAdapter1.InsertQuery(dateTimePicker1.Value, id_app_serv);
            }

            lable10();
            SqlDataAdapter adapter6 = new SqlDataAdapter();
            DataTable table6 = new DataTable();
            string querystring6 = $"select id_services from Services";
            SqlCommand command6 = new SqlCommand(querystring6, con);
            adapter6.SelectCommand = command6;
            adapter6.Fill(table6);

            for (int i = 0; i <= table6.Rows.Count-1; i++)
            {

                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable table = new DataTable();
                string querystring = $"select id_appartmentServices, id_appartment, id_services from AppartmentServices where id_appartment =  '{Program.Appart_id}' and id_services = '{table6.Rows[i][0]}'";
                SqlCommand command = new SqlCommand(querystring, con);
                adapter.SelectCommand = command;
                adapter.Fill(table);
                //MessageBox.Show(table.Rows.Count.ToString());
                if (table.Rows.Count != 0) {

                    if (table.Rows.Count >= 1)
                    {
                        value_mr_last = Convert.ToInt32(table.Rows[table.Rows.Count - 1][0]);
                    }
                    else
                    {
                        value_mr_last = Convert.ToInt32(table.Rows[0][0]);
                    }

                    SqlDataAdapter adapter2 = new SqlDataAdapter();
                    DataTable table2 = new DataTable();
                    string querystring2 = $"select value_mr  From Meter_reading where id_appartmentServices = '{value_mr_last}'";
                    SqlCommand command2 = new SqlCommand(querystring2, con);
                    adapter2.SelectCommand = command2;
                    adapter2.Fill(table2);

                    this.meter_readingTableAdapter1.Fill(hCooperativeDataSet1.Meter_reading);
                    qv = appartmentServicesTableAdapter1.ScalarQuery();
                    //MessageBox.Show(value_mr_last.ToString());
                    if (table2.Rows.Count != 0)
                    {
                        meter_readingTableAdapter1.InsertQuery1(Convert.ToInt32(table2.Rows[0][0]), dateTimePicker1.Value, value_mr_last, Convert.ToInt32(table2.Rows[0][0]));
                    }
                    else
                    {
                        meter_readingTableAdapter1.InsertQuery1(0, dateTimePicker1.Value, value_mr_last, 0);

                    }
                }
               


            

                if (checkBox1.Checked == true)
                {
                    button2.Enabled = true;
                }
                button1.Enabled = false;
            }
            


            

        }
        public string str = "Квитанція";
        public string str1 = "Адреса:";
        public string str2 = "Дата формування квитанції:";
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font drawFont = new Font("Arial", 10);
            Font drawFont1 = new Font("Arial", 17);
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            float x = 350;
            float y = 5;
            StringFormat drawFormat = new StringFormat();
            drawFormat.FormatFlags = StringFormatFlags.DirectionVertical;
            Bitmap bmp = new Bitmap(900, 400);
            label1.DrawToBitmap(bmp, new System.Drawing.Rectangle(120, 70, 100, 40));
            label2.DrawToBitmap(bmp, new System.Drawing.Rectangle(170, 70, 100, 80));
            label3.DrawToBitmap(bmp, new System.Drawing.Rectangle(200, 70, 100, 40));
            label11.DrawToBitmap(bmp, new System.Drawing.Rectangle(40, 300, 150, 50));
            label12.DrawToBitmap(bmp, new System.Drawing.Rectangle(100, 300, 150, 50));
            dateTimePicker1.DrawToBitmap(bmp, new System.Drawing.Rectangle(550, 340, 190, 50));
            listBox1.DrawToBitmap(bmp, new System.Drawing.Rectangle(40, 100, listBox1.Width, listBox1.Height));
            e.Graphics.DrawString(str, drawFont1, drawBrush, x, y);
            e.Graphics.DrawString(str1, drawFont, drawBrush, 40, 70);
            e.Graphics.DrawString(str2, drawFont, drawBrush, 40, 350);
            e.Graphics.DrawImage(bmp, 0, 0);
           
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            var bmp = new Bitmap(this.Size.Width, this.Size.Height, g);
            Graphics mg = Graphics.FromImage(bmp);
            mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            printPreviewDialog1.ShowDialog();
            
        }

      
    }
}