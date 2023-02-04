namespace CooperativeProject
{
    partial class UserForm
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
            System.Windows.Forms.Label label2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.appartmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hCooperativeDataSet1 = new CooperativeProject.HCooperativeDataSet();
            this.meter_readingTableAdapter1 = new CooperativeProject.HCooperativeDataSetTableAdapters.Meter_readingTableAdapter();
            this.appartmentServicesTableAdapter1 = new CooperativeProject.HCooperativeDataSetTableAdapters.AppartmentServicesTableAdapter();
            this.appartmentTableAdapter = new CooperativeProject.HCooperativeDataSetTableAdapters.AppartmentTableAdapter();
            this.servicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.servicesTableAdapter = new CooperativeProject.HCooperativeDataSetTableAdapters.ServicesTableAdapter();
            this.appartmentServicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new CooperativeProject.HCooperativeDataSetTableAdapters.TableAdapterManager();
            this.type_servicesComboBox = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.idholderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inhabitantsNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appartmentNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.houseNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.streetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.areaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idappartmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.hCooperativeDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            type_servicesLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.appartmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hCooperativeDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appartmentServicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hCooperativeDataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // type_servicesLabel
            // 
            type_servicesLabel.AutoSize = true;
            type_servicesLabel.Location = new System.Drawing.Point(30, 87);
            type_servicesLabel.Name = "type_servicesLabel";
            type_servicesLabel.Size = new System.Drawing.Size(72, 13);
            type_servicesLabel.TabIndex = 12;
            type_servicesLabel.Text = "Вид послуги:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(298, 90);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(124, 13);
            label2.TabIndex = 15;
            label2.Text = "Показання лічильника:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(428, 84);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 21);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.GhostWhite;
            this.button1.Location = new System.Drawing.Point(681, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 25);
            this.button1.TabIndex = 7;
            this.button1.Text = "Передати";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.MenuBar;
            this.dateTimePicker1.Location = new System.Drawing.Point(652, 13);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(220, 20);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(176, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 26);
            this.label7.TabIndex = 11;
            this.label7.Text = "0";
            // 
            // appartmentBindingSource
            // 
            this.appartmentBindingSource.DataMember = "Appartment";
            this.appartmentBindingSource.DataSource = this.hCooperativeDataSet1;
            // 
            // hCooperativeDataSet1
            // 
            this.hCooperativeDataSet1.DataSetName = "HCooperativeDataSet";
            this.hCooperativeDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // meter_readingTableAdapter1
            // 
            this.meter_readingTableAdapter1.ClearBeforeFill = true;
            // 
            // appartmentServicesTableAdapter1
            // 
            this.appartmentServicesTableAdapter1.ClearBeforeFill = true;
            // 
            // appartmentTableAdapter
            // 
            this.appartmentTableAdapter.ClearBeforeFill = true;
            // 
            // servicesBindingSource
            // 
            this.servicesBindingSource.DataMember = "Services";
            this.servicesBindingSource.DataSource = this.hCooperativeDataSet1;
            // 
            // servicesTableAdapter
            // 
            this.servicesTableAdapter.ClearBeforeFill = true;
            // 
            // appartmentServicesBindingSource
            // 
            this.appartmentServicesBindingSource.DataMember = "AppartmentServices";
            this.appartmentServicesBindingSource.DataSource = this.hCooperativeDataSet1;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AppartmentTableAdapter = this.appartmentTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.HolderTableAdapter = null;
            this.tableAdapterManager.Meter_readingTableAdapter = this.meter_readingTableAdapter1;
            this.tableAdapterManager.PaymentTableAdapter = null;
            this.tableAdapterManager.ReceiptPaymentTableAdapter = null;
            this.tableAdapterManager.ReceiptTableAdapter = null;
            this.tableAdapterManager.ServicesTableAdapter = this.servicesTableAdapter;
            this.tableAdapterManager.TariffTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CooperativeProject.HCooperativeDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // type_servicesComboBox
            // 
            this.type_servicesComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.servicesBindingSource, "Type_services", true));
            this.type_servicesComboBox.DataSource = this.servicesBindingSource;
            this.type_servicesComboBox.DisplayMember = "Type_services";
            this.type_servicesComboBox.Location = new System.Drawing.Point(108, 84);
            this.type_servicesComboBox.Name = "type_servicesComboBox";
            this.type_servicesComboBox.Size = new System.Drawing.Size(121, 21);
            this.type_servicesComboBox.TabIndex = 13;
            this.type_servicesComboBox.ValueMember = "id_services";
            this.type_servicesComboBox.SelectedIndexChanged += new System.EventHandler(this.type_servicesComboBox_SelectedIndexChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(612, 452);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(252, 41);
            this.button3.TabIndex = 19;
            this.button3.Text = "Перейти до оплати";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // idholderDataGridViewTextBoxColumn
            // 
            this.idholderDataGridViewTextBoxColumn.DataPropertyName = "id_holder";
            this.idholderDataGridViewTextBoxColumn.HeaderText = "id_holder";
            this.idholderDataGridViewTextBoxColumn.Name = "idholderDataGridViewTextBoxColumn";
            // 
            // inhabitantsNumDataGridViewTextBoxColumn
            // 
            this.inhabitantsNumDataGridViewTextBoxColumn.DataPropertyName = "Inhabitants_Num";
            this.inhabitantsNumDataGridViewTextBoxColumn.HeaderText = "Inhabitants_Num";
            this.inhabitantsNumDataGridViewTextBoxColumn.Name = "inhabitantsNumDataGridViewTextBoxColumn";
            // 
            // appartmentNumDataGridViewTextBoxColumn
            // 
            this.appartmentNumDataGridViewTextBoxColumn.DataPropertyName = "Appartment_Num";
            this.appartmentNumDataGridViewTextBoxColumn.HeaderText = "Appartment_Num";
            this.appartmentNumDataGridViewTextBoxColumn.Name = "appartmentNumDataGridViewTextBoxColumn";
            // 
            // houseNumDataGridViewTextBoxColumn
            // 
            this.houseNumDataGridViewTextBoxColumn.DataPropertyName = "House_Num";
            this.houseNumDataGridViewTextBoxColumn.HeaderText = "House_Num";
            this.houseNumDataGridViewTextBoxColumn.Name = "houseNumDataGridViewTextBoxColumn";
            // 
            // streetDataGridViewTextBoxColumn
            // 
            this.streetDataGridViewTextBoxColumn.DataPropertyName = "Street";
            this.streetDataGridViewTextBoxColumn.HeaderText = "Street";
            this.streetDataGridViewTextBoxColumn.Name = "streetDataGridViewTextBoxColumn";
            // 
            // areaDataGridViewTextBoxColumn
            // 
            this.areaDataGridViewTextBoxColumn.DataPropertyName = "Area";
            this.areaDataGridViewTextBoxColumn.HeaderText = "Area";
            this.areaDataGridViewTextBoxColumn.Name = "areaDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // idappartmentDataGridViewTextBoxColumn
            // 
            this.idappartmentDataGridViewTextBoxColumn.DataPropertyName = "id_appartment";
            this.idappartmentDataGridViewTextBoxColumn.HeaderText = "id_appartment";
            this.idappartmentDataGridViewTextBoxColumn.Name = "idappartmentDataGridViewTextBoxColumn";
            this.idappartmentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idappartmentDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.areaDataGridViewTextBoxColumn,
            this.streetDataGridViewTextBoxColumn,
            this.houseNumDataGridViewTextBoxColumn,
            this.appartmentNumDataGridViewTextBoxColumn,
            this.inhabitantsNumDataGridViewTextBoxColumn,
            this.idholderDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.appartmentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(787, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(33, 14);
            this.dataGridView1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.AliceBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 19);
            this.label1.TabIndex = 20;
            this.label1.Text = "Ви ввійшли під квартирою: ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 55);
            this.panel1.TabIndex = 21;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(18, 128);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(856, 309);
            this.dataGridView2.TabIndex = 22;
            // 
            // hCooperativeDataSet1BindingSource
            // 
            this.hCooperativeDataSet1BindingSource.DataSource = this.hCooperativeDataSet1;
            this.hCooperativeDataSet1BindingSource.Position = 0;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(884, 505);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button3);
            this.Controls.Add(label2);
            this.Controls.Add(type_servicesLabel);
            this.Controls.Add(this.type_servicesComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "UserForm";
            this.Text = "UserFormcs";
            this.Load += new System.EventHandler(this.UserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.appartmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hCooperativeDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appartmentServicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hCooperativeDataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private HCooperativeDataSetTableAdapters.Meter_readingTableAdapter meter_readingTableAdapter1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private HCooperativeDataSet hCooperativeDataSet1;
        private HCooperativeDataSetTableAdapters.AppartmentServicesTableAdapter appartmentServicesTableAdapter1;
        private System.Windows.Forms.BindingSource appartmentBindingSource;
        private HCooperativeDataSetTableAdapters.AppartmentTableAdapter appartmentTableAdapter;
        private System.Windows.Forms.BindingSource servicesBindingSource;
        private HCooperativeDataSetTableAdapters.ServicesTableAdapter servicesTableAdapter;
        private System.Windows.Forms.BindingSource appartmentServicesBindingSource;
        private HCooperativeDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox type_servicesComboBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn idholderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inhabitantsNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn appartmentNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn houseNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn streetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn areaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idappartmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource hCooperativeDataSet1BindingSource;
    }
}