namespace DatabaseDocumentationGenerator
{
    public partial class DatabaseDocumentationGenerator : Form
    {
        public DatabaseDocumentationGenerator()
        {
            InitializeComponent();
        }

        string[] createScriptsSql;

        private void openCreateScriptFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                createScriptsSql = File.ReadAllLines(openFileDialog.FileName);


                textboxCreateScripts.Text = String.Empty;
                foreach (string line in createScriptsSql)
                {

                    textboxCreateScripts.Text += line;
                }
            }

            insertFileName.Text = openFileDialog.FileName;

            convertToTableCsv();

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
                    textboxCsv.Text += tableName + " ";
                }
            }


            return csv;
        }
    }
}