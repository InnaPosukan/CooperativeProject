using com.itextpdf.text.pdf;
using CooperativeProject.HCooperativeDataSetTableAdapters;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using DGVPrinterHelper;
using System.Threading.Tasks;
using System.Windows.Forms;

using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CooperativeProject
{
    public partial class Ower : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-0D2M39V;Initial Catalog=HCooperative;Integrated Security=True");

        public Ower()
        {
            InitializeComponent();
        }
        private void Ower_Load(object sender, EventArgs e)
        {
            Data();
        }

        private void Data()
        {
            con.Open();
            SqlCommand com = new SqlCommand(@"SELECT  Holder.Initial AS ПІБ,Appartment.Street AS Вулиця, Appartment.House_num AS Номер_будинку, 
                         Appartment.Appartment_NUM AS Номер_квартири, Phone As Телефон, Receipt.paid_sum - Receipt.accrued_sum AS Борг, 
                         Payment_date As Дата_останньої_оплати, paid_sum As Сума_останьої_оплати
                         FROM Appartment INNER JOIN
                         AppartmentServices ON Appartment.id_appartment = AppartmentServices.id_appartment INNER JOIN
                         Holder ON Appartment.id_holder = Holder.id_holder INNER JOIN
                         Receipt ON AppartmentServices.id_appartmentServices = Receipt.id_appartmentServices
                         WHERE (Receipt.paid_sum - Receipt.accrued_sum )<0  ", con);
            SqlDataAdapter adapter = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = String.Format("ПІБ like '%" + textBox1.Text + "%'");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Звіт про заборгованості";
            printer.SubTitle = string.Format("Звіт за  " + dateTimePicker1.Value.ToString(), printer.SubTitleColor = Color.Black, printer);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;

            printer.FooterSpacing = 15;
            printer.PrintPreviewDataGridView(dataGridView1);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand com = new SqlCommand(@"SELECT  Holder.Initial AS ПІБ,Appartment.Street AS Вулиця, Appartment.House_num AS Номер_будинку, 
                         Appartment.Appartment_NUM AS Номер_квартири, Phone As Телефон, Receipt.paid_sum - Receipt.accrued_sum AS Борг, 
                         Payment_date As Дата_останньої_оплати, paid_sum As Сума_останьої_оплати
                         FROM Appartment INNER JOIN
                         AppartmentServices ON Appartment.id_appartment = AppartmentServices.id_appartment INNER JOIN
                         Holder ON Appartment.id_holder = Holder.id_holder INNER JOIN
                         Receipt ON AppartmentServices.id_appartmentServices = Receipt.id_appartmentServices
                         WHERE (Receipt.paid_sum - Receipt.accrued_sum )<0 
                         ", con);
            SqlDataAdapter adapter = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
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


    
    


    
