namespace JDataBase
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabTableOfPeople = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewData = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TitleOne = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MiddleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TitleTwo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddressOne = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddressTwo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.State = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Zip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HisCell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HerCell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SpouseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Children = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodeOne = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonAddMember = new System.Windows.Forms.Button();
            this.buttonDeleteMember = new System.Windows.Forms.Button();
            this.tabIndividualRecord = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxMiddleName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.textBoxAddressOne = new System.Windows.Forms.TextBox();
            this.textBoxAddressTwo = new System.Windows.Forms.TextBox();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.textBoxState = new System.Windows.Forms.TextBox();
            this.textBoxZip = new System.Windows.Forms.TextBox();
            this.textBoxSpouseName = new System.Windows.Forms.TextBox();
            this.textBoxChildren = new System.Windows.Forms.TextBox();
            this.textBoxHisCell = new System.Windows.Forms.TextBox();
            this.textBoxHerCell = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.textBoxTitleOne = new System.Windows.Forms.ComboBox();
            this.textBoxTitleTwo = new System.Windows.Forms.ComboBox();
            this.textBoxCodeOne = new System.Windows.Forms.ComboBox();
            this.buttonSaveData = new System.Windows.Forms.Button();
            this.tabPagePrint = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.buttonDeselectAll = new System.Windows.Forms.Button();
            this.buttonSelectAll = new System.Windows.Forms.Button();
            this.checkedListBoxPrint = new System.Windows.Forms.CheckedListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.saveLoadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadDatabaseFromOnlineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startNewDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogPDFSave = new System.Windows.Forms.SaveFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabTableOfPeople.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).BeginInit();
            this.tabIndividualRecord.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabPagePrint.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabTableOfPeople);
            this.tabControl1.Controls.Add(this.tabIndividualRecord);
            this.tabControl1.Controls.Add(this.tabPagePrint);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1189, 391);
            this.tabControl1.TabIndex = 3;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            this.tabControl1.TabIndexChanged += new System.EventHandler(this.tabControl1_TabIndexChanged);
            // 
            // tabTableOfPeople
            // 
            this.tabTableOfPeople.Controls.Add(this.tableLayoutPanel2);
            this.tabTableOfPeople.Location = new System.Drawing.Point(4, 24);
            this.tabTableOfPeople.Name = "tabTableOfPeople";
            this.tabTableOfPeople.Padding = new System.Windows.Forms.Padding(3);
            this.tabTableOfPeople.Size = new System.Drawing.Size(1181, 363);
            this.tabTableOfPeople.TabIndex = 1;
            this.tabTableOfPeople.Text = "Table of People";
            this.tabTableOfPeople.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.dataGridViewData, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.buttonAddMember, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonDeleteMember, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 99.99999F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1175, 357);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // dataGridViewData
            // 
            this.dataGridViewData.AllowUserToAddRows = false;
            this.dataGridViewData.AllowUserToDeleteRows = false;
            this.dataGridViewData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.TitleOne,
            this.FirstName,
            this.MiddleName,
            this.LastName,
            this.TitleTwo,
            this.AddressOne,
            this.AddressTwo,
            this.City,
            this.State,
            this.Zip,
            this.Phone,
            this.HisCell,
            this.HerCell,
            this.SpouseName,
            this.Children,
            this.CodeOne,
            this.Date});
            this.tableLayoutPanel2.SetColumnSpan(this.dataGridViewData, 3);
            this.dataGridViewData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewData.Location = new System.Drawing.Point(3, 33);
            this.dataGridViewData.MultiSelect = false;
            this.dataGridViewData.Name = "dataGridViewData";
            this.dataGridViewData.ReadOnly = true;
            this.dataGridViewData.RowTemplate.Height = 25;
            this.dataGridViewData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewData.Size = new System.Drawing.Size(1169, 321);
            this.dataGridViewData.TabIndex = 0;
            this.dataGridViewData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewData_CellContentClick);
            this.dataGridViewData.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewData_CellContentDoubleClick);
            this.dataGridViewData.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewData_CellDoubleClick);
            this.dataGridViewData.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewData_CellEnter);
            this.dataGridViewData.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewData_CellMouseDoubleClick);
            this.dataGridViewData.DoubleClick += new System.EventHandler(this.dataGridViewData_DoubleClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // TitleOne
            // 
            this.TitleOne.HeaderText = "Title 1";
            this.TitleOne.Name = "TitleOne";
            this.TitleOne.ReadOnly = true;
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "First Name";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            // 
            // MiddleName
            // 
            this.MiddleName.HeaderText = "Middle Name";
            this.MiddleName.Name = "MiddleName";
            this.MiddleName.ReadOnly = true;
            // 
            // LastName
            // 
            this.LastName.HeaderText = "Last Name";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            // 
            // TitleTwo
            // 
            this.TitleTwo.HeaderText = "Title 2";
            this.TitleTwo.Name = "TitleTwo";
            this.TitleTwo.ReadOnly = true;
            // 
            // AddressOne
            // 
            this.AddressOne.HeaderText = "Address #1";
            this.AddressOne.Name = "AddressOne";
            this.AddressOne.ReadOnly = true;
            // 
            // AddressTwo
            // 
            this.AddressTwo.HeaderText = "Address #2";
            this.AddressTwo.Name = "AddressTwo";
            this.AddressTwo.ReadOnly = true;
            // 
            // City
            // 
            this.City.HeaderText = "City";
            this.City.Name = "City";
            this.City.ReadOnly = true;
            // 
            // State
            // 
            this.State.HeaderText = "State";
            this.State.Name = "State";
            this.State.ReadOnly = true;
            // 
            // Zip
            // 
            this.Zip.HeaderText = "Zip";
            this.Zip.Name = "Zip";
            this.Zip.ReadOnly = true;
            // 
            // Phone
            // 
            this.Phone.HeaderText = "Phone";
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            // 
            // HisCell
            // 
            this.HisCell.HeaderText = "His cell";
            this.HisCell.Name = "HisCell";
            this.HisCell.ReadOnly = true;
            // 
            // HerCell
            // 
            this.HerCell.HeaderText = "Her cell";
            this.HerCell.Name = "HerCell";
            this.HerCell.ReadOnly = true;
            // 
            // SpouseName
            // 
            this.SpouseName.HeaderText = "Spouse Name";
            this.SpouseName.Name = "SpouseName";
            this.SpouseName.ReadOnly = true;
            // 
            // Children
            // 
            this.Children.HeaderText = "Children";
            this.Children.Name = "Children";
            this.Children.ReadOnly = true;
            // 
            // CodeOne
            // 
            this.CodeOne.HeaderText = "Code 1";
            this.CodeOne.Name = "CodeOne";
            this.CodeOne.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date Entered";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // buttonAddMember
            // 
            this.buttonAddMember.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAddMember.Location = new System.Drawing.Point(3, 3);
            this.buttonAddMember.Name = "buttonAddMember";
            this.buttonAddMember.Size = new System.Drawing.Size(124, 24);
            this.buttonAddMember.TabIndex = 1;
            this.buttonAddMember.Text = "Add Member";
            this.buttonAddMember.UseVisualStyleBackColor = true;
            this.buttonAddMember.Click += new System.EventHandler(this.buttonAddMember_Click);
            // 
            // buttonDeleteMember
            // 
            this.buttonDeleteMember.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonDeleteMember.Location = new System.Drawing.Point(133, 3);
            this.buttonDeleteMember.Name = "buttonDeleteMember";
            this.buttonDeleteMember.Size = new System.Drawing.Size(124, 24);
            this.buttonDeleteMember.TabIndex = 2;
            this.buttonDeleteMember.Text = "Delete Member";
            this.buttonDeleteMember.UseVisualStyleBackColor = true;
            this.buttonDeleteMember.Click += new System.EventHandler(this.buttonDeleteMember_Click);
            // 
            // tabIndividualRecord
            // 
            this.tabIndividualRecord.Controls.Add(this.tableLayoutPanel1);
            this.tabIndividualRecord.Location = new System.Drawing.Point(4, 24);
            this.tabIndividualRecord.Name = "tabIndividualRecord";
            this.tabIndividualRecord.Size = new System.Drawing.Size(1181, 363);
            this.tabIndividualRecord.TabIndex = 2;
            this.tabIndividualRecord.Text = "Individual Record";
            this.tabIndividualRecord.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 17;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 92F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 89F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66666F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxFirstName, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxMiddleName, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 9, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxLastName, 10, 0);
            this.tableLayoutPanel1.Controls.Add(this.label6, 12, 0);
            this.tableLayoutPanel1.Controls.Add(this.label7, 15, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxPhoneNumber, 16, 0);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label11, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.label12, 6, 6);
            this.tableLayoutPanel1.Controls.Add(this.label13, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.label14, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.label15, 0, 12);
            this.tableLayoutPanel1.Controls.Add(this.label16, 3, 12);
            this.tableLayoutPanel1.Controls.Add(this.label17, 6, 12);
            this.tableLayoutPanel1.Controls.Add(this.label18, 0, 14);
            this.tableLayoutPanel1.Controls.Add(this.textBoxAddressOne, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBoxAddressTwo, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.textBoxCity, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.textBoxState, 4, 6);
            this.tableLayoutPanel1.Controls.Add(this.textBoxZip, 7, 6);
            this.tableLayoutPanel1.Controls.Add(this.textBoxSpouseName, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.textBoxChildren, 1, 10);
            this.tableLayoutPanel1.Controls.Add(this.textBoxHisCell, 1, 12);
            this.tableLayoutPanel1.Controls.Add(this.textBoxHerCell, 4, 12);
            this.tableLayoutPanel1.Controls.Add(this.dateTimePicker, 1, 14);
            this.tableLayoutPanel1.Controls.Add(this.textBoxTitleOne, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxTitleTwo, 13, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxCodeOne, 7, 12);
            this.tableLayoutPanel1.Controls.Add(this.buttonSaveData, 0, 16);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 17;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 1F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1181, 363);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "Title 1";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFirstName.Location = new System.Drawing.Point(306, 3);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(100, 23);
            this.textBoxFirstName.TabIndex = 1;
            this.textBoxFirstName.TextChanged += new System.EventHandler(this.textBoxFirstName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(214, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 30);
            this.label3.TabIndex = 0;
            this.label3.Text = "First Name";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(422, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 30);
            this.label4.TabIndex = 0;
            this.label4.Text = "Middle Name";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxMiddleName
            // 
            this.textBoxMiddleName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMiddleName.Location = new System.Drawing.Point(511, 3);
            this.textBoxMiddleName.Name = "textBoxMiddleName";
            this.textBoxMiddleName.Size = new System.Drawing.Size(100, 23);
            this.textBoxMiddleName.TabIndex = 2;
            this.textBoxMiddleName.TextChanged += new System.EventHandler(this.textBoxMiddleName_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(627, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 30);
            this.label5.TabIndex = 0;
            this.label5.Text = "Last Name";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLastName.Location = new System.Drawing.Point(702, 3);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(100, 23);
            this.textBoxLastName.TabIndex = 3;
            this.textBoxLastName.TextChanged += new System.EventHandler(this.textBoxLastName_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(818, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 30);
            this.label6.TabIndex = 0;
            this.label6.Text = "Title 2";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(982, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 30);
            this.label7.TabIndex = 0;
            this.label7.Text = "Phone Number";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(1077, 3);
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(101, 23);
            this.textBoxPhoneNumber.TabIndex = 5;
            this.textBoxPhoneNumber.TextChanged += new System.EventHandler(this.textBoxPhoneNumber_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(3, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 30);
            this.label8.TabIndex = 0;
            this.label8.Text = "Address 1";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Location = new System.Drawing.Point(3, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 30);
            this.label9.TabIndex = 0;
            this.label9.Text = "Address 2";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label9.Click += new System.EventHandler(this.label8_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Location = new System.Drawing.Point(3, 120);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 30);
            this.label10.TabIndex = 0;
            this.label10.Text = "City";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label10.Click += new System.EventHandler(this.label8_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Location = new System.Drawing.Point(214, 120);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 30);
            this.label11.TabIndex = 0;
            this.label11.Text = "State";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label11.Click += new System.EventHandler(this.label8_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Location = new System.Drawing.Point(422, 120);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 30);
            this.label12.TabIndex = 0;
            this.label12.Text = "Zip";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label12.Click += new System.EventHandler(this.label8_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Location = new System.Drawing.Point(3, 160);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 30);
            this.label13.TabIndex = 0;
            this.label13.Text = "Spouse name";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label13.Click += new System.EventHandler(this.label8_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Location = new System.Drawing.Point(3, 200);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(89, 30);
            this.label14.TabIndex = 0;
            this.label14.Text = "Children";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label14.Click += new System.EventHandler(this.label8_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label15.Location = new System.Drawing.Point(3, 260);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(89, 30);
            this.label15.TabIndex = 0;
            this.label15.Text = "His cell phone";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label15.Click += new System.EventHandler(this.label8_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label16.Location = new System.Drawing.Point(214, 260);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(86, 30);
            this.label16.TabIndex = 0;
            this.label16.Text = "Her cell phone";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label16.Click += new System.EventHandler(this.label8_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label17.Location = new System.Drawing.Point(422, 260);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(83, 30);
            this.label17.TabIndex = 0;
            this.label17.Text = "Code 1";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label17.Click += new System.EventHandler(this.label8_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label18.Location = new System.Drawing.Point(3, 300);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(89, 30);
            this.label18.TabIndex = 0;
            this.label18.Text = "Date Entered";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label18.Click += new System.EventHandler(this.label8_Click);
            // 
            // textBoxAddressOne
            // 
            this.textBoxAddressOne.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.textBoxAddressOne, 4);
            this.textBoxAddressOne.Location = new System.Drawing.Point(98, 43);
            this.textBoxAddressOne.Name = "textBoxAddressOne";
            this.textBoxAddressOne.Size = new System.Drawing.Size(308, 23);
            this.textBoxAddressOne.TabIndex = 6;
            this.textBoxAddressOne.TextChanged += new System.EventHandler(this.textBoxAddressOne_TextChanged);
            // 
            // textBoxAddressTwo
            // 
            this.textBoxAddressTwo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.textBoxAddressTwo, 4);
            this.textBoxAddressTwo.Location = new System.Drawing.Point(98, 83);
            this.textBoxAddressTwo.Name = "textBoxAddressTwo";
            this.textBoxAddressTwo.Size = new System.Drawing.Size(308, 23);
            this.textBoxAddressTwo.TabIndex = 7;
            this.textBoxAddressTwo.TextChanged += new System.EventHandler(this.textBoxAddressTwo_TextChanged);
            // 
            // textBoxCity
            // 
            this.textBoxCity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCity.Location = new System.Drawing.Point(98, 123);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(100, 23);
            this.textBoxCity.TabIndex = 8;
            this.textBoxCity.TextChanged += new System.EventHandler(this.textBoxCity_TextChanged);
            // 
            // textBoxState
            // 
            this.textBoxState.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxState.Location = new System.Drawing.Point(306, 123);
            this.textBoxState.Name = "textBoxState";
            this.textBoxState.Size = new System.Drawing.Size(100, 23);
            this.textBoxState.TabIndex = 9;
            this.textBoxState.TextChanged += new System.EventHandler(this.textBoxState_TextChanged);
            // 
            // textBoxZip
            // 
            this.textBoxZip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxZip.Location = new System.Drawing.Point(511, 123);
            this.textBoxZip.Name = "textBoxZip";
            this.textBoxZip.Size = new System.Drawing.Size(100, 23);
            this.textBoxZip.TabIndex = 10;
            this.textBoxZip.TextChanged += new System.EventHandler(this.textBoxZip_TextChanged);
            // 
            // textBoxSpouseName
            // 
            this.textBoxSpouseName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSpouseName.Location = new System.Drawing.Point(98, 163);
            this.textBoxSpouseName.Name = "textBoxSpouseName";
            this.textBoxSpouseName.Size = new System.Drawing.Size(100, 23);
            this.textBoxSpouseName.TabIndex = 11;
            this.textBoxSpouseName.TextChanged += new System.EventHandler(this.textBoxSpouseName_TextChanged);
            // 
            // textBoxChildren
            // 
            this.textBoxChildren.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.textBoxChildren, 4);
            this.textBoxChildren.Location = new System.Drawing.Point(98, 203);
            this.textBoxChildren.Name = "textBoxChildren";
            this.textBoxChildren.Size = new System.Drawing.Size(308, 23);
            this.textBoxChildren.TabIndex = 12;
            this.textBoxChildren.TextChanged += new System.EventHandler(this.textBoxChildren_TextChanged);
            // 
            // textBoxHisCell
            // 
            this.textBoxHisCell.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxHisCell.Location = new System.Drawing.Point(98, 263);
            this.textBoxHisCell.Name = "textBoxHisCell";
            this.textBoxHisCell.Size = new System.Drawing.Size(100, 23);
            this.textBoxHisCell.TabIndex = 13;
            this.textBoxHisCell.TextChanged += new System.EventHandler(this.textBoxHisCell_TextChanged);
            // 
            // textBoxHerCell
            // 
            this.textBoxHerCell.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxHerCell.Location = new System.Drawing.Point(306, 263);
            this.textBoxHerCell.Name = "textBoxHerCell";
            this.textBoxHerCell.Size = new System.Drawing.Size(100, 23);
            this.textBoxHerCell.TabIndex = 14;
            this.textBoxHerCell.TextChanged += new System.EventHandler(this.textBoxHerCell_TextChanged);
            // 
            // dateTimePicker
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.dateTimePicker, 3);
            this.dateTimePicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(98, 303);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(202, 23);
            this.dateTimePicker.TabIndex = 16;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // textBoxTitleOne
            // 
            this.textBoxTitleOne.FormattingEnabled = true;
            this.textBoxTitleOne.Items.AddRange(new object[] {
            "Mr.",
            "Ms.",
            "Miss",
            "Mrs.",
            "Pastor",
            "The Rev.",
            "Dr."});
            this.textBoxTitleOne.Location = new System.Drawing.Point(98, 3);
            this.textBoxTitleOne.Name = "textBoxTitleOne";
            this.textBoxTitleOne.Size = new System.Drawing.Size(100, 23);
            this.textBoxTitleOne.TabIndex = 0;
            this.textBoxTitleOne.SelectedIndexChanged += new System.EventHandler(this.textBoxTitleOne_SelectedIndexChanged);
            this.textBoxTitleOne.TextChanged += new System.EventHandler(this.textBoxTitleOne_TextChanged);
            // 
            // textBoxTitleTwo
            // 
            this.textBoxTitleTwo.FormattingEnabled = true;
            this.textBoxTitleTwo.Items.AddRange(new object[] {
            "Jr.",
            "Sr.",
            "D.Min.",
            "Ph.D."});
            this.textBoxTitleTwo.Location = new System.Drawing.Point(866, 3);
            this.textBoxTitleTwo.Name = "textBoxTitleTwo";
            this.textBoxTitleTwo.Size = new System.Drawing.Size(100, 23);
            this.textBoxTitleTwo.TabIndex = 4;
            this.textBoxTitleTwo.SelectedIndexChanged += new System.EventHandler(this.textBoxTitleTwo_SelectedIndexChanged);
            this.textBoxTitleTwo.TextChanged += new System.EventHandler(this.textBoxTitleTwo_TextChanged);
            // 
            // textBoxCodeOne
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.textBoxCodeOne, 4);
            this.textBoxCodeOne.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxCodeOne.FormattingEnabled = true;
            this.textBoxCodeOne.Items.AddRange(new object[] {
            "Member",
            "Prospect",
            "Friend",
            "Neighboring church",
            "Neighboring clergyi"});
            this.textBoxCodeOne.Location = new System.Drawing.Point(511, 263);
            this.textBoxCodeOne.Name = "textBoxCodeOne";
            this.textBoxCodeOne.Size = new System.Drawing.Size(291, 23);
            this.textBoxCodeOne.TabIndex = 15;
            this.textBoxCodeOne.SelectedIndexChanged += new System.EventHandler(this.textBoxCodeOne_SelectedIndexChanged);
            this.textBoxCodeOne.TextChanged += new System.EventHandler(this.textBoxCodeOne_TextChanged);
            // 
            // buttonSaveData
            // 
            this.buttonSaveData.Location = new System.Drawing.Point(3, 333);
            this.buttonSaveData.Name = "buttonSaveData";
            this.buttonSaveData.Size = new System.Drawing.Size(89, 27);
            this.buttonSaveData.TabIndex = 7;
            this.buttonSaveData.Text = "Save";
            this.buttonSaveData.UseVisualStyleBackColor = true;
            this.buttonSaveData.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabPagePrint
            // 
            this.tabPagePrint.Controls.Add(this.label1);
            this.tabPagePrint.Controls.Add(this.buttonPrint);
            this.tabPagePrint.Controls.Add(this.buttonDeselectAll);
            this.tabPagePrint.Controls.Add(this.buttonSelectAll);
            this.tabPagePrint.Controls.Add(this.checkedListBoxPrint);
            this.tabPagePrint.Location = new System.Drawing.Point(4, 24);
            this.tabPagePrint.Name = "tabPagePrint";
            this.tabPagePrint.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePrint.Size = new System.Drawing.Size(1181, 363);
            this.tabPagePrint.TabIndex = 3;
            this.tabPagePrint.Text = "Print Data";
            this.tabPagePrint.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(320, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Select which columns to include, then press the button below";
            // 
            // buttonPrint
            // 
            this.buttonPrint.Location = new System.Drawing.Point(428, 39);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(149, 23);
            this.buttonPrint.TabIndex = 3;
            this.buttonPrint.Text = "Create File and Print";
            this.buttonPrint.UseVisualStyleBackColor = true;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // buttonDeselectAll
            // 
            this.buttonDeselectAll.Location = new System.Drawing.Point(226, 326);
            this.buttonDeselectAll.Name = "buttonDeselectAll";
            this.buttonDeselectAll.Size = new System.Drawing.Size(88, 23);
            this.buttonDeselectAll.TabIndex = 2;
            this.buttonDeselectAll.Text = "Deselect All";
            this.buttonDeselectAll.UseVisualStyleBackColor = true;
            this.buttonDeselectAll.Click += new System.EventHandler(this.buttonDeselectAll_Click);
            // 
            // buttonSelectAll
            // 
            this.buttonSelectAll.Location = new System.Drawing.Point(42, 326);
            this.buttonSelectAll.Name = "buttonSelectAll";
            this.buttonSelectAll.Size = new System.Drawing.Size(75, 23);
            this.buttonSelectAll.TabIndex = 1;
            this.buttonSelectAll.Text = "Select All";
            this.buttonSelectAll.UseVisualStyleBackColor = true;
            this.buttonSelectAll.Click += new System.EventHandler(this.buttonSelectAll_Click);
            // 
            // checkedListBoxPrint
            // 
            this.checkedListBoxPrint.CheckOnClick = true;
            this.checkedListBoxPrint.FormattingEnabled = true;
            this.checkedListBoxPrint.Items.AddRange(new object[] {
            "Title One",
            "First Name",
            "Middle Name",
            "Last Name",
            "Title Two",
            "Address One",
            "Address Two",
            "City",
            "State",
            "Zip",
            "Phone",
            "His Cell",
            "Her Cell",
            "Spouse Name",
            "Children",
            "Code One",
            "Date"});
            this.checkedListBoxPrint.Location = new System.Drawing.Point(42, 10);
            this.checkedListBoxPrint.Name = "checkedListBoxPrint";
            this.checkedListBoxPrint.Size = new System.Drawing.Size(272, 310);
            this.checkedListBoxPrint.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveLoadToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1189, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // saveLoadToolStripMenuItem
            // 
            this.saveLoadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveDatabaseToolStripMenuItem,
            this.loadDatabaseToolStripMenuItem,
            this.loadDatabaseFromOnlineToolStripMenuItem,
            this.startNewDatabaseToolStripMenuItem});
            this.saveLoadToolStripMenuItem.Name = "saveLoadToolStripMenuItem";
            this.saveLoadToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.saveLoadToolStripMenuItem.Text = "Save and Load";
            // 
            // saveDatabaseToolStripMenuItem
            // 
            this.saveDatabaseToolStripMenuItem.Name = "saveDatabaseToolStripMenuItem";
            this.saveDatabaseToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.saveDatabaseToolStripMenuItem.Text = "Save Database to File";
            this.saveDatabaseToolStripMenuItem.Click += new System.EventHandler(this.saveDatabaseToolStripMenuItem_Click);
            // 
            // loadDatabaseToolStripMenuItem
            // 
            this.loadDatabaseToolStripMenuItem.Name = "loadDatabaseToolStripMenuItem";
            this.loadDatabaseToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.loadDatabaseToolStripMenuItem.Text = "Load Database from File";
            this.loadDatabaseToolStripMenuItem.Click += new System.EventHandler(this.loadDatabaseToolStripMenuItem_Click);
            // 
            // loadDatabaseFromOnlineToolStripMenuItem
            // 
            this.loadDatabaseFromOnlineToolStripMenuItem.Name = "loadDatabaseFromOnlineToolStripMenuItem";
            this.loadDatabaseFromOnlineToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.loadDatabaseFromOnlineToolStripMenuItem.Text = "Load Database from Online";
            this.loadDatabaseFromOnlineToolStripMenuItem.Click += new System.EventHandler(this.loadDatabaseFromOnlineToolStripMenuItem_Click);
            // 
            // startNewDatabaseToolStripMenuItem
            // 
            this.startNewDatabaseToolStripMenuItem.Name = "startNewDatabaseToolStripMenuItem";
            this.startNewDatabaseToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.startNewDatabaseToolStripMenuItem.Text = "Start New Database";
            this.startNewDatabaseToolStripMenuItem.Click += new System.EventHandler(this.startNewDatabaseToolStripMenuItem_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "JDataBase files|*.jdb";
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "JDataBase files|*.jdb";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // saveFileDialogPDFSave
            // 
            this.saveFileDialogPDFSave.Filter = "PDF file|*.pdf";
            this.saveFileDialogPDFSave.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialogPDFSave_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 415);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(750, 420);
            this.Name = "Form1";
            this.Text = "JDataBase";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabTableOfPeople.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).EndInit();
            this.tabIndividualRecord.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabPagePrint.ResumeLayout(false);
            this.tabPagePrint.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TabControl tabControl1;
        private TabPage tabTableOfPeople;
        private DataGridView dataGridViewData;
        private TabPage tabIndividualRecord;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label2;
        private TextBox textBoxFirstName;
        private Label label3;
        private Label label4;
        private TextBox textBoxMiddleName;
        private Label label5;
        private TextBox textBoxLastName;
        private Label label6;
        private Label label7;
        private TextBox textBoxPhoneNumber;
        private Label label8;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem saveLoadToolStripMenuItem;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private TextBox textBoxAddressOne;
        private TextBox textBoxAddressTwo;
        private TextBox textBoxCity;
        private TextBox textBoxState;
        private TextBox textBoxZip;
        private TextBox textBoxSpouseName;
        private TextBox textBoxChildren;
        private TextBox textBoxHisCell;
        private TextBox textBoxHerCell;
        private DateTimePicker dateTimePicker;
        private ComboBox textBoxTitleOne;
        private ComboBox textBoxTitleTwo;
        private ComboBox textBoxCodeOne;
        private Button buttonSaveData;
        private TableLayoutPanel tableLayoutPanel2;
        private Button buttonAddMember;
        private Button buttonDeleteMember;
        private TabPage tabPagePrint;
        private CheckedListBox checkedListBoxPrint;
        private Button buttonDeselectAll;
        private Button buttonSelectAll;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn TitleOne;
        private DataGridViewTextBoxColumn FirstName;
        private DataGridViewTextBoxColumn MiddleName;
        private DataGridViewTextBoxColumn LastName;
        private DataGridViewTextBoxColumn TitleTwo;
        private DataGridViewTextBoxColumn AddressOne;
        private DataGridViewTextBoxColumn AddressTwo;
        private DataGridViewTextBoxColumn City;
        private DataGridViewTextBoxColumn State;
        private DataGridViewTextBoxColumn Zip;
        private DataGridViewTextBoxColumn Phone;
        private DataGridViewTextBoxColumn HisCell;
        private DataGridViewTextBoxColumn HerCell;
        private DataGridViewTextBoxColumn SpouseName;
        private DataGridViewTextBoxColumn Children;
        private DataGridViewTextBoxColumn CodeOne;
        private DataGridViewTextBoxColumn Date;
        private ToolStripMenuItem saveDatabaseToolStripMenuItem;
        private ToolStripMenuItem loadDatabaseToolStripMenuItem;
        private SaveFileDialog saveFileDialog1;
        private OpenFileDialog openFileDialog1;
        private ToolStripMenuItem loadDatabaseFromOnlineToolStripMenuItem;
        private ToolStripMenuItem startNewDatabaseToolStripMenuItem;
        private Button buttonPrint;
        private SaveFileDialog saveFileDialogPDFSave;
        private Label label1;
    }
}