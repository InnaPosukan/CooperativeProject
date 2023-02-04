namespace CooperativeProject
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.hCooperativeDataSet = new CooperativeProject.HCooperativeDataSet();
            this.holderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.holderTableAdapter = new CooperativeProject.HCooperativeDataSetTableAdapters.HolderTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.hCooperativeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.holderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(752, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(184, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(364, 38);
            this.button1.TabIndex = 1;
            this.button1.Text = "Послуги";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // hCooperativeDataSet
            // 
            this.hCooperativeDataSet.DataSetName = "HCooperativeDataSet";
            this.hCooperativeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(184, 85);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(364, 38);
            this.button2.TabIndex = 2;
            this.button2.Text = "Додавання нових квартир";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(184, 173);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(364, 42);
            this.button3.TabIndex = 3;
            this.button3.Text = "Інформація про боржників";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button4.Location = new System.Drawing.Point(184, 269);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(364, 42);
            this.button4.TabIndex = 4;
            this.button4.Text = "Споживання";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button5.Location = new System.Drawing.Point(184, 221);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(364, 42);
            this.button5.TabIndex = 5;
            this.button5.Text = "Інформація про переплату";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button6.Location = new System.Drawing.Point(184, 317);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(364, 42);
            this.button6.TabIndex = 6;
            this.button6.Text = "Суми за оплати";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(683, 442);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hCooperativeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.holderBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private HCooperativeDataSet hCooperativeDataSet;
        private System.Windows.Forms.BindingSource holderBindingSource;
        private HCooperativeDataSetTableAdapters.HolderTableAdapter holderTableAdapter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}