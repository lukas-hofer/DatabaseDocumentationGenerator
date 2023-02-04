namespace DatabaseDocumentationGenerator
{
    public partial class DatabaseDocumentationGenerator : Form
    {
        public DatabaseDocumentationGenerator()
        {
            InitializeComponent();
        }
        
        string csv;
        List<SqlTable> tables = new List<SqlTable>();

        private void openCreateScriptFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string[] createScriptsSql = File.ReadAllText(openFileDialog.FileName).Replace("\r\n","").Split(";");


                textboxCreateScripts.Text = String.Empty;
                foreach (string line in createScriptsSql)
                {
                    textboxCreateScripts.Text += (line) + "\r\n";
                }

                insertFileName.Text = openFileDialog.FileName;
                
                this.tables = convertCreateScripts(createScriptsSql);
                textboxCsv.Text = createCsv(this.tables);
            }

            

            

        }

        private List<SqlTable> convertCreateScripts(string[] createScript)
        {
            List<SqlTable> tables = new List<SqlTable>();


            foreach (string line in createScript)
            {
                //create Statement
                if (line.StartsWith("CREATE TABLE"))
                {
                    string tableName = line.Split("CREATE TABLE ")[1].Split(" ")[0];

                    SqlTable table = new SqlTable();
                    table.name = tableName;

                    string[] tableRows = line.Split("(")[1].Split(")")[0].Split(",");

                    foreach (string currentRow in tableRows)
                    {
                        string row = currentRow;

                        if (row.StartsWith(" "))
                        {
                            row = row.TrimStart();
                        }

                        if (row.StartsWith("PRIMARY KEY"))
                        {
                            continue;
                        }

                        string colName = row.Split(" ")[0];
                        string dataType = row.Split(" ")[1];
                        bool nullable = true;

                        if (row.Contains("NOT NULL"))
                        {
                            nullable = false;
                        }

                        SqlTableCol tableCol = new SqlTableCol();
                        tableCol.name = colName;
                        tableCol.datatype = dataType;
                        tableCol.nullable = nullable;
                        table.sqlTableColumns.Add(tableCol);
                    }
                    tables.Add(table);
                }
            }




            return tables;
        }


        private string createCsv(List<SqlTable> tables)
        {
            string csv = String.Empty;

            foreach (SqlTable table in tables)
            {
                csv += (table.name + "\r\n");
                csv += ("Name;Type;Nullable" + "\r\n");
                foreach (SqlTableCol col in table.sqlTableColumns)
                {
                    csv += (String.Format("{0};{1};{2}", col.name, col.datatype, col.nullable) + "\r\n");
                }
            }

            return csv;
        }

        private void buttonSaveCsv_Click(object sender, EventArgs e)
        {
            if (textboxCsv.Text != String.Empty)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*";
                saveFileDialog.RestoreDirectory = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog.FileName, textboxCsv.Text);
                }
            }
            else
            {
                MessageBox.Show("Nothing to save.");
            }
        }

        private void generatePdf()
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonCsvToPdf_Click(object sender, EventArgs e)
        {

            if (textboxCsv.Text != String.Empty)
            {
                PdfGenerator pdfGenerator = new PdfGenerator();
                byte[] pdf = pdfGenerator.generateCatalogPdf(this.tables);

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "pdf files (*.pdf)|*.pdf|All files (*.*)|*.*";
                saveFileDialog.RestoreDirectory = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllBytes(saveFileDialog.FileName, pdf);
                }
            } else
            {
                MessageBox.Show("Nothing to save");
            }



        }
    }
}