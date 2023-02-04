namespace CooperativeProject
{
    partial class InfoClient
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
            System.Windows.Forms.Label initialLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label dateOfBirthLabel;
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label areaLabel;
            System.Windows.Forms.Label streetLabel;
            System.Windows.Forms.Label house_NumLabel;
            System.Windows.Forms.Label appartment_NumLabel;
            System.Windows.Forms.Label inhabitants_NumLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoClient));
            this.hCooperativeDataSet = new CooperativeProject.HCooperativeDataSet();
            this.appartmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appartmentTableAdapter = new CooperativeProject.HCooperativeDataSetTableAdapters.AppartmentTableAdapter();
            this.holderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.holderTableAdapter = new CooperativeProject.HCooperativeDataSetTableAdapters.HolderTableAdapter();
            this.tableAdapterManager = new CooperativeProject.HCooperativeDataSetTableAdapters.TableAdapterManager();
            this.holderDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.appartmentServicesTableAdapter1 = new CooperativeProject.HCooperativeDataSetTableAdapters.AppartmentServicesTableAdapter();
            this.meter_readingTableAdapter1 = new CooperativeProject.HCooperativeDataSetTableAdapters.Meter_readingTableAdapter();
            this.appartmentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.appartmentDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.initialTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.dateOfBirthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.areaTextBox = new System.Windows.Forms.TextBox();
            this.streetTextBox = new System.Windows.Forms.TextBox();
            this.house_NumTextBox = new System.Windows.Forms.TextBox();
            this.appartment_NumTextBox = new System.Windows.Forms.TextBox();
            this.inhabitants_NumTextBox = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            initialLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            dateOfBirthLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            areaLabel = new System.Windows.Forms.Label();
            streetLabel = new System.Windows.Forms.Label();
            house_NumLabel = new System.Windows.Forms.Label();
            appartment_NumLabel = new System.Windows.Forms.Label();
            inhabitants_NumLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hCooperativeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appartmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.holderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.holderDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appartmentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appartmentDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // initialLabel
            // 
            initialLabel.AutoSize = true;
            initialLabel.Location = new System.Drawing.Point(78, 87);
            initialLabel.Name = "initialLabel";
            initialLabel.Size = new System.Drawing.Size(28, 13);
            initialLabel.TabIndex = 38;
            initialLabel.Text = "ПІБ:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(57, 113);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(55, 13);
            phoneLabel.TabIndex = 40;
            phoneLabel.Text = "Телефон:";
            // 
            // dateOfBirthLabel
            // 
            dateOfBirthLabel.AutoSize = true;
            dateOfBirthLabel.Location = new System.Drawing.Point(12, 136);
            dateOfBirthLabel.Name = "dateOfBirthLabel";
            dateOfBirthLabel.Size = new System.Drawing.Size(101, 13);
            dateOfBirthLabel.TabIndex = 42;
            dateOfBirthLabel.Text = "Дата народження:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(64, 164);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(48, 13);
            passwordLabel.TabIndex = 45;
            passwordLabel.Text = "Пароль:";
            // 
            // areaLabel
            // 
            areaLabel.AutoSize = true;
            areaLabel.Location = new System.Drawing.Point(64, 192);
            areaLabel.Name = "areaLabel";
            areaLabel.Size = new System.Drawing.Size(45, 13);
            areaLabel.TabIndex = 47;
            areaLabel.Text = "Площа:";
            // 
            // streetLabel
            // 
            streetLabel.AutoSize = true;
            streetLabel.Location = new System.Drawing.Point(63, 224);
            streetLabel.Name = "streetLabel";
            streetLabel.Size = new System.Drawing.Size(46, 13);
            streetLabel.TabIndex = 49;
            streetLabel.Text = "Вулиця:";
            // 
            // house_NumLabel
            // 
            house_NumLabel.AutoSize = true;
            house_NumLabel.Location = new System.Drawing.Point(26, 258);
            house_NumLabel.Name = "house_NumLabel";
            house_NumLabel.Size = new System.Drawing.Size(87, 13);
            house_NumLabel.TabIndex = 51;
            house_NumLabel.Text = "Номер будинку:";
            // 
            // appartment_NumLabel
            // 
            appartment_NumLabel.AutoSize = true;
            appartment_NumLabel.Location = new System.Drawing.Point(26, 284);
            appartment_NumLabel.Name = "appartment_NumLabel";
            appartment_NumLabel.Size = new System.Drawing.Size(94, 13);
            appartment_NumLabel.TabIndex = 53;
            appartment_NumLabel.Text = "Номер квартири:";
            // 
            // inhabitants_NumLabel
            // 
            inhabitants_NumLabel.AutoSize = true;
            inhabitants_NumLabel.Location = new System.Drawing.Point(22, 313);
            inhabitants_NumLabel.Name = "inhabitants_NumLabel";
            inhabitants_NumLabel.Size = new System.Drawing.Size(98, 13);
            inhabitants_NumLabel.TabIndex = 55;
            inhabitants_NumLabel.Text = "Кількість жителів:";
            // 
            // hCooperativeDataSet
            // 
            this.hCooperativeDataSet.DataSetName = "HCooperativeDataSet";
            this.hCooperativeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // appartmentBindingSource
            // 
            this.appartmentBindingSource.DataMember = "Appartment";
            this.appartmentBindingSource.DataSource = this.hCooperativeDataSet;
            // 
            // appartmentTableAdapter
            // 
            this.appartmentTableAdapter.ClearBeforeFill = true;
            // 
            // holderBindingSource
            // 
            this.holderBindingSource.DataMember = "Holder";
            this.holderBindingSource.DataSource = this.hCooperativeDataSet;
            // 
            // holderTableAdapter
            // 
            this.holderTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AppartmentTableAdapter = this.appartmentTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.HolderTableAdapter = this.holderTableAdapter;
            this.tableAdapterManager.Meter_readingTableAdapter = null;
            this.tableAdapterManager.PaymentTableAdapter = null;
            this.tableAdapterManager.ReceiptPaymentTableAdapter = null;
            this.tableAdapterManager.ReceiptTableAdapter = null;
            this.tableAdapterManager.ServicesTableAdapter = null;
            this.tableAdapterManager.TariffTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CooperativeProject.HCooperativeDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // holderDataGridView
            // 
            this.holderDataGridView.AutoGenerateColumns = false;
            this.holderDataGridView.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.holderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.holderDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.holderDataGridView.DataSource = this.holderBindingSource;
            this.holderDataGridView.GridColor = System.Drawing.Color.AliceBlue;
            this.holderDataGridView.Location = new System.Drawing.Point(404, 37);
            this.holderDataGridView.Name = "holderDataGridView";
            this.holderDataGridView.Size = new System.Drawing.Size(444, 215);
            this.holderDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "id_holder";
            this.dataGridViewTextBoxColumn9.HeaderText = "id_holder";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Initial";
            this.dataGridViewTextBoxColumn10.HeaderText = "Initial";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Phone";
            this.dataGridViewTextBoxColumn11.HeaderText = "Phone";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "DateOfBirth";
            this.dataGridViewTextBoxColumn12.HeaderText = "DateOfBirth";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(95, 472);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(221, 34);
            this.button1.TabIndex = 13;
            this.button1.Text = "Додати";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(95, 392);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(221, 34);
            this.button2.TabIndex = 34;
            this.button2.Text = "Видалити";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(95, 432);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(221, 34);
            this.button3.TabIndex = 35;
            this.button3.Text = "Оновити дані";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button4.Location = new System.Drawing.Point(12, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(48, 49);
            this.button4.TabIndex = 36;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // appartmentServicesTableAdapter1
            // 
            this.appartmentServicesTableAdapter1.ClearBeforeFill = true;
            // 
            // meter_readingTableAdapter1
            // 
            this.meter_readingTableAdapter1.ClearBeforeFill = true;
            // 
            // appartmentBindingSource1
            // 
            this.appartmentBindingSource1.DataMember = "FK__Appartmen__id_ho__267ABA7A";
            this.appartmentBindingSource1.DataSource = this.holderBindingSource;
            // 
            // appartmentDataGridView
            // 
            this.appartmentDataGridView.AutoGenerateColumns = false;
            this.appartmentDataGridView.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.appartmentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.appartmentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.appartmentDataGridView.DataSource = this.appartmentBindingSource1;
            this.appartmentDataGridView.GridColor = System.Drawing.Color.AliceBlue;
            this.appartmentDataGridView.Location = new System.Drawing.Point(404, 275);
            this.appartmentDataGridView.Name = "appartmentDataGridView";
            this.appartmentDataGridView.Size = new System.Drawing.Size(444, 241);
            this.appartmentDataGridView.TabIndex = 36;
            this.appartmentDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.appartmentDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_appartment";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_appartment";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Password";
            this.dataGridViewTextBoxColumn2.HeaderText = "Password";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Area";
            this.dataGridViewTextBoxColumn3.HeaderText = "Area";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Street";
            this.dataGridViewTextBoxColumn4.HeaderText = "Street";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "House_Num";
            this.dataGridViewTextBoxColumn5.HeaderText = "House_Num";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Appartment_Num";
            this.dataGridViewTextBoxColumn6.HeaderText = "Appartment_Num";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Inhabitants_Num";
            this.dataGridViewTextBoxColumn7.HeaderText = "Inhabitants_Num";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "id_holder";
            this.dataGridViewTextBoxColumn8.HeaderText = "id_holder";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // initialTextBox
            // 
            this.initialTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.holderBindingSource, "Initial", true));
            this.initialTextBox.Location = new System.Drawing.Point(155, 84);
            this.initialTextBox.Name = "initialTextBox";
            this.initialTextBox.Size = new System.Drawing.Size(200, 20);
            this.initialTextBox.TabIndex = 39;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.holderBindingSource, "Phone", true));
            this.phoneTextBox.Location = new System.Drawing.Point(155, 110);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(200, 20);
            this.phoneTextBox.TabIndex = 41;
            // 
            // dateOfBirthDateTimePicker
            // 
            this.dateOfBirthDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.holderBindingSource, "DateOfBirth", true));
            this.dateOfBirthDateTimePicker.Location = new System.Drawing.Point(155, 136);
            this.dateOfBirthDateTimePicker.Name = "dateOfBirthDateTimePicker";
            this.dateOfBirthDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateOfBirthDateTimePicker.TabIndex = 43;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.appartmentBindingSource1, "Password", true));
            this.passwordTextBox.Location = new System.Drawing.Point(155, 161);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(100, 20);
            this.passwordTextBox.TabIndex = 46;
            // 
            // areaTextBox
            // 
            this.areaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.appartmentBindingSource1, "Area", true));
            this.areaTextBox.Location = new System.Drawing.Point(155, 192);
            this.areaTextBox.Name = "areaTextBox";
            this.areaTextBox.Size = new System.Drawing.Size(100, 20);
            this.areaTextBox.TabIndex = 48;
            // 
            // streetTextBox
            // 
            this.streetTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.appartmentBindingSource1, "Street", true));
            this.streetTextBox.Location = new System.Drawing.Point(155, 224);
            this.streetTextBox.Name = "streetTextBox";
            this.streetTextBox.Size = new System.Drawing.Size(100, 20);
            this.streetTextBox.TabIndex = 50;
            // 
            // house_NumTextBox
            // 
            this.house_NumTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.appartmentBindingSource1, "House_Num", true));
            this.house_NumTextBox.Location = new System.Drawing.Point(155, 255);
            this.house_NumTextBox.Name = "house_NumTextBox";
            this.house_NumTextBox.Size = new System.Drawing.Size(100, 20);
            this.house_NumTextBox.TabIndex = 52;
            // 
            // appartment_NumTextBox
            // 
            this.appartment_NumTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.appartmentBindingSource1, "Appartment_Num", true));
            this.appartment_NumTextBox.Location = new System.Drawing.Point(155, 284);
            this.appartment_NumTextBox.Name = "appartment_NumTextBox";
            this.appartment_NumTextBox.Size = new System.Drawing.Size(100, 20);
            this.appartment_NumTextBox.TabIndex = 54;
            // 
            // inhabitants_NumTextBox
            // 
            this.inhabitants_NumTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.appartmentBindingSource1, "Inhabitants_Num", true));
            this.inhabitants_NumTextBox.Location = new System.Drawing.Point(155, 313);
            this.inhabitants_NumTextBox.Name = "inhabitants_NumTextBox";
            this.inhabitants_NumTextBox.Size = new System.Drawing.Size(100, 20);
            this.inhabitants_NumTextBox.TabIndex = 56;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.Location = new System.Drawing.Point(66, 19);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(36, 34);
            this.button5.TabIndex = 57;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // InfoClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(870, 549);
            this.Controls.Add(this.button5);
            this.Controls.Add(passwordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(areaLabel);
            this.Controls.Add(this.areaTextBox);
            this.Controls.Add(streetLabel);
            this.Controls.Add(this.streetTextBox);
            this.Controls.Add(house_NumLabel);
            this.Controls.Add(this.house_NumTextBox);
            this.Controls.Add(appartment_NumLabel);
            this.Controls.Add(this.appartment_NumTextBox);
            this.Controls.Add(inhabitants_NumLabel);
            this.Controls.Add(this.inhabitants_NumTextBox);
            this.Controls.Add(initialLabel);
            this.Controls.Add(this.initialTextBox);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(dateOfBirthLabel);
            this.Controls.Add(this.dateOfBirthDateTimePicker);
            this.Controls.Add(this.appartmentDataGridView);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.holderDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "InfoClient";
            this.Text = "InfoClient";
            this.Load += new System.EventHandler(this.InfoClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hCooperativeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appartmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.holderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.holderDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appartmentBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appartmentDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private HCooperativeDataSet hCooperativeDataSet;
        private System.Windows.Forms.BindingSource appartmentBindingSource;
        private HCooperativeDataSetTableAdapters.AppartmentTableAdapter appartmentTableAdapter;
        private System.Windows.Forms.BindingSource holderBindingSource;
        private HCooperativeDataSetTableAdapters.HolderTableAdapter holderTableAdapter;
        private HCooperativeDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView holderDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private HCooperativeDataSetTableAdapters.AppartmentServicesTableAdapter appartmentServicesTableAdapter1;
        private HCooperativeDataSetTableAdapters.Meter_readingTableAdapter meter_readingTableAdapter1;
        private System.Windows.Forms.BindingSource appartmentBindingSource1;
        private System.Windows.Forms.DataGridView appartmentDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.TextBox initialTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.DateTimePicker dateOfBirthDateTimePicker;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox areaTextBox;
        private System.Windows.Forms.TextBox streetTextBox;
        private System.Windows.Forms.TextBox house_NumTextBox;
        private System.Windows.Forms.TextBox appartment_NumTextBox;
        private System.Windows.Forms.TextBox inhabitants_NumTextBox;
        private System.Windows.Forms.Button button5;
    }
}