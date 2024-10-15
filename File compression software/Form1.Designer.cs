namespace File_compression_software
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnSelectFiles;
        private Button btnZip;
        private Button btnUnzip;
        private TextBox txtZipPath;
        private TextBox txtUnzipPath;
        private Label lblZipPath;
        private Label lblUnzipPath;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            btnSelectFiles = new Button();
            btnZip = new Button();
            btnUnzip = new Button();
            txtZipPath = new TextBox();
            txtUnzipPath = new TextBox();
            lblZipPath = new Label();
            lblUnzipPath = new Label();
            SuspendLayout();
            // 
            // btnSelectFiles
            // 
            btnSelectFiles.Location = new Point(30, 30);
            btnSelectFiles.Name = "btnSelectFiles";
            btnSelectFiles.Size = new Size(200, 40);
            btnSelectFiles.TabIndex = 0;
            btnSelectFiles.Text = "Выбрать файлы для сжатия";
            btnSelectFiles.Click += btnSelectFiles_Click;
            // 
            // btnZip
            // 
            btnZip.Location = new Point(30, 90);
            btnZip.Name = "btnZip";
            btnZip.Size = new Size(200, 40);
            btnZip.TabIndex = 1;
            btnZip.Text = "Сжать в ZIP";
            btnZip.Click += btnZip_Click;
            // 
            // btnUnzip
            // 
            btnUnzip.Location = new Point(30, 200);
            btnUnzip.Name = "btnUnzip";
            btnUnzip.Size = new Size(200, 40);
            btnUnzip.TabIndex = 2;
            btnUnzip.Text = "Распаковать ZIP";
            btnUnzip.Click += btnUnzip_Click;
            // 
            // txtZipPath
            // 
            txtZipPath.Location = new Point(30, 160);
            txtZipPath.Name = "txtZipPath";
            txtZipPath.Size = new Size(400, 23);
            txtZipPath.TabIndex = 3;
            // 
            // txtUnzipPath
            // 
            txtUnzipPath.Location = new Point(30, 270);
            txtUnzipPath.Name = "txtUnzipPath";
            txtUnzipPath.Size = new Size(400, 23);
            txtUnzipPath.TabIndex = 4;
            // 
            // lblZipPath
            // 
            lblZipPath.BackColor = Color.Transparent;
            lblZipPath.Location = new Point(30, 133);
            lblZipPath.Name = "lblZipPath";
            lblZipPath.Size = new Size(200, 20);
            lblZipPath.TabIndex = 5;
            lblZipPath.Text = "Путь ZIP файла:";
            // 
            // lblUnzipPath
            // 
            lblUnzipPath.BackColor = Color.Transparent;
            lblUnzipPath.Location = new Point(30, 243);
            lblUnzipPath.Name = "lblUnzipPath";
            lblUnzipPath.Size = new Size(200, 20);
            lblUnzipPath.TabIndex = 6;
            lblUnzipPath.Text = "Путь для распаковки:";
            // 
            // Form1
            // 
            BackgroundImage = Properties.Resources.back;
            ClientSize = new Size(454, 325);
            Controls.Add(btnSelectFiles);
            Controls.Add(btnZip);
            Controls.Add(btnUnzip);
            Controls.Add(txtZipPath);
            Controls.Add(txtUnzipPath);
            Controls.Add(lblZipPath);
            Controls.Add(lblUnzipPath);
            Name = "Form1";
            Text = "зипкаинатор 3000";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
