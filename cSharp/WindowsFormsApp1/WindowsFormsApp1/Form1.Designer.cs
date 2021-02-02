
namespace WindowsFormsApp1
{
    partial class Form1
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
            System.Windows.Forms.Label fullNameLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label genderLabel;
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label fullNameLabel1;
            System.Windows.Forms.Label emailLabel1;
            System.Windows.Forms.Label addressLabel1;
            System.Windows.Forms.Label phoneLabel1;
            System.Windows.Forms.Label genderLabel1;
            System.Windows.Forms.Label idLabel1;
            System.Windows.Forms.Label fullNameLabel2;
            System.Windows.Forms.Label emailLabel2;
            System.Windows.Forms.Label addressLabel2;
            System.Windows.Forms.Label phoneLabel2;
            System.Windows.Forms.Label genderLabel2;
            this.tb_num1 = new System.Windows.Forms.TextBox();
            this.tb_num2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_sum = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.databaseDataSet = new WindowsFormsApp1.DatabaseDataSet();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customersTableAdapter = new WindowsFormsApp1.DatabaseDataSetTableAdapters.CustomersTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableAdapterManager = new WindowsFormsApp1.DatabaseDataSetTableAdapters.TableAdapterManager();
            this.fullNameTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.fullNameTextBox1 = new System.Windows.Forms.TextBox();
            this.emailTextBox1 = new System.Windows.Forms.TextBox();
            this.addressTextBox1 = new System.Windows.Forms.TextBox();
            this.phoneTextBox1 = new System.Windows.Forms.TextBox();
            this.genderComboBox1 = new System.Windows.Forms.ComboBox();
            this.cn = new WindowsFormsApp1.cn();
            this.customersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.customersTableAdapter1 = new WindowsFormsApp1.cnTableAdapters.CustomersTableAdapter();
            this.tableAdapterManager1 = new WindowsFormsApp1.cnTableAdapters.TableAdapterManager();
            this.idTextBox1 = new System.Windows.Forms.TextBox();
            this.fullNameTextBox2 = new System.Windows.Forms.TextBox();
            this.emailTextBox2 = new System.Windows.Forms.TextBox();
            this.addressTextBox2 = new System.Windows.Forms.TextBox();
            this.phoneTextBox2 = new System.Windows.Forms.TextBox();
            this.genderTextBox = new System.Windows.Forms.TextBox();
            fullNameLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            genderLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            fullNameLabel1 = new System.Windows.Forms.Label();
            emailLabel1 = new System.Windows.Forms.Label();
            addressLabel1 = new System.Windows.Forms.Label();
            phoneLabel1 = new System.Windows.Forms.Label();
            genderLabel1 = new System.Windows.Forms.Label();
            idLabel1 = new System.Windows.Forms.Label();
            fullNameLabel2 = new System.Windows.Forms.Label();
            emailLabel2 = new System.Windows.Forms.Label();
            addressLabel2 = new System.Windows.Forms.Label();
            phoneLabel2 = new System.Windows.Forms.Label();
            genderLabel2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_num1
            // 
            this.tb_num1.Location = new System.Drawing.Point(307, 93);
            this.tb_num1.Name = "tb_num1";
            this.tb_num1.Size = new System.Drawing.Size(100, 20);
            this.tb_num1.TabIndex = 0;
            // 
            // tb_num2
            // 
            this.tb_num2.Location = new System.Drawing.Point(307, 129);
            this.tb_num2.Name = "tb_num2";
            this.tb_num2.Size = new System.Drawing.Size(100, 20);
            this.tb_num2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(216, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Number 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Number 2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(290, 169);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.Resize += new System.EventHandler(this.button1_Resize);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(219, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sum";
            // 
            // lbl_sum
            // 
            this.lbl_sum.AutoSize = true;
            this.lbl_sum.Location = new System.Drawing.Point(307, 198);
            this.lbl_sum.Name = "lbl_sum";
            this.lbl_sum.Size = new System.Drawing.Size(13, 13);
            this.lbl_sum.TabIndex = 6;
            this.lbl_sum.Text = "0";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.fullNameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.customersBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(22, 222);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(543, 172);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.databaseDataSet;
            this.customersBindingSource.CurrentChanged += new System.EventHandler(this.customersBindingSource_CurrentChanged);
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "FullName";
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomersTableAdapter = this.customersTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // fullNameLabel
            // 
            fullNameLabel.AutoSize = true;
            fullNameLabel.Location = new System.Drawing.Point(19, 64);
            fullNameLabel.Name = "fullNameLabel";
            fullNameLabel.Size = new System.Drawing.Size(57, 13);
            fullNameLabel.TabIndex = 10;
            fullNameLabel.Text = "Full Name:";
            // 
            // fullNameTextBox
            // 
            this.fullNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "FullName", true));
            this.fullNameTextBox.Location = new System.Drawing.Point(82, 61);
            this.fullNameTextBox.Name = "fullNameTextBox";
            this.fullNameTextBox.Size = new System.Drawing.Size(121, 20);
            this.fullNameTextBox.TabIndex = 11;
            this.fullNameTextBox.TextChanged += new System.EventHandler(this.fullNameTextBox_TextChanged);
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(19, 90);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 12;
            emailLabel.Text = "Email:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(82, 87);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(121, 20);
            this.emailTextBox.TabIndex = 13;
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(19, 116);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(48, 13);
            addressLabel.TabIndex = 14;
            addressLabel.Text = "Address:";
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Address", true));
            this.addressTextBox.Location = new System.Drawing.Point(82, 113);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(121, 20);
            this.addressTextBox.TabIndex = 15;
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(19, 142);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(41, 13);
            phoneLabel.TabIndex = 16;
            phoneLabel.Text = "Phone:";
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Phone", true));
            this.phoneTextBox.Location = new System.Drawing.Point(82, 139);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(121, 20);
            this.phoneTextBox.TabIndex = 17;
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Location = new System.Drawing.Point(19, 168);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new System.Drawing.Size(45, 13);
            genderLabel.TabIndex = 18;
            genderLabel.Text = "Gender:";
            // 
            // genderComboBox
            // 
            this.genderComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Gender", true));
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Location = new System.Drawing.Point(82, 165);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(121, 21);
            this.genderComboBox.TabIndex = 19;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(357, 37);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 19;
            idLabel.Text = "Id:";
            idLabel.Click += new System.EventHandler(this.idLabel_Click);
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(420, 34);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(121, 20);
            this.idTextBox.TabIndex = 20;
            this.idTextBox.TextChanged += new System.EventHandler(this.idTextBox_TextChanged);
            // 
            // fullNameLabel1
            // 
            fullNameLabel1.AutoSize = true;
            fullNameLabel1.Location = new System.Drawing.Point(357, 63);
            fullNameLabel1.Name = "fullNameLabel1";
            fullNameLabel1.Size = new System.Drawing.Size(57, 13);
            fullNameLabel1.TabIndex = 21;
            fullNameLabel1.Text = "Full Name:";
            fullNameLabel1.Click += new System.EventHandler(this.fullNameLabel1_Click);
            // 
            // fullNameTextBox1
            // 
            this.fullNameTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "FullName", true));
            this.fullNameTextBox1.Location = new System.Drawing.Point(420, 60);
            this.fullNameTextBox1.Name = "fullNameTextBox1";
            this.fullNameTextBox1.Size = new System.Drawing.Size(121, 20);
            this.fullNameTextBox1.TabIndex = 22;
            this.fullNameTextBox1.TextChanged += new System.EventHandler(this.fullNameTextBox1_TextChanged);
            // 
            // emailLabel1
            // 
            emailLabel1.AutoSize = true;
            emailLabel1.Location = new System.Drawing.Point(357, 89);
            emailLabel1.Name = "emailLabel1";
            emailLabel1.Size = new System.Drawing.Size(35, 13);
            emailLabel1.TabIndex = 23;
            emailLabel1.Text = "Email:";
            emailLabel1.Click += new System.EventHandler(this.emailLabel1_Click);
            // 
            // emailTextBox1
            // 
            this.emailTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Email", true));
            this.emailTextBox1.Location = new System.Drawing.Point(420, 86);
            this.emailTextBox1.Name = "emailTextBox1";
            this.emailTextBox1.Size = new System.Drawing.Size(121, 20);
            this.emailTextBox1.TabIndex = 24;
            this.emailTextBox1.TextChanged += new System.EventHandler(this.emailTextBox1_TextChanged);
            // 
            // addressLabel1
            // 
            addressLabel1.AutoSize = true;
            addressLabel1.Location = new System.Drawing.Point(357, 115);
            addressLabel1.Name = "addressLabel1";
            addressLabel1.Size = new System.Drawing.Size(48, 13);
            addressLabel1.TabIndex = 25;
            addressLabel1.Text = "Address:";
            addressLabel1.Click += new System.EventHandler(this.addressLabel1_Click);
            // 
            // addressTextBox1
            // 
            this.addressTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Address", true));
            this.addressTextBox1.Location = new System.Drawing.Point(420, 112);
            this.addressTextBox1.Name = "addressTextBox1";
            this.addressTextBox1.Size = new System.Drawing.Size(121, 20);
            this.addressTextBox1.TabIndex = 26;
            this.addressTextBox1.TextChanged += new System.EventHandler(this.addressTextBox1_TextChanged);
            // 
            // phoneLabel1
            // 
            phoneLabel1.AutoSize = true;
            phoneLabel1.Location = new System.Drawing.Point(357, 141);
            phoneLabel1.Name = "phoneLabel1";
            phoneLabel1.Size = new System.Drawing.Size(41, 13);
            phoneLabel1.TabIndex = 27;
            phoneLabel1.Text = "Phone:";
            phoneLabel1.Click += new System.EventHandler(this.phoneLabel1_Click);
            // 
            // phoneTextBox1
            // 
            this.phoneTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Phone", true));
            this.phoneTextBox1.Location = new System.Drawing.Point(420, 138);
            this.phoneTextBox1.Name = "phoneTextBox1";
            this.phoneTextBox1.Size = new System.Drawing.Size(121, 20);
            this.phoneTextBox1.TabIndex = 28;
            this.phoneTextBox1.TextChanged += new System.EventHandler(this.phoneTextBox1_TextChanged);
            // 
            // genderLabel1
            // 
            genderLabel1.AutoSize = true;
            genderLabel1.Location = new System.Drawing.Point(357, 167);
            genderLabel1.Name = "genderLabel1";
            genderLabel1.Size = new System.Drawing.Size(45, 13);
            genderLabel1.TabIndex = 29;
            genderLabel1.Text = "Gender:";
            genderLabel1.Click += new System.EventHandler(this.genderLabel1_Click);
            // 
            // genderComboBox1
            // 
            this.genderComboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Gender", true));
            this.genderComboBox1.FormattingEnabled = true;
            this.genderComboBox1.Location = new System.Drawing.Point(420, 164);
            this.genderComboBox1.Name = "genderComboBox1";
            this.genderComboBox1.Size = new System.Drawing.Size(121, 21);
            this.genderComboBox1.TabIndex = 30;
            this.genderComboBox1.SelectedIndexChanged += new System.EventHandler(this.genderComboBox1_SelectedIndexChanged);
            // 
            // cn
            // 
            this.cn.DataSetName = "cn";
            this.cn.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customersBindingSource1
            // 
            this.customersBindingSource1.DataMember = "Customers";
            this.customersBindingSource1.DataSource = this.cn;
            // 
            // customersTableAdapter1
            // 
            this.customersTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.CustomersTableAdapter = this.customersTableAdapter1;
            this.tableAdapterManager1.UpdateOrder = WindowsFormsApp1.cnTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // idLabel1
            // 
            idLabel1.AutoSize = true;
            idLabel1.Location = new System.Drawing.Point(279, 45);
            idLabel1.Name = "idLabel1";
            idLabel1.Size = new System.Drawing.Size(19, 13);
            idLabel1.TabIndex = 30;
            idLabel1.Text = "Id:";
            // 
            // idTextBox1
            // 
            this.idTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource1, "Id", true));
            this.idTextBox1.Location = new System.Drawing.Point(342, 42);
            this.idTextBox1.Name = "idTextBox1";
            this.idTextBox1.Size = new System.Drawing.Size(100, 20);
            this.idTextBox1.TabIndex = 31;
            // 
            // fullNameLabel2
            // 
            fullNameLabel2.AutoSize = true;
            fullNameLabel2.Location = new System.Drawing.Point(279, 71);
            fullNameLabel2.Name = "fullNameLabel2";
            fullNameLabel2.Size = new System.Drawing.Size(57, 13);
            fullNameLabel2.TabIndex = 32;
            fullNameLabel2.Text = "Full Name:";
            // 
            // fullNameTextBox2
            // 
            this.fullNameTextBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource1, "FullName", true));
            this.fullNameTextBox2.Location = new System.Drawing.Point(342, 68);
            this.fullNameTextBox2.Name = "fullNameTextBox2";
            this.fullNameTextBox2.Size = new System.Drawing.Size(100, 20);
            this.fullNameTextBox2.TabIndex = 33;
            // 
            // emailLabel2
            // 
            emailLabel2.AutoSize = true;
            emailLabel2.Location = new System.Drawing.Point(279, 97);
            emailLabel2.Name = "emailLabel2";
            emailLabel2.Size = new System.Drawing.Size(35, 13);
            emailLabel2.TabIndex = 34;
            emailLabel2.Text = "Email:";
            // 
            // emailTextBox2
            // 
            this.emailTextBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource1, "Email", true));
            this.emailTextBox2.Location = new System.Drawing.Point(342, 94);
            this.emailTextBox2.Name = "emailTextBox2";
            this.emailTextBox2.Size = new System.Drawing.Size(100, 20);
            this.emailTextBox2.TabIndex = 35;
            // 
            // addressLabel2
            // 
            addressLabel2.AutoSize = true;
            addressLabel2.Location = new System.Drawing.Point(279, 123);
            addressLabel2.Name = "addressLabel2";
            addressLabel2.Size = new System.Drawing.Size(48, 13);
            addressLabel2.TabIndex = 36;
            addressLabel2.Text = "Address:";
            // 
            // addressTextBox2
            // 
            this.addressTextBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource1, "Address", true));
            this.addressTextBox2.Location = new System.Drawing.Point(342, 120);
            this.addressTextBox2.Name = "addressTextBox2";
            this.addressTextBox2.Size = new System.Drawing.Size(100, 20);
            this.addressTextBox2.TabIndex = 37;
            // 
            // phoneLabel2
            // 
            phoneLabel2.AutoSize = true;
            phoneLabel2.Location = new System.Drawing.Point(279, 149);
            phoneLabel2.Name = "phoneLabel2";
            phoneLabel2.Size = new System.Drawing.Size(41, 13);
            phoneLabel2.TabIndex = 38;
            phoneLabel2.Text = "Phone:";
            // 
            // phoneTextBox2
            // 
            this.phoneTextBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource1, "Phone", true));
            this.phoneTextBox2.Location = new System.Drawing.Point(342, 146);
            this.phoneTextBox2.Name = "phoneTextBox2";
            this.phoneTextBox2.Size = new System.Drawing.Size(100, 20);
            this.phoneTextBox2.TabIndex = 39;
            // 
            // genderLabel2
            // 
            genderLabel2.AutoSize = true;
            genderLabel2.Location = new System.Drawing.Point(279, 175);
            genderLabel2.Name = "genderLabel2";
            genderLabel2.Size = new System.Drawing.Size(45, 13);
            genderLabel2.TabIndex = 40;
            genderLabel2.Text = "Gender:";
            // 
            // genderTextBox
            // 
            this.genderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource1, "Gender", true));
            this.genderTextBox.Location = new System.Drawing.Point(342, 172);
            this.genderTextBox.Name = "genderTextBox";
            this.genderTextBox.Size = new System.Drawing.Size(100, 20);
            this.genderTextBox.TabIndex = 41;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 414);
            this.Controls.Add(idLabel1);
            this.Controls.Add(this.idTextBox1);
            this.Controls.Add(fullNameLabel2);
            this.Controls.Add(this.fullNameTextBox2);
            this.Controls.Add(emailLabel2);
            this.Controls.Add(this.emailTextBox2);
            this.Controls.Add(addressLabel2);
            this.Controls.Add(this.addressTextBox2);
            this.Controls.Add(phoneLabel2);
            this.Controls.Add(this.phoneTextBox2);
            this.Controls.Add(genderLabel2);
            this.Controls.Add(this.genderTextBox);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(fullNameLabel1);
            this.Controls.Add(this.fullNameTextBox1);
            this.Controls.Add(emailLabel1);
            this.Controls.Add(this.emailTextBox1);
            this.Controls.Add(addressLabel1);
            this.Controls.Add(this.addressTextBox1);
            this.Controls.Add(phoneLabel1);
            this.Controls.Add(this.phoneTextBox1);
            this.Controls.Add(genderLabel1);
            this.Controls.Add(this.genderComboBox1);
            this.Controls.Add(fullNameLabel);
            this.Controls.Add(this.fullNameTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(genderLabel);
            this.Controls.Add(this.genderComboBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbl_sum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_num2);
            this.Controls.Add(this.tb_num1);
            this.Name = "Form1";
            this.Text = "Add of Two Numbers";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_num1;
        private System.Windows.Forms.TextBox tb_num2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_sum;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private DatabaseDataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox fullNameTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.ComboBox genderComboBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox fullNameTextBox1;
        private System.Windows.Forms.TextBox emailTextBox1;
        private System.Windows.Forms.TextBox addressTextBox1;
        private System.Windows.Forms.TextBox phoneTextBox1;
        private System.Windows.Forms.ComboBox genderComboBox1;
        private cn cn;
        private System.Windows.Forms.BindingSource customersBindingSource1;
        private cnTableAdapters.CustomersTableAdapter customersTableAdapter1;
        private cnTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.TextBox idTextBox1;
        private System.Windows.Forms.TextBox fullNameTextBox2;
        private System.Windows.Forms.TextBox emailTextBox2;
        private System.Windows.Forms.TextBox addressTextBox2;
        private System.Windows.Forms.TextBox phoneTextBox2;
        private System.Windows.Forms.TextBox genderTextBox;
    }
}

