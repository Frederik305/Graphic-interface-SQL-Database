using MySql.Data.MySqlClient;
using SqlFonctions;
using System.Data;
using static DatabaseTools;

namespace Form_Fontions
{
    public partial class ListTablesForm : Form
    {
        private List<EditData> editDataList = new List<EditData>();

        private DataTable dataTable;

        private string query;

        private string columnNameID;

        private string currentTable;

        private bool IsDataInDataGrid = false;

        private string server;
        private string database;
        private string username;
        private string password;

        private MySqlConnection connection;

        // Constructeur de la classe ListTablesForm qui prend en paramètres les informations de connexion
        public ListTablesForm(string server, string database, string username, string password)
        {
            InitializeComponent();

            // Create a MySqlConnection using your ConnectionSqlDatabase class
            connection = ConnectionSqlDatabase.GetMySqlConnection(server, database, username, password);

            string query = $"SHOW FULL TABLES WHERE TABLE_TYPE = 'BASE TABLE'";
            FillDataGrid.FillDataGridView(dataGridView2, server, database, username, password, query);
            ComboBoxUtils.PopulateComboBoxWithColumnData(dataGridView2, 0, comboBox2);

            this.server = server;
            this.database = database;
            this.username = username;
            this.password = password;
        }

        private void buttonAfficher_Click(object sender, EventArgs e)
        {
            ClearDataGrid.ClearDataGridView(dataGridView1);
            currentTable = comboBox2.SelectedItem as string;

            AddData();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            ClearDataGrid.ClearDataGridView(dataGridView1);
            currentTable = "";
            textBox1.Text = string.Empty;
            comboBox1.Text = "Column to seach in...";
            checkBox1.Checked = false;
            checkBoxEdit.Checked = false;

            checkBox1.Enabled = false;
            checkBoxEdit.Enabled = false;

            IsDataInDataGrid = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string selectedColumnName = comboBox1.SelectedItem as string;
            string inputValue = textBox1.Text;

            if (string.IsNullOrEmpty(inputValue) || (string.IsNullOrEmpty(selectedColumnName))) { FillDataGrid.FillDataGridView(dataGridView1, server, database, username, password, query); }
            else
            {
                string whereClause = $"WHERE {selectedColumnName} LIKE '%{inputValue}%';";

                FillDataGrid.FillDataGridView(dataGridView1, server, database, username, password, $"SELECT * FROM {currentTable}", whereClause);
            }
        }

        private void checkBoxEdit_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxEdit.Checked)
            {
                checkBox1.Enabled = true;
                dataGridView1.ReadOnly = false;
                dataGridView1.Columns[columnNameID].ReadOnly = true;
            }
            else
                dataGridView1.ReadOnly = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxEdit.Checked)
            {
                if (checkBox1.Checked) { dataGridView1.Columns[columnNameID].ReadOnly = false; }
            }
            else
                dataGridView1.ReadOnly = true;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            foreach (EditData entry in editDataList)
            {
                string columnNameID = entry.ColumnNameID;
                string valueID = entry.ValueID;

                string editedColumnName = entry.EditedColumnName;
                string changedValue = entry.ChangedValues;

                query = $"UPDATE {currentTable} SET {editedColumnName} = '{changedValue}' WHERE {columnNameID} = {valueID}";

                // Now you can use the query to update the database
                FillDataGrid.FillDataGridView(dataGridView1, server, database, username, password, query);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Focus();
        }

        private void dataGridView1_CellEndEdit_1(object sender, DataGridViewCellEventArgs e)
        {
            buttonUpdate.Enabled = true;
            buttonUpdate.Focus();

            if (e.RowIndex >= 0 && e.ColumnIndex != -1)
            {
                int columnIndex = 0; // Declare columnIndex here
                EditData entry = new EditData(); // Create a new EditData object for each entry

                var columnNameID = dataGridView1.Columns[0].Name;
                entry.ColumnNameID = columnNameID;

                if (e.ColumnIndex != columnIndex)
                {
                    var columnName = dataGridView1.Columns[e.ColumnIndex].Name;
                    var row = dataGridView1.Rows[e.RowIndex];
                    entry.EditedColumnName = columnName;

                    if (e.ColumnIndex < row.Cells.Count)
                    {
                        var changedValue = (string)row.Cells[e.ColumnIndex].Value;
                        entry.ChangedValues = changedValue;
                    }
                }

                // Set entry.ValueID outside the inner if block
                object cellValue = dataGridView1.Rows[e.RowIndex].Cells[columnIndex].Value;
                if (cellValue != null)
                {
                    entry.ValueID = cellValue.ToString();
                }

                editDataList.Add(entry);
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            AddData();
        }

        private void buttonSaveNewData_Click(object sender, EventArgs e)
        {
            ClearDataGrid.ClearDataGridView(dataGridView1);
            IsDataInDataGrid = false;
        }

        private void AddData()
        {
            if (!string.IsNullOrEmpty(currentTable))
            {
                if (checkBoxAddData.Checked && IsDataInDataGrid == true)
                {
                    List<DataGridViewColumn> savedColumns = new List<DataGridViewColumn>();
                    foreach (DataGridViewColumn column in dataGridView1.Columns)
                    {
                        savedColumns.Add(column);
                    }
                    dataGridView1.DataSource = null;

                    ClearDataGrid.ClearDataGridView(dataGridView1);

                    foreach (DataGridViewColumn column in savedColumns)
                    {
                        dataGridView1.Columns.Add(column.Clone() as DataGridViewColumn);
                    }
                    object[] rowValues = { "Value1", "Value2", "Value3" };
                    dataGridView1.Rows.Add(rowValues);

                    dataGridView1.ReadOnly = false;

                    buttonSaveNewData.Enabled = true;

                    IsDataInDataGrid = false;
                }
                else
                {
                    dataGridView1.DataSource = dataTable;
                    // Requête SQL pour récupérer toutes les données de la table "joueur"
                    query = $"SELECT * FROM {currentTable}";

                    // Appel de la fonction FillDataGridView pour remplir la grille de données avec les résultats de la requête
                    FillDataGrid.FillDataGridView(dataGridView1, server, database, username, password, query);

                    //popule combobox avec les columns de la table
                    ComboBoxUtils.PopulateComboBoxWithColumnNames(dataGridView1, comboBox1);

                    var ID = dataGridView1.Columns[0].Name;
                    columnNameID = ID.ToString();

                    checkBoxEdit.Enabled = true;
                    checkBox1.Enabled = false;
                    checkBoxAddData.Checked = false;

                    IsDataInDataGrid = true;
                }
            }
            else { IsDataInDataGrid = false; }
        }
    }
}