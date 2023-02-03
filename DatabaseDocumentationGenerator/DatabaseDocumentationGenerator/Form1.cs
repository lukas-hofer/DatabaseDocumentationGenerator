namespace DatabaseDocumentationGenerator
{
    public partial class DatabaseDocumentationGenerator : Form
    {
        public DatabaseDocumentationGenerator()
        {
            InitializeComponent();
        }

        string[] createScriptsSql;
        string csv;

        private void openCreateScriptFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                createScriptsSql = File.ReadAllLines(openFileDialog.FileName);


                textboxCreateScripts.Text = String.Empty;
                foreach (string line in createScriptsSql)
                {

                    textboxCreateScripts.Text += (line) + "\r\n";
                }

                textboxCsv.Text = convertToTableCsv();
                insertFileName.Text = openFileDialog.FileName;
            }

            

            

        }


        private string convertToTableCsv()
        {
            string csv = String.Empty;

            foreach (string line in createScriptsSql)
            {
                //create Statement
                if (line.StartsWith("CREATE TABLE"))
                {
                    string tableName = line.Split("CREATE TABLE ")[1].Split(" ")[0];
                    csv += tableName + "\r\n";


                    string[] tableRows = line.Split("(")[1].Split(")")[0].Split(",");

                    csv += "Name;Type;Nullable\r\n";

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

                        string rowName = row.Split(" ")[0];
                        string dataType = row.Split(" ")[1];
                        bool nullable = true;

                        if (row.Contains("NOT NULL"))
                        {
                            nullable = false;
                        }

                        csv += (rowName + ";" + dataType + ";" + nullable + "\r\n");
                    }

                    
                }
            }

            this.csv = csv;
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
                byte[] pdf = pdfGenerator.generatePdfOutOfCsv(this.csv);

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