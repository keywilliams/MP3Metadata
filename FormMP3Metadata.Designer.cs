namespace MP3Metadata
{
    partial class FormMP3Metadata
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMP3Metadata));
            FolderBrowserDialogMP3Path = new FolderBrowserDialog();
            btnSelectFolder = new Button();
            txtPath = new TextBox();
            lblPath = new Label();
            dataGridViewMP3Files = new DataGridView();
            btnProcessFiles = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMP3Files).BeginInit();
            SuspendLayout();
            // 
            // btnSelectFolder
            // 
            btnSelectFolder.Font = new Font("Arial", 10F, FontStyle.Bold);
            btnSelectFolder.Location = new Point(12, 12);
            btnSelectFolder.Name = "btnSelectFolder";
            btnSelectFolder.Size = new Size(947, 25);
            btnSelectFolder.TabIndex = 0;
            btnSelectFolder.Text = "Select Folder";
            btnSelectFolder.UseVisualStyleBackColor = true;
            btnSelectFolder.Click += btnSelectFolder_Click;
            // 
            // txtPath
            // 
            txtPath.Location = new Point(55, 43);
            txtPath.Name = "txtPath";
            txtPath.ReadOnly = true;
            txtPath.Size = new Size(904, 23);
            txtPath.TabIndex = 1;
            txtPath.TextAlign = HorizontalAlignment.Center;
            // 
            // lblPath
            // 
            lblPath.AutoSize = true;
            lblPath.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPath.Location = new Point(12, 47);
            lblPath.Name = "lblPath";
            lblPath.Size = new Size(43, 19);
            lblPath.TabIndex = 2;
            lblPath.Text = "Path:";
            // 
            // dataGridViewMP3Files
            // 
            dataGridViewMP3Files.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewMP3Files.BackgroundColor = SystemColors.Control;
            dataGridViewMP3Files.BorderStyle = BorderStyle.None;
            dataGridViewMP3Files.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMP3Files.Location = new Point(12, 72);
            dataGridViewMP3Files.Name = "dataGridViewMP3Files";
            dataGridViewMP3Files.ReadOnly = true;
            dataGridViewMP3Files.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewMP3Files.Size = new Size(947, 366);
            dataGridViewMP3Files.TabIndex = 3;
            // 
            // btnProcessFiles
            // 
            btnProcessFiles.Font = new Font("Arial", 10F, FontStyle.Bold);
            btnProcessFiles.Location = new Point(12, 455);
            btnProcessFiles.Name = "btnProcessFiles";
            btnProcessFiles.Size = new Size(947, 25);
            btnProcessFiles.TabIndex = 4;
            btnProcessFiles.Text = "Update Tittle";
            btnProcessFiles.UseVisualStyleBackColor = true;
            btnProcessFiles.Click += btnProcessFiles_Click;
            // 
            // FormMP3Metadata
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(971, 492);
            Controls.Add(btnProcessFiles);
            Controls.Add(dataGridViewMP3Files);
            Controls.Add(lblPath);
            Controls.Add(txtPath);
            Controls.Add(btnSelectFolder);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FormMP3Metadata";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MP3 Metadata";
            ((System.ComponentModel.ISupportInitialize)dataGridViewMP3Files).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FolderBrowserDialog FolderBrowserDialogMP3Path;
        private Button btnSelectFolder;
        private TextBox txtPath;
        private Label lblPath;
        private DataGridView dataGridViewMP3Files;
        private Button btnProcessFiles;
    }
}
