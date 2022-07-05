using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.VisualBasic.FileIO;
using Npgsql;
using System.Data.SQLite;

namespace JDataBase
{
    public partial class Form1 : Form
    {
        bool OnlineMode = true;
        bool validFile = false;
        string FILE = "C:\\Users\\Schrute\\Desktop\\members.sqlite";

        string connString;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                File.WriteAllBytes(AppDomain.CurrentDomain.BaseDirectory + @"programfiles.zip", (JDataBase.Properties.Resources.programfiles));
                System.IO.Compression.ZipFile.ExtractToDirectory(AppDomain.CurrentDomain.BaseDirectory + @"programfiles.zip", AppDomain.CurrentDomain.BaseDirectory,false);
            }
            catch (Exception)
            {
            }

            setConnString();
            if (OnlineMode)
            {
                OnlineMode = reloadAll();
            }
            if (OnlineMode)
            {
                MessageBox.Show("Loaded data from online!");
            }
            dataGridViewData.Sort(dataGridViewData.Columns[4],System.ComponentModel.ListSortDirection.Ascending);
        }

        private void setConnString()
        {
            string hostname = "";
            string username = "";
            string password = "";
            string database = ""; 

            try
            {
                var path = @"tableconfiguration.txt";
                using (TextFieldParser csvParser = new TextFieldParser(path))
                {
                    csvParser.SetDelimiters(new string[] { "," });

                    string[] fields = csvParser.ReadFields();
                    hostname = fields[0];
                    username = fields[1];
                    password = fields[2];
                    database = fields[3];
                }
            }
            catch (Exception)
            {
                OnlineMode = false;
                return;
            }



            var connStringBuilder = new NpgsqlConnectionStringBuilder();
            connStringBuilder.Host = hostname;
            connStringBuilder.Port = 26257;
            connStringBuilder.SslMode = SslMode.Require;
            connStringBuilder.Username = username;
            connStringBuilder.Password = password;
            connStringBuilder.Database = database;
            connStringBuilder.RootCertificate = "~/.postgres/root.crt";
            connStringBuilder.TrustServerCertificate = true;
            connStringBuilder.IncludeErrorDetail = true;
            connString = connStringBuilder.ConnectionString;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //runQuery();
        }

        private void runQuery(string query)
        {
            if (OnlineMode)
            {
                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open();

                    new NpgsqlCommand("CREATE TABLE IF NOT EXISTS members (id SERIAL, TitleOne varchar(255), FirstName varchar(255), MiddleName varchar(255), LastName varchar(255), TitleTwo varchar(255), AddressOne varchar(255), Addresstwo varchar(255), City varchar(255), State varchar(255), Zip varchar(255), Phone varchar(255), HisCell varchar(255), HerCell varchar(255), SpouseName varchar(255), Children varchar(255), CodeOne varchar(255), Date varchar(255), PRIMARY KEY (id));", conn).ExecuteNonQuery();

                    new NpgsqlCommand(query, conn).ExecuteNonQuery();
                }
            }
            else
            {
                if (!validFile) return;
                SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=" + FILE + "; Version=3;");
                m_dbConnection.Open();
                SQLiteCommand command = new SQLiteCommand(query, m_dbConnection);
                command.ExecuteNonQuery();
                m_dbConnection.Close();
            }

        }

        private bool reloadAll()
        {
            dataGridViewData.Rows.Clear();
            bool onlinesuccess = true;
            if (OnlineMode)
            {
                try
                {
                    using (var conn = new NpgsqlConnection(connString))
                    {
                        conn.Open();

                        new NpgsqlCommand("CREATE TABLE IF NOT EXISTS members (id SERIAL, TitleOne varchar(255), FirstName varchar(255), MiddleName varchar(255), LastName varchar(255), TitleTwo varchar(255), AddressOne varchar(255), Addresstwo varchar(255), City varchar(255), State varchar(255), Zip varchar(255), Phone varchar(255), HisCell varchar(255), HerCell varchar(255), SpouseName varchar(255), Children varchar(255), CodeOne varchar(255), Date varchar(255), PRIMARY KEY (id));", conn).ExecuteNonQuery();

                        using (var cmd = new NpgsqlCommand("SELECT * FROM members", conn))
                        using (var reader = cmd.ExecuteReader())
                            while (reader.Read())
                            {
                                dataGridViewData.Rows.Add(reader.GetValue(0).ToString(), reader.GetValue(1).ToString(), reader.GetValue(2).ToString(), reader.GetValue(3).ToString(), reader.GetValue(4).ToString(), reader.GetValue(5).ToString(), reader.GetValue(6).ToString(), reader.GetValue(7).ToString(), reader.GetValue(8).ToString(), reader.GetValue(9).ToString(), reader.GetValue(10).ToString(), reader.GetValue(11).ToString(), reader.GetValue(12).ToString(), reader.GetValue(13).ToString(), reader.GetValue(14).ToString(), reader.GetValue(15).ToString(), reader.GetValue(16).ToString(), reader.GetValue(17).ToString());
                                //Console.Write("\taccount {0}: {1}\n", reader.GetValue(0), reader.GetValue(1));
                                //label1.Text = reader.GetValue(0) + "/" + reader.GetValue(1);
                            }
                    }
                }
                catch (Exception)
                {
                    onlinesuccess = false;
                }
            }
            else onlinesuccess = false;
            if (!onlinesuccess)
            {
                OnlineMode = false;
                //SQLiteConnection.CreateFile("members.sqlite");

                if (!validFile) return false;
                SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=" + FILE + "; Version=3;");
                m_dbConnection.Open();

                string sql = "CREATE TABLE IF NOT EXISTS members (id INTEGER, TitleOne varchar(255), FirstName varchar(255), MiddleName varchar(255), LastName varchar(255), TitleTwo varchar(255), AddressOne varchar(255), Addresstwo varchar(255), City varchar(255), State varchar(255), Zip varchar(255), Phone varchar(255), HisCell varchar(255), HerCell varchar(255), SpouseName varchar(255), Children varchar(255), CodeOne varchar(255), Date varchar(255), PRIMARY KEY (id))";

                SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
                command.ExecuteNonQuery();

                sql = "SELECT * FROM members";

                command = new SQLiteCommand(sql, m_dbConnection);
                using (var reader = command.ExecuteReader())
                    while (reader.Read())
                    {
                        dataGridViewData.Rows.Add(reader.GetValue(0).ToString(), reader.GetValue(1).ToString(), reader.GetValue(2).ToString(), reader.GetValue(3).ToString(), reader.GetValue(4).ToString(), reader.GetValue(5).ToString(), reader.GetValue(6).ToString(), reader.GetValue(7).ToString(), reader.GetValue(8).ToString(), reader.GetValue(9).ToString(), reader.GetValue(10).ToString(), reader.GetValue(11).ToString(), reader.GetValue(12).ToString(), reader.GetValue(13).ToString(), reader.GetValue(14).ToString(), reader.GetValue(15).ToString(), reader.GetValue(16).ToString(), reader.GetValue(17).ToString());
                    }

                m_dbConnection.Close();
            }

            dataGridViewData.ClearSelection();
            dataGridViewData.Sort(dataGridViewData.Columns[4], System.ComponentModel.ListSortDirection.Ascending);
            bool success = false;
            foreach (DataGridViewRow dgvr in dataGridViewData.Rows)
            {
                if (dgvr.Cells[0].Value.ToString() == varID)
                {
                    dgvr.Selected = true;
                    success = true;
                    break;
                }
            }
            if (success == false)
            {
                dataGridViewData.ClearSelection();
            }
            dataGridViewData.Columns[0].Visible = false;

            return onlinesuccess;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void buttonPickDate_Click(object sender, EventArgs e)
        {
            dateTimePicker.Select();
        }

        private void tabControl1_TabIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonAddMember_Click(object sender, EventArgs e)
        {
            string currentDate = DateTime.Now.ToShortDateString();
            runQuery("INSERT INTO members (FirstName, Date) VALUES ('New Member', '" + currentDate + "')");
            reloadAll();
        }

        string varID;
        string varTitleOne;
        string varFirstName;
        string varMiddleName;
        string varLastName;
        string varTitleTwo;
        string varAddressOne;
        string varAddressTwo;
        string varCity;
        string varState;
        string varZip;
        string varPhone;
        string varHisCell;
        string varHerCell;
        string varSpouseName;
        string varChildren;
        string varCodeOne;
        string varDate;

        private void dataGridViewData_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridViewData.SelectedRows.Count >= 1)
                {
#pragma warning disable CS8601 // Possible null reference assignment.
                    varID = dataGridViewData.SelectedRows[0].Cells[0].Value.ToString();
                    varTitleOne = dataGridViewData.SelectedRows[0].Cells[1].Value.ToString();
                    varFirstName = dataGridViewData.SelectedRows[0].Cells[2].Value.ToString();
                    varMiddleName = dataGridViewData.SelectedRows[0].Cells[3].Value.ToString();
                    varLastName = dataGridViewData.SelectedRows[0].Cells[4].Value.ToString();
                    varTitleTwo = dataGridViewData.SelectedRows[0].Cells[5].Value.ToString();
                    varAddressOne = dataGridViewData.SelectedRows[0].Cells[6].Value.ToString();
                    varAddressTwo = dataGridViewData.SelectedRows[0].Cells[7].Value.ToString();
                    varCity = dataGridViewData.SelectedRows[0].Cells[8].Value.ToString();
                    varState = dataGridViewData.SelectedRows[0].Cells[9].Value.ToString();
                    varZip = dataGridViewData.SelectedRows[0].Cells[10].Value.ToString();
                    varPhone = dataGridViewData.SelectedRows[0].Cells[11].Value.ToString();
                    varHisCell = dataGridViewData.SelectedRows[0].Cells[12].Value.ToString();
                    varHerCell = dataGridViewData.SelectedRows[0].Cells[13].Value.ToString();
                    varSpouseName = dataGridViewData.SelectedRows[0].Cells[14].Value.ToString();
                    varChildren = dataGridViewData.SelectedRows[0].Cells[15].Value.ToString();
                    varCodeOne = dataGridViewData.SelectedRows[0].Cells[16].Value.ToString();
                    varDate = dataGridViewData.SelectedRows[0].Cells[17].Value.ToString();
#pragma warning restore CS8601 // Possible null reference assignment.

                    if(varFirstName != null && varFirstName.Length >= 1)
                    {
                        tabControl1.TabPages[1].Text = "Individual Record for " + varFirstName;
                    }
                    else
                    {
                        tabControl1.TabPages[1].Text = "Individual Record";
                    }
                }
            }
            catch (Exception)
            {

            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                updateRecord();
                reloadAll();
            }
            if (tabControl1.SelectedIndex == 1)
            {
                textBoxTitleOne.Text = varTitleOne;
                textBoxFirstName.Text = varFirstName;
                textBoxMiddleName.Text = varMiddleName;
                textBoxLastName.Text = varLastName;
                textBoxTitleTwo.Text = varTitleTwo;
                textBoxAddressOne.Text = varAddressOne;
                textBoxAddressTwo.Text = varAddressTwo;
                textBoxCity.Text = varCity;
                textBoxState.Text = varState;
                textBoxZip.Text = varZip;
                textBoxPhoneNumber.Text = varPhone;
                textBoxHisCell.Text = varHisCell;
                textBoxHerCell.Text = varHerCell;
                textBoxSpouseName.Text = varSpouseName;
                textBoxChildren.Text = varChildren;
                textBoxCodeOne.Text = varCodeOne;
                DateTime newtime;
                if (DateTime.TryParse(varDate, out newtime))
                {
                    dateTimePicker.Value = newtime;
                }
                if (varID != null && varID.Length >= 1)
                {
                    textBoxTitleOne.Enabled = true;
                    textBoxFirstName.Enabled = true;
                    textBoxMiddleName.Enabled = true;
                    textBoxLastName.Enabled = true;
                    textBoxTitleTwo.Enabled = true;
                    textBoxAddressOne.Enabled = true;
                    textBoxAddressTwo.Enabled = true;
                    textBoxCity.Enabled = true;
                    textBoxState.Enabled = true;
                    textBoxZip.Enabled = true;
                    textBoxPhoneNumber.Enabled = true;
                    textBoxHisCell.Enabled = true;
                    textBoxHerCell.Enabled = true;
                    textBoxSpouseName.Enabled = true;
                    textBoxChildren.Enabled = true;
                    textBoxCodeOne.Enabled = true;
                    dateTimePicker.Enabled = true;
                }
                else
                {
                    textBoxTitleOne.Enabled = false;
                    textBoxFirstName.Enabled = false;
                    textBoxMiddleName.Enabled = false;
                    textBoxLastName.Enabled = false;
                    textBoxTitleTwo.Enabled = false;
                    textBoxAddressOne.Enabled = false;
                    textBoxAddressTwo.Enabled = false;
                    textBoxCity.Enabled = false;
                    textBoxState.Enabled = false;
                    textBoxZip.Enabled = false;
                    textBoxPhoneNumber.Enabled = false;
                    textBoxHisCell.Enabled = false;
                    textBoxHerCell.Enabled = false;
                    textBoxSpouseName.Enabled = false;
                    textBoxChildren.Enabled = false;
                    textBoxCodeOne.Enabled = false;
                    dateTimePicker.Enabled = false;
                }
            }
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            varDate = dateTimePicker.Value.ToShortDateString();
        }

        private void dataGridViewData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewData_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void textBoxTitleOne_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void textBoxFirstName_TextChanged(object sender, EventArgs e)
        {
            varFirstName = textBoxFirstName.Text;
        }

        private void textBoxMiddleName_TextChanged(object sender, EventArgs e)
        {
            varMiddleName = textBoxMiddleName.Text;
        }

        private void textBoxLastName_TextChanged(object sender, EventArgs e)
        {
            varLastName = textBoxLastName.Text;
        }

        private void textBoxTitleTwo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void textBoxPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            varPhone = textBoxPhoneNumber.Text;
        }

        private void textBoxAddressOne_TextChanged(object sender, EventArgs e)
        {
            varAddressOne = textBoxAddressOne.Text;
        }

        private void textBoxAddressTwo_TextChanged(object sender, EventArgs e)
        {
            varAddressTwo = textBoxAddressTwo.Text;
        }

        private void textBoxCity_TextChanged(object sender, EventArgs e)
        {
            varCity = textBoxCity.Text;
        }

        private void textBoxState_TextChanged(object sender, EventArgs e)
        {
            varState = textBoxState.Text;
        }

        private void textBoxZip_TextChanged(object sender, EventArgs e)
        {
            varZip = textBoxZip.Text;
        }

        private void textBoxSpouseName_TextChanged(object sender, EventArgs e)
        {
            varSpouseName = textBoxSpouseName.Text;
        }

        private void textBoxChildren_TextChanged(object sender, EventArgs e)
        {
            varChildren = textBoxChildren.Text;
        }

        private void textBoxHisCell_TextChanged(object sender, EventArgs e)
        {
            varHisCell = textBoxHisCell.Text;
        }

        private void textBoxHerCell_TextChanged(object sender, EventArgs e)
        {
            varHerCell = textBoxHerCell.Text;
        }

        private void textBoxCodeOne_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void updateRecord()
        {
            if (varID == null)
            {
                return;
            }
            using (var conn = new NpgsqlConnection(connString))
            {
                if (OnlineMode)
                {
                    conn.Open();
                    new NpgsqlCommand("CREATE TABLE IF NOT EXISTS members (id SERIAL, TitleOne varchar(255), FirstName varchar(255), MiddleName varchar(255), LastName varchar(255), TitleTwo varchar(255), AddressOne varchar(255), Addresstwo varchar(255), City varchar(255), State varchar(255), Zip varchar(255), Phone varchar(255), HisCell varchar(255), HerCell varchar(255), SpouseName varchar(255), Children varchar(255), CodeOne varchar(255), Date varchar(255), PRIMARY KEY (id));", conn).ExecuteNonQuery();
                    var cmd = new NpgsqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "UPDATE members SET TitleOne = @i0, FirstName = @i1, MiddleName = @i2, LastName = @i3, TitleTwo = @i4, AddressOne = @i5, Addresstwo = @i6, City = @i7, State = @i8, Zip = @i9, Phone = @i10, HisCell = @i11, HerCell = @i12, SpouseName = @i13, Children = @i14, CodeOne = @i15, Date = @i16 WHERE id = @i17;";

                    cmd.Parameters.AddWithValue("@i0", varTitleOne);
                    cmd.Parameters.AddWithValue("@i1", varFirstName);
                    cmd.Parameters.AddWithValue("@i2", varMiddleName);
                    cmd.Parameters.AddWithValue("@i3", varLastName);
                    cmd.Parameters.AddWithValue("@i4", varTitleTwo);
                    cmd.Parameters.AddWithValue("@i5", varAddressOne);
                    cmd.Parameters.AddWithValue("@i6", varAddressTwo);
                    cmd.Parameters.AddWithValue("@i7", varCity);
                    cmd.Parameters.AddWithValue("@i8", varState);
                    cmd.Parameters.AddWithValue("@i9", varZip);
                    cmd.Parameters.AddWithValue("@i10", varPhone);
                    cmd.Parameters.AddWithValue("@i11", varHisCell);
                    cmd.Parameters.AddWithValue("@i12", varHerCell);
                    cmd.Parameters.AddWithValue("@i13", varSpouseName);
                    cmd.Parameters.AddWithValue("@i14", varChildren);
                    cmd.Parameters.AddWithValue("@i15", varCodeOne);
                    cmd.Parameters.AddWithValue("@i16", varDate);

                    try
                    {
                        cmd.Parameters.AddWithValue("@i17", Int64.Parse(varID));
                    }
                    catch (Exception)
                    {
                        cmd.Parameters.AddWithValue("@i17", 0);
                    }
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    if (!validFile) return;
                    SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=" + FILE + "; Version=3;");
                    m_dbConnection.Open();
                    string query = "UPDATE members SET TitleOne = @i0, FirstName = @i1, MiddleName = @i2, LastName = @i3, TitleTwo = @i4, AddressOne = @i5, Addresstwo = @i6, City = @i7, State = @i8, Zip = @i9, Phone = @i10, HisCell = @i11, HerCell = @i12, SpouseName = @i13, Children = @i14, CodeOne = @i15, Date = @i16 WHERE id = @i17;";
                    var cmd = new SQLiteCommand(query, m_dbConnection);
                    cmd.Parameters.AddWithValue("@i0", varTitleOne);
                    cmd.Parameters.AddWithValue("@i1", varFirstName);
                    cmd.Parameters.AddWithValue("@i2", varMiddleName);
                    cmd.Parameters.AddWithValue("@i3", varLastName);
                    cmd.Parameters.AddWithValue("@i4", varTitleTwo);
                    cmd.Parameters.AddWithValue("@i5", varAddressOne);
                    cmd.Parameters.AddWithValue("@i6", varAddressTwo);
                    cmd.Parameters.AddWithValue("@i7", varCity);
                    cmd.Parameters.AddWithValue("@i8", varState);
                    cmd.Parameters.AddWithValue("@i9", varZip);
                    cmd.Parameters.AddWithValue("@i10", varPhone);
                    cmd.Parameters.AddWithValue("@i11", varHisCell);
                    cmd.Parameters.AddWithValue("@i12", varHerCell);
                    cmd.Parameters.AddWithValue("@i13", varSpouseName);
                    cmd.Parameters.AddWithValue("@i14", varChildren);
                    cmd.Parameters.AddWithValue("@i15", varCodeOne);
                    cmd.Parameters.AddWithValue("@i16", varDate);
                    try
                    {
                        cmd.Parameters.AddWithValue("@i17", Int64.Parse(varID));
                    }
                    catch (Exception)
                    {
                        cmd.Parameters.AddWithValue("@i17", 0);
                    }
                    cmd.ExecuteNonQuery();
                    cmd.ExecuteNonQuery();
                    m_dbConnection.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            updateRecord();
            MessageBox.Show("Saved data!");
        }

        private void dataGridViewData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridViewData_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridViewData_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1) return;
            tabControl1.SelectedIndex = 1;
        }

        private void buttonDeleteMember_Click(object sender, EventArgs e)
        {
            if(varID != null)
            {
                runQuery("DELETE FROM members WHERE id = " + varID);
            }
            reloadAll();
            clearCurrent();
            dataGridViewData.ClearSelection();
            tabControl1.TabPages[1].Hide();
            textBoxTitleOne.Enabled = false;
            textBoxFirstName.Enabled = false;
            textBoxMiddleName.Enabled = false;
            textBoxLastName.Enabled = false;
            textBoxTitleTwo.Enabled = false;
            textBoxAddressOne.Enabled = false;
            textBoxAddressTwo.Enabled = false;
            textBoxCity.Enabled = false;
            textBoxState.Enabled = false;
            textBoxZip.Enabled = false;
            textBoxPhoneNumber.Enabled = false;
            textBoxHisCell.Enabled = false;
            textBoxHerCell.Enabled = false;
            textBoxSpouseName.Enabled = false;
            textBoxChildren.Enabled = false;
            textBoxCodeOne.Enabled = false;
            dateTimePicker.Enabled = false;
        }

        private void clearCurrent()
        {
            varID = null;
            varTitleOne = null;
            varFirstName = null;
            varMiddleName = null;
            varLastName = null;
            varTitleTwo = null;
            varAddressOne = null;
            varAddressTwo = null;
            varCity = null;
            varState = null;
            varZip = null;
            varPhone = null;
            varHisCell = null;
            varHerCell = null;
            varSpouseName = null;
            varChildren = null;
            varCodeOne = null;
            varDate = null;
            tabControl1.TabPages[1].Text = "Individual Record";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            tabControl1.TabPages[1].Hide();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void loadDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            FILE = openFileDialog1.FileName;
            validFile = true;
            OnlineMode = false;
            reloadAll();
        }

        private void loadDatabaseFromOnlineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OnlineMode = true;
            bool success = reloadAll();
            if (success)
            {
                MessageBox.Show("Loaded online data!");
            }
            else
            {
                MessageBox.Show("Could not load the online data");
            }
        }

        private void saveDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NEWDATABASE = false;
            saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string file = saveFileDialog1.FileName;

            SQLiteConnection.CreateFile(file);

            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=" + file + "; Version=3;");
            m_dbConnection.Open();

            if (NEWDATABASE)
            {
                FILE = file;
                OnlineMode = false;
                validFile=true;
            }


            string sql = "CREATE TABLE IF NOT EXISTS members (id INTEGER, TitleOne varchar(255), FirstName varchar(255), MiddleName varchar(255), LastName varchar(255), TitleTwo varchar(255), AddressOne varchar(255), Addresstwo varchar(255), City varchar(255), State varchar(255), Zip varchar(255), Phone varchar(255), HisCell varchar(255), HerCell varchar(255), SpouseName varchar(255), Children varchar(255), CodeOne varchar(255), Date varchar(255), PRIMARY KEY (id))";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();

            SQLiteCommand command2 = new SQLiteCommand("DELETE FROM members", m_dbConnection);
            command2.ExecuteNonQuery();

            if (!NEWDATABASE)
            {
                foreach (DataGridViewRow dgvr in dataGridViewData.Rows)
                {
                    //MessageBox.Show(dataGridViewData.Rows.Count.ToString());
                    var insertcommand = m_dbConnection.CreateCommand();
                    insertcommand.CommandText = "INSERT INTO members(TitleOne,FirstName,MiddleName,LastName,TitleTwo,AddressOne,Addresstwo,City,State,Zip,Phone,HisCell,HerCell,SpouseName,Children,CodeOne,Date) VALUES (@TitleOne,@FirstName,@MiddleName,@LastName,@TitleTwo,@AddressOne,@Addresstwo,@City,@State,@Zip,@Phone,@HisCell,@HerCell,@SpouseName,@Children,@CodeOne,@Date)";
                    insertcommand.Parameters.AddWithValue("TitleOne", dgvr.Cells[1].Value.ToString());
                    insertcommand.Parameters.AddWithValue("FirstName", dgvr.Cells[2].Value.ToString());
                    insertcommand.Parameters.AddWithValue("MiddleName", dgvr.Cells[3].Value.ToString());
                    insertcommand.Parameters.AddWithValue("LastName", dgvr.Cells[4].Value.ToString());
                    insertcommand.Parameters.AddWithValue("TitleTwo", dgvr.Cells[5].Value.ToString());
                    insertcommand.Parameters.AddWithValue("AddressOne", dgvr.Cells[6].Value.ToString());
                    insertcommand.Parameters.AddWithValue("Addresstwo", dgvr.Cells[7].Value.ToString());
                    insertcommand.Parameters.AddWithValue("City", dgvr.Cells[8].Value.ToString());
                    insertcommand.Parameters.AddWithValue("State", dgvr.Cells[9].Value.ToString());
                    insertcommand.Parameters.AddWithValue("Zip", dgvr.Cells[10].Value.ToString());
                    insertcommand.Parameters.AddWithValue("Phone", dgvr.Cells[11].Value.ToString());
                    insertcommand.Parameters.AddWithValue("HisCell", dgvr.Cells[12].Value.ToString());
                    insertcommand.Parameters.AddWithValue("HerCell", dgvr.Cells[13].Value.ToString());
                    insertcommand.Parameters.AddWithValue("SpouseName", dgvr.Cells[14].Value.ToString());
                    insertcommand.Parameters.AddWithValue("Children", dgvr.Cells[15].Value.ToString());
                    insertcommand.Parameters.AddWithValue("CodeOne", dgvr.Cells[16].Value.ToString());
                    insertcommand.Parameters.AddWithValue("Date", dgvr.Cells[17].Value.ToString());

                    //MessageBox.Show(insertcommand.CommandText.ToString());
                    insertcommand.ExecuteNonQuery();
                }
            }

            reloadAll();

        }

        private void textBoxTitleOne_TextChanged(object sender, EventArgs e)
        {
            varTitleOne = textBoxTitleOne.Text;
        }

        private void textBoxTitleTwo_TextChanged(object sender, EventArgs e)
        {
            varTitleTwo = textBoxTitleTwo.Text;
        }

        private void textBoxCodeOne_TextChanged(object sender, EventArgs e)
        {
            varCodeOne = textBoxCodeOne.Text;
        }

        bool NEWDATABASE = false;
        private void startNewDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NEWDATABASE = true;
            saveFileDialog1.ShowDialog();
        }

        private void buttonSelectAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBoxPrint.Items.Count; i++)
            {
                checkedListBoxPrint.SetItemChecked(i, true);
            }
        }

        private void buttonDeselectAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBoxPrint.Items.Count; i++)
            {
                checkedListBoxPrint.SetItemChecked(i, false);
            }
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            if (checkedListBoxPrint.CheckedItems.Count <= 0)
            {
                MessageBox.Show("Please select at least one item to print out");
                return;
            }
            saveFileDialogPDFSave.ShowDialog();
        }

        private void saveFileDialogPDFSave_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            PdfPTable pTable = new PdfPTable(checkedListBoxPrint.CheckedItems.Count);
            pTable.DefaultCell.Padding = 2;
            pTable.WidthPercentage = 100;
            pTable.HorizontalAlignment = Element.ALIGN_LEFT;
            int index = -1;
            foreach (DataGridViewColumn col in dataGridViewData.Columns)
            {
                index++;
                if (index >=1 && checkedListBoxPrint.GetItemCheckState(index-1) == CheckState.Checked)
                {
                    PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText));
                    pTable.AddCell(pCell);
                }

            }
            foreach (DataGridViewRow viewRow in dataGridViewData.Rows)
            {
                index = -1;
                foreach (DataGridViewCell dcell in viewRow.Cells)
                {
                    index++;
                    if (index >= 1 && checkedListBoxPrint.GetItemCheckState(index - 1) == CheckState.Checked)
                    {
                        pTable.AddCell(dcell.Value.ToString());
                    }
                }
            }

            using (FileStream fileStream = new FileStream(saveFileDialogPDFSave.FileName, FileMode.Create))
            {
                Document document = new Document(PageSize.LETTER_LANDSCAPE, 8f, 16f, 16f, 8f);
                PdfWriter.GetInstance(document, fileStream);
                document.Open();
                document.Add(pTable);
                document.Close();
                fileStream.Close();
            }
            MessageBox.Show("Data Export Successfully", "info");
        }
    }
}