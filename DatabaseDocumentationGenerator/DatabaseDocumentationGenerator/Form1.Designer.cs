namespace DatabaseDocumentationGenerator
{
    partial class DatabaseDocumentationGenerator
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
            this.importScript = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.insertFileName = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.openCreateScriptFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textboxCreateScripts = new System.Windows.Forms.TextBox();
            this.DataCatalog = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonSaveCsv = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonCsvToPdf = new System.Windows.Forms.Button();
            this.textboxCsv = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.importScript.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.DataCatalog.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.importScript);
            this.tabControl1.Controls.Add(this.DataCatalog);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(802, 449);
            this.tabControl1.TabIndex = 0;
            // 
            // importScript
            // 
            this.importScript.Controls.Add(this.tableLayoutPanel4);
            this.importScript.Location = new System.Drawing.Point(4, 24);
            this.importScript.Name = "importScript";
            this.importScript.Size = new System.Drawing.Size(794, 421);
            this.importScript.TabIndex = 1;
            this.importScript.Text = "importScript";
            this.importScript.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.insertFileName, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.textboxCreateScripts, 0, 2);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(788, 415);
            this.tableLayoutPanel4.TabIndex = 8;
            // 
            // insertFileName
            // 
            this.insertFileName.AutoSize = true;
            this.insertFileName.Location = new System.Drawing.Point(3, 40);
            this.insertFileName.Name = "insertFileName";
            this.insertFileName.Size = new System.Drawing.Size(0, 15);
            this.insertFileName.TabIndex = 8;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.Controls.Add(this.openCreateScriptFile, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(782, 34);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // openCreateScriptFile
            // 
            this.openCreateScriptFile.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.openCreateScriptFile.Location = new System.Drawing.Point(704, 5);
            this.openCreateScriptFile.Name = "openCreateScriptFile";
            this.openCreateScriptFile.Size = new System.Drawing.Size(75, 23);
            this.openCreateScriptFile.TabIndex = 3;
            this.openCreateScriptFile.Text = "open File";
            this.openCreateScriptFile.UseVisualStyleBackColor = true;
            this.openCreateScriptFile.Click += new System.EventHandler(this.openCreateScriptFile_Click_1);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Table Create Scripts";
            // 
            // textboxCreateScripts
            // 
            this.textboxCreateScripts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textboxCreateScripts.Location = new System.Drawing.Point(3, 63);
            this.textboxCreateScripts.Multiline = true;
            this.textboxCreateScripts.Name = "textboxCreateScripts";
            this.textboxCreateScripts.PlaceholderText = "import SQL Script";
            this.textboxCreateScripts.ReadOnly = true;
            this.textboxCreateScripts.Size = new System.Drawing.Size(782, 349);
            this.textboxCreateScripts.TabIndex = 7;
            // 
            // DataCatalog
            // 
            this.DataCatalog.Controls.Add(this.tableLayoutPanel1);
            this.DataCatalog.Location = new System.Drawing.Point(4, 24);
            this.DataCatalog.Name = "DataCatalog";
            this.DataCatalog.Padding = new System.Windows.Forms.Padding(3);
            this.DataCatalog.Size = new System.Drawing.Size(794, 421);
            this.DataCatalog.TabIndex = 0;
            this.DataCatalog.Text = "DataCatalog";
            this.DataCatalog.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textboxCsv, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 418);
            this.tableLayoutPanel1.TabIndex = 4;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.Controls.Add(this.buttonSaveCsv, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.buttonCsvToPdf, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(778, 34);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // buttonSaveCsv
            // 
            this.buttonSaveCsv.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonSaveCsv.Location = new System.Drawing.Point(703, 5);
            this.buttonSaveCsv.Name = "buttonSaveCsv";
            this.buttonSaveCsv.Size = new System.Drawing.Size(72, 23);
            this.buttonSaveCsv.TabIndex = 6;
            this.buttonSaveCsv.Text = "save Csv";
            this.buttonSaveCsv.UseVisualStyleBackColor = true;
            this.buttonSaveCsv.Click += new System.EventHandler(this.buttonSaveCsv_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Data Catalog as *.csv";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // buttonCsvToPdf
            // 
            this.buttonCsvToPdf.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonCsvToPdf.Location = new System.Drawing.Point(626, 5);
            this.buttonCsvToPdf.Name = "buttonCsvToPdf";
            this.buttonCsvToPdf.Size = new System.Drawing.Size(71, 23);
            this.buttonCsvToPdf.TabIndex = 7;
            this.buttonCsvToPdf.Text = "save Pdf";
            this.buttonCsvToPdf.UseVisualStyleBackColor = true;
            this.buttonCsvToPdf.Click += new System.EventHandler(this.buttonCsvToPdf_Click);
            // 
            // textboxCsv
            // 
            this.textboxCsv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textboxCsv.Location = new System.Drawing.Point(3, 63);
            this.textboxCsv.Multiline = true;
            this.textboxCsv.Name = "textboxCsv";
            this.textboxCsv.ReadOnly = true;
            this.textboxCsv.Size = new System.Drawing.Size(778, 352);
            this.textboxCsv.TabIndex = 6;
            // 
            // DatabaseDocumentationGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "DatabaseDocumentationGenerator";
            this.Text = "DatabaseDocumentationGenerator";
            this.tabControl1.ResumeLayout(false);
            this.importScript.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.DataCatalog.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage DataCatalog;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel3;
        private Button buttonSaveCsv;
        private TextBox textboxCsv;
        private Button buttonCsvToPdf;
        private TabPage importScript;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel2;
        private Button openCreateScriptFile;
        private Label label1;
        private TextBox textboxCreateScripts;
        private Label insertFileName;
    }
}