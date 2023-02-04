using iTextSharp.text;
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
    public partial class TextBox1 : Form
    {
        private object d;
        public TextBox1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-0D2M39V;Initial Catalog=HCooperative;Integrated Security=True");

        private void Services_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hCooperativeDataSet.Meter_reading". При необходимости она может быть перемещена или удалена.
            this.meter_readingTableAdapter.Fill(this.hCooperativeDataSet.Meter_reading);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hCooperativeDataSet.Tariff". При необходимости она может быть перемещена или удалена.
            this.tariffTableAdapter.Fill(this.hCooperativeDataSet.Tariff);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hCooperativeDataSet.Services". При необходимости она может быть перемещена или удалена.
            this.servicesTableAdapter.Fill(this.hCooperativeDataSet.Services);
            tariffDataGridView1.Columns[0].Visible = false;
            servicesDataGridView.Columns[0].Visible=false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            servicesTableAdapter.InsertQuery(type_servicesTextBox.Text);
            d = servicesTableAdapter.ScalarQuery();
           tariffTableAdapter.InsertQuery(Convert.ToDouble(value_tariffTextBox.Text), start_dateDateTimePicker.Text, Convert.ToDouble(bottom_boundTextBox.Text), Convert.ToInt32(d));
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            hCooperativeDataSet.AcceptChanges();
            servicesTableAdapter.Fill(hCooperativeDataSet.Services);
            tariffTableAdapter.Fill(hCooperativeDataSet.Tariff);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (servicesDataGridView.SelectedRows.Count > 0)
            {
                string a = servicesDataGridView.SelectedRows[0].Cells[0].Value.ToString();

                if (MessageBox.Show("Вы действительно хотите удалить запись? Это действие нельзя будет отменить", "Удаление записи", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    string deleteSqlDriversLine = @"DELETE FROM Services WHERE id_services=@id";

                    using (SqlConnection connection = new SqlConnection(
                        con.ConnectionString))
                    {
                        SqlCommand command = new SqlCommand(
                            deleteSqlDriversLine, connection);
                        connection.Open();
                        command.Parameters.AddWithValue("id", a);
                        command.ExecuteNonQuery();
                        connection.Close();
                        MessageBox.Show("Запись была успешно удалена", "Удаление записи", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            servicesTableAdapter.Fill(hCooperativeDataSet.Services);
            hCooperativeDataSet.AcceptChanges();
        }
        private void button4_Click_1(object sender, EventArgs e)
        {
           servicesTableAdapter.Update(hCooperativeDataSet.Services);
           tariffTableAdapter.Update(hCooperativeDataSet.Tariff);
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AdminForm inf = new AdminForm();
            this.Hide();
            inf.ShowDialog();

        }
    }
}
 

