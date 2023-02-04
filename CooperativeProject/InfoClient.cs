using CooperativeProject.HCooperativeDataSetTableAdapters;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CooperativeProject
{
    public partial class InfoClient : Form
    {
        string mc;
        public object qv;
        public object a;
        public object b;


        public InfoClient()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-0D2M39V;Initial Catalog=HCooperative;Integrated Security=True");

        private void InfoClient_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hCooperativeDataSet.Holder". При необходимости она может быть перемещена или удалена.
            this.holderTableAdapter.Fill(this.hCooperativeDataSet.Holder);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hCooperativeDataSet.Appartment". При необходимости она может быть перемещена или удалена.
            this.appartmentTableAdapter.Fill(this.hCooperativeDataSet.Appartment);

            holderDataGridView.Columns[0].Visible = false;
            appartmentDataGridView.Columns[0].Visible = false;
            appartmentDataGridView.Columns[6].Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            holderTableAdapter.Insert(initialTextBox.Text, Convert.ToInt32(phoneTextBox.Text), dateOfBirthDateTimePicker.Value);
            mc = holderTableAdapter.ScalarQuery().ToString();
            appartmentTableAdapter.Insert(passwordTextBox.Text, Convert.ToDouble(areaTextBox.Text), streetTextBox.Text, Convert.ToInt32(house_NumTextBox.Text), Convert.ToInt32(appartment_NumTextBox.Text), Convert.ToInt32(inhabitants_NumTextBox.Text), Convert.ToInt16(mc));



     
           
        }

        private void button2_Click_1(object sender, EventArgs e)

        {

            if (holderDataGridView.SelectedRows.Count > 0)
            {
                string a = holderDataGridView.SelectedRows[0].Cells[0].Value.ToString();

                if (MessageBox.Show("Вы действительно хотите удалить запись? Это действие нельзя будет отменить", "Удаление записи", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    string deleteSqlDriversLine = @"DELETE FROM Holder WHERE id_holder=@id_holder";

                    using (SqlConnection connection = new SqlConnection(
                        con.ConnectionString))
                    {
                        SqlCommand command = new SqlCommand(
                            deleteSqlDriversLine, connection);
                        connection.Open();
                        command.Parameters.AddWithValue("id_holder", a);
                        command.ExecuteNonQuery();
                        connection.Close();
                        MessageBox.Show("Запись была успешно удалена", "Удаление записи", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        holderTableAdapter.Fill(hCooperativeDataSet.Holder);
                        hCooperativeDataSet.AcceptChanges();
                    }
                }
            }
        } 
        private void button4_Click(object sender, EventArgs e)
        {
            appartmentTableAdapter.Fill(hCooperativeDataSet.Appartment);
            hCooperativeDataSet.AcceptChanges();
            holderTableAdapter.Fill(hCooperativeDataSet.Holder);
        

        }

        private void button3_Click(object sender, EventArgs e)
        {
          
            holderTableAdapter.Update(hCooperativeDataSet.Holder);
            appartmentTableAdapter.Update(hCooperativeDataSet.Appartment);
        }

        private void appartmentDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AdminForm inf = new AdminForm();
            this.Hide();
            inf.ShowDialog();

        }
    }
    }
      