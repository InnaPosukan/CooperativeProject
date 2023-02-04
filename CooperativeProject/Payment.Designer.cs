namespace CooperativeProject
{
    partial class Payment
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payment));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.appartmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hCooperativeDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hCooperativeDataSet = new CooperativeProject.HCooperativeDataSet();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.printPreviewDialog2 = new System.Windows.Forms.PrintPreviewDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.paymentTableAdapter1 = new CooperativeProject.HCooperativeDataSetTableAdapters.PaymentTableAdapter();
            this.receiptTableAdapter = new CooperativeProject.HCooperativeDataSetTableAdapters.ReceiptTableAdapter();
            this.appartmentTableAdapter = new CooperativeProject.HCooperativeDataSetTableAdapters.AppartmentTableAdapter();
            this.receiptBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hCooperativeDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.servicesTableAdapter1 = new CooperativeProject.HCooperativeDataSetTableAdapters.ServicesTableAdapter();
            this.appartmentServicesTableAdapter1 = new CooperativeProject.HCooperativeDataSetTableAdapters.AppartmentServicesTableAdapter();
            this.meter_readingTableAdapter1 = new CooperativeProject.HCooperativeDataSetTableAdapters.Meter_readingTableAdapter();
            this.hCooperativeDataSet1 = new CooperativeProject.HCooperativeDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.appartmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hCooperativeDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hCooperativeDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.receiptBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hCooperativeDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hCooperativeDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(68, 502);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(258, 54);
            this.button1.TabIndex = 0;
            this.button1.Text = "Оплатити";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(267, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(452, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "label3";
            // 
            // appartmentBindingSource
            // 
            this.appartmentBindingSource.DataMember = "Appartment";
            this.appartmentBindingSource.DataSource = this.hCooperativeDataSetBindingSource;
            // 
            // hCooperativeDataSetBindingSource
            // 
            this.hCooperativeDataSetBindingSource.DataSource = this.hCooperativeDataSet;
            this.hCooperativeDataSetBindingSource.Position = 0;
            // 
            // hCooperativeDataSet
            // 
            this.hCooperativeDataSet.DataSetName = "HCooperativeDataSet";
            this.hCooperativeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(694, 35);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(68, 390);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(698, 98);
            this.textBox1.TabIndex = 11;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(68, 111);
            this.listBox1.Margin = new System.Windows.Forms.Padding(15);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(698, 186);
            this.listBox1.TabIndex = 12;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Enabled = false;
            this.checkBox1.Location = new System.Drawing.Point(784, 111);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(60, 17);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "Статус";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(662, 322);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(613, 322);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Борг:";
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(526, 502);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(240, 54);
            this.button2.TabIndex = 22;
            this.button2.Text = "Друк";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printPreviewDialog2
            // 
            this.printPreviewDialog2.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog2.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog2.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog2.Enabled = true;
            this.printPreviewDialog2.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog2.Icon")));
            this.printPreviewDialog2.Name = "printPreviewDialog2";
            this.printPreviewDialog2.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 322);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Переплата:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(143, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Вулиця:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(177, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Номер будинку:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(352, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Номер квартири:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Location = new System.Drawing.Point(-2, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(915, 95);
            this.panel1.TabIndex = 28;
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(0, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(37, 34);
            this.button3.TabIndex = 31;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(75, 365);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "Введіть суму для оплати:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(884, 554);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 13);
            this.label12.TabIndex = 30;
            this.label12.Visible = false;
            // 
            // paymentTableAdapter1
            // 
            this.paymentTableAdapter1.ClearBeforeFill = true;
            // 
            // receiptTableAdapter
            // 
            this.receiptTableAdapter.ClearBeforeFill = true;
            // 
            // appartmentTableAdapter
            // 
            this.appartmentTableAdapter.ClearBeforeFill = true;
            // 
            // receiptBindingSource
            // 
            this.receiptBindingSource.DataMember = "Receipt";
            this.receiptBindingSource.DataSource = this.hCooperativeDataSet;
            // 
            // hCooperativeDataSetBindingSource1
            // 
            this.hCooperativeDataSetBindingSource1.DataSource = this.hCooperativeDataSet;
            this.hCooperativeDataSetBindingSource1.Position = 0;
            // 
            // servicesTableAdapter1
            // 
            this.servicesTableAdapter1.ClearBeforeFill = true;
            // 
            // appartmentServicesTableAdapter1
            // 
            this.appartmentServicesTableAdapter1.ClearBeforeFill = true;
            // 
            // meter_readingTableAdapter1
            // 
            this.meter_readingTableAdapter1.ClearBeforeFill = true;
            // 
            // hCooperativeDataSet1
            // 
            this.hCooperativeDataSet1.DataSetName = "HCooperativeDataSet";
            this.hCooperativeDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(898, 576);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Payment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.Payment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.appartmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hCooperativeDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hCooperativeDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.receiptBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hCooperativeDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hCooperativeDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private HCooperativeDataSetTableAdapters.PaymentTableAdapter paymentTableAdapter1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource hCooperativeDataSetBindingSource;
        private HCooperativeDataSet hCooperativeDataSet;
        private System.Windows.Forms.BindingSource receiptBindingSource;
        private HCooperativeDataSetTableAdapters.ReceiptTableAdapter receiptTableAdapter;
        private System.Windows.Forms.BindingSource appartmentBindingSource;
        private HCooperativeDataSetTableAdapters.AppartmentTableAdapter appartmentTableAdapter;
        private System.Windows.Forms.BindingSource hCooperativeDataSetBindingSource1;
        private HCooperativeDataSetTableAdapters.ServicesTableAdapter servicesTableAdapter1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button2;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private HCooperativeDataSetTableAdapters.AppartmentServicesTableAdapter appartmentServicesTableAdapter1;
        private HCooperativeDataSetTableAdapters.Meter_readingTableAdapter meter_readingTableAdapter1;
        private HCooperativeDataSet hCooperativeDataSet1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button3;
    }
}