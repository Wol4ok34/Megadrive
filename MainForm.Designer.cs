namespace Мегадрайф
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.demoEX_BalandinDataSet = new Мегадрайф.DemoEX_BalandinDataSet();
            this.noAuthorizationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.noAuthorizationTableAdapter = new Мегадрайф.DemoEX_BalandinDataSetTableAdapters.NoAuthorizationTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.typenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transportcolorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transportmodelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transportnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transportenabledDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentpointlocationaddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoEX_BalandinDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noAuthorizationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(37)))), ((int)(((byte)(181)))));
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Gabriola", 9.75F);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 16, 2, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(744, 122);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Компания «Мегадрайв» ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.typenameDataGridViewTextBoxColumn,
            this.transportcolorDataGridViewTextBoxColumn,
            this.transportmodelDataGridViewTextBoxColumn,
            this.transportnumberDataGridViewTextBoxColumn,
            this.transportenabledDataGridViewTextBoxColumn,
            this.currentpointlocationaddressDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.noAuthorizationBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 122);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(744, 384);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // demoEX_BalandinDataSet
            // 
            this.demoEX_BalandinDataSet.DataSetName = "DemoEX_BalandinDataSet";
            this.demoEX_BalandinDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // noAuthorizationBindingSource
            // 
            this.noAuthorizationBindingSource.DataMember = "NoAuthorization";
            this.noAuthorizationBindingSource.DataSource = this.demoEX_BalandinDataSet;
            // 
            // noAuthorizationTableAdapter
            // 
            this.noAuthorizationTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(192)))), ((int)(((byte)(190)))));
            this.button1.Location = new System.Drawing.Point(204, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 49);
            this.button1.TabIndex = 2;
            this.button1.Text = "Администратор";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(192)))), ((int)(((byte)(190)))));
            this.button2.Location = new System.Drawing.Point(365, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 49);
            this.button2.TabIndex = 3;
            this.button2.Text = "Менеджер";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Все",
            "Доступные тр. средства",
            "Недоступные тр. средства"});
            this.comboBox1.Location = new System.Drawing.Point(474, 85);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 31);
            this.comboBox1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Поиск";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(55, 82);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 30);
            this.textBox1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = global::Мегадрайф.Properties.Resources.логотип;
            this.pictureBox1.Location = new System.Drawing.Point(638, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 16, 2, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(106, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // typenameDataGridViewTextBoxColumn
            // 
            this.typenameDataGridViewTextBoxColumn.DataPropertyName = "type_name";
            this.typenameDataGridViewTextBoxColumn.HeaderText = "Тип ";
            this.typenameDataGridViewTextBoxColumn.Name = "typenameDataGridViewTextBoxColumn";
            // 
            // transportcolorDataGridViewTextBoxColumn
            // 
            this.transportcolorDataGridViewTextBoxColumn.DataPropertyName = "transport_color";
            this.transportcolorDataGridViewTextBoxColumn.HeaderText = "Цвет";
            this.transportcolorDataGridViewTextBoxColumn.Name = "transportcolorDataGridViewTextBoxColumn";
            // 
            // transportmodelDataGridViewTextBoxColumn
            // 
            this.transportmodelDataGridViewTextBoxColumn.DataPropertyName = "transport_model";
            this.transportmodelDataGridViewTextBoxColumn.HeaderText = "Модель";
            this.transportmodelDataGridViewTextBoxColumn.Name = "transportmodelDataGridViewTextBoxColumn";
            // 
            // transportnumberDataGridViewTextBoxColumn
            // 
            this.transportnumberDataGridViewTextBoxColumn.DataPropertyName = "transport_number";
            this.transportnumberDataGridViewTextBoxColumn.HeaderText = "Номер автомобиля";
            this.transportnumberDataGridViewTextBoxColumn.Name = "transportnumberDataGridViewTextBoxColumn";
            // 
            // transportenabledDataGridViewTextBoxColumn
            // 
            this.transportenabledDataGridViewTextBoxColumn.DataPropertyName = "transport_enabled";
            this.transportenabledDataGridViewTextBoxColumn.HeaderText = "Наличие";
            this.transportenabledDataGridViewTextBoxColumn.Name = "transportenabledDataGridViewTextBoxColumn";
            // 
            // currentpointlocationaddressDataGridViewTextBoxColumn
            // 
            this.currentpointlocationaddressDataGridViewTextBoxColumn.DataPropertyName = "current_point_location_address";
            this.currentpointlocationaddressDataGridViewTextBoxColumn.HeaderText = "Местонахождение";
            this.currentpointlocationaddressDataGridViewTextBoxColumn.Name = "currentpointlocationaddressDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 506);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Gabriola", 9.75F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoEX_BalandinDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noAuthorizationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DemoEX_BalandinDataSet demoEX_BalandinDataSet;
        private System.Windows.Forms.BindingSource noAuthorizationBindingSource;
        private DemoEX_BalandinDataSetTableAdapters.NoAuthorizationTableAdapter noAuthorizationTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn typenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transportcolorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transportmodelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transportnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transportenabledDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentpointlocationaddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
    }
}