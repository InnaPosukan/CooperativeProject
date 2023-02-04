namespace CooperativeProject
{
    partial class TextBox1
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
            System.Windows.Forms.Label type_servicesLabel;
            System.Windows.Forms.Label value_tariffLabel;
            System.Windows.Forms.Label start_dateLabel;
            System.Windows.Forms.Label bottom_boundLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextBox1));
            this.servicesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hCooperativeDataSet = new CooperativeProject.HCooperativeDataSet();
            this.tariffBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.type_servicesTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tariffDataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.value_tariffTextBox = new System.Windows.Forms.TextBox();
            this.start_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.bottom_boundTextBox = new System.Windows.Forms.TextBox();
            this.servicesTableAdapter = new CooperativeProject.HCooperativeDataSetTableAdapters.ServicesTableAdapter();
            this.tariffTableAdapter = new CooperativeProject.HCooperativeDataSetTableAdapters.TariffTableAdapter();
            this.tableAdapterManager = new CooperativeProject.HCooperativeDataSetTableAdapters.TableAdapterManager();
            this.meter_readingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.meter_readingTableAdapter = new CooperativeProject.HCooperativeDataSetTableAdapters.Meter_readingTableAdapter();
            this.button5 = new System.Windows.Forms.Button();
            type_servicesLabel = new System.Windows.Forms.Label();
            value_tariffLabel = new System.Windows.Forms.Label();
            start_dateLabel = new System.Windows.Forms.Label();
            bottom_boundLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.servicesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hCooperativeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tariffBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tariffDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meter_readingBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // type_servicesLabel
            // 
            type_servicesLabel.AutoSize = true;
            type_servicesLabel.Location = new System.Drawing.Point(70, 73);
            type_servicesLabel.Name = "type_servicesLabel";
            type_servicesLabel.Size = new System.Drawing.Size(72, 13);
            type_servicesLabel.TabIndex = 4;
            type_servicesLabel.Text = "Тип послуги:";
            // 
            // value_tariffLabel
            // 
            value_tariffLabel.AutoSize = true;
            value_tariffLabel.Location = new System.Drawing.Point(45, 113);
            value_tariffLabel.Name = "value_tariffLabel";
            value_tariffLabel.Size = new System.Drawing.Size(97, 13);
            value_tariffLabel.TabIndex = 26;
            value_tariffLabel.Text = "Значення тарифу:";
            // 
            // start_dateLabel
            // 
            start_dateLabel.AutoSize = true;
            start_dateLabel.Location = new System.Drawing.Point(11, 154);
            start_dateLabel.Name = "start_dateLabel";
            start_dateLabel.Size = new System.Drawing.Size(131, 13);
            start_dateLabel.TabIndex = 28;
            start_dateLabel.Text = "Дата початку дії тарифу:";
            // 
            // bottom_boundLabel
            // 
            bottom_boundLabel.AutoSize = true;
            bottom_boundLabel.Location = new System.Drawing.Point(15, 195);
            bottom_boundLabel.Name = "bottom_boundLabel";
            bottom_boundLabel.Size = new System.Drawing.Size(127, 13);
            bottom_boundLabel.TabIndex = 30;
            bottom_boundLabel.Text = "Нижня границя тарифу:";
            bottom_boundLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // servicesDataGridView
            // 
            this.servicesDataGridView.AutoGenerateColumns = false;
            this.servicesDataGridView.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.servicesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.servicesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.servicesDataGridView.DataSource = this.servicesBindingSource;
            this.servicesDataGridView.GridColor = System.Drawing.SystemColors.Control;
            this.servicesDataGridView.Location = new System.Drawing.Point(387, 60);
            this.servicesDataGridView.Name = "servicesDataGridView";
            this.servicesDataGridView.Size = new System.Drawing.Size(444, 229);
            this.servicesDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_services";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_services";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Type_services";
            this.dataGridViewTextBoxColumn2.HeaderText = "Type_services";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // servicesBindingSource
            // 
            this.servicesBindingSource.DataMember = "Services";
            this.servicesBindingSource.DataSource = this.hCooperativeDataSet;
            // 
            // hCooperativeDataSet
            // 
            this.hCooperativeDataSet.DataSetName = "HCooperativeDataSet";
            this.hCooperativeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tariffBindingSource1
            // 
            this.tariffBindingSource1.DataMember = "FK__Tariff__id_Servi__31EC6D26";
            this.tariffBindingSource1.DataSource = this.servicesBindingSource;
            // 
            // type_servicesTextBox
            // 
            this.type_servicesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.servicesBindingSource, "Type_services", true));
            this.type_servicesTextBox.Location = new System.Drawing.Point(148, 70);
            this.type_servicesTextBox.Name = "type_servicesTextBox";
            this.type_servicesTextBox.Size = new System.Drawing.Size(200, 20);
            this.type_servicesTextBox.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(18, 291);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 33);
            this.button1.TabIndex = 14;
            this.button1.Text = "Додати";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.Location = new System.Drawing.Point(781, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 49);
            this.button2.TabIndex = 15;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(128, 291);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(93, 33);
            this.button3.TabIndex = 16;
            this.button3.Text = "Видалити";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button4.Location = new System.Drawing.Point(239, 291);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(87, 33);
            this.button4.TabIndex = 17;
            this.button4.Text = "Оновити";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // tariffDataGridView1
            // 
            this.tariffDataGridView1.AutoGenerateColumns = false;
            this.tariffDataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tariffDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tariffDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.tariffDataGridView1.DataSource = this.tariffBindingSource1;
            this.tariffDataGridView1.Location = new System.Drawing.Point(387, 315);
            this.tariffDataGridView1.Name = "tariffDataGridView1";
            this.tariffDataGridView1.Size = new System.Drawing.Size(444, 221);
            this.tariffDataGridView1.TabIndex = 24;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "id_tariff";
            this.dataGridViewTextBoxColumn8.HeaderText = "id_tariff";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "value_tariff";
            this.dataGridViewTextBoxColumn9.HeaderText = "value_tariff";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "start_date";
            this.dataGridViewTextBoxColumn10.HeaderText = "start_date";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "bottom_bound";
            this.dataGridViewTextBoxColumn11.HeaderText = "bottom_bound";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "id_Services";
            this.dataGridViewTextBoxColumn12.HeaderText = "id_Services";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // value_tariffTextBox
            // 
            this.value_tariffTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tariffBindingSource1, "value_tariff", true));
            this.value_tariffTextBox.Location = new System.Drawing.Point(148, 113);
            this.value_tariffTextBox.Name = "value_tariffTextBox";
            this.value_tariffTextBox.Size = new System.Drawing.Size(200, 20);
            this.value_tariffTextBox.TabIndex = 27;
            // 
            // start_dateDateTimePicker
            // 
            this.start_dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tariffBindingSource1, "start_date", true));
            this.start_dateDateTimePicker.Location = new System.Drawing.Point(148, 148);
            this.start_dateDateTimePicker.Name = "start_dateDateTimePicker";
            this.start_dateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.start_dateDateTimePicker.TabIndex = 29;
            // 
            // bottom_boundTextBox
            // 
            this.bottom_boundTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tariffBindingSource1, "bottom_bound", true));
            this.bottom_boundTextBox.Location = new System.Drawing.Point(148, 188);
            this.bottom_boundTextBox.Name = "bottom_boundTextBox";
            this.bottom_boundTextBox.Size = new System.Drawing.Size(200, 20);
            this.bottom_boundTextBox.TabIndex = 31;
            // 
            // servicesTableAdapter
            // 
            this.servicesTableAdapter.ClearBeforeFill = true;
            // 
            // tariffTableAdapter
            // 
            this.tariffTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AppartmentTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.HolderTableAdapter = null;
            this.tableAdapterManager.Meter_readingTableAdapter = null;
            this.tableAdapterManager.PaymentTableAdapter = null;
            this.tableAdapterManager.ReceiptPaymentTableAdapter = null;
            this.tableAdapterManager.ReceiptTableAdapter = null;
            this.tableAdapterManager.ServicesTableAdapter = this.servicesTableAdapter;
            this.tableAdapterManager.TariffTableAdapter = this.tariffTableAdapter;
            this.tableAdapterManager.UpdateOrder = CooperativeProject.HCooperativeDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // meter_readingBindingSource
            // 
            this.meter_readingBindingSource.DataMember = "Meter_reading";
            this.meter_readingBindingSource.DataSource = this.hCooperativeDataSet;
            // 
            // meter_readingTableAdapter
            // 
            this.meter_readingTableAdapter.ClearBeforeFill = true;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.Location = new System.Drawing.Point(12, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(36, 34);
            this.button5.TabIndex = 32;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // TextBox1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(843, 570);
            this.Controls.Add(this.button5);
            this.Controls.Add(value_tariffLabel);
            this.Controls.Add(this.value_tariffTextBox);
            this.Controls.Add(start_dateLabel);
            this.Controls.Add(this.start_dateDateTimePicker);
            this.Controls.Add(bottom_boundLabel);
            this.Controls.Add(this.bottom_boundTextBox);
            this.Controls.Add(this.tariffDataGridView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(type_servicesLabel);
            this.Controls.Add(this.type_servicesTextBox);
            this.Controls.Add(this.servicesDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TextBox1";
            this.Text = "Послуги";
            this.Load += new System.EventHandler(this.Services_Load);
            ((System.ComponentModel.ISupportInitialize)(this.servicesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hCooperativeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tariffBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tariffDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meter_readingBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private HCooperativeDataSet hCooperativeDataSet;
        private System.Windows.Forms.BindingSource servicesBindingSource;
        private HCooperativeDataSetTableAdapters.ServicesTableAdapter servicesTableAdapter;
        private HCooperativeDataSetTableAdapters.TariffTableAdapter tariffTableAdapter;
        private HCooperativeDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource meter_readingBindingSource;
        private HCooperativeDataSetTableAdapters.Meter_readingTableAdapter meter_readingTableAdapter;
        private System.Windows.Forms.DataGridView servicesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.TextBox type_servicesTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.BindingSource tariffBindingSource1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView tariffDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.TextBox value_tariffTextBox;
        private System.Windows.Forms.DateTimePicker start_dateDateTimePicker;
        private System.Windows.Forms.TextBox bottom_boundTextBox;
        private System.Windows.Forms.Button button5;
    }
}