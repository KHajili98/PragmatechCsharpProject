
namespace WorkingWithSystemIO
{
    partial class Form
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
            this.btnOpen = new System.Windows.Forms.Button();
            this.folderBrowserDialogOpenFile = new System.Windows.Forms.FolderBrowserDialog();
            this.dataGridViewFileTable = new System.Windows.Forms.DataGridView();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxFileName = new System.Windows.Forms.TextBox();
            this.textBoxFolderName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCreateFile = new System.Windows.Forms.Button();
            this.btnCreateFolder = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFileTable)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(1369, 343);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(183, 53);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Load Directory";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // dataGridViewFileTable
            // 
            this.dataGridViewFileTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFileTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.Type});
            this.dataGridViewFileTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewFileTable.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewFileTable.Name = "dataGridViewFileTable";
            this.dataGridViewFileTable.RowHeadersWidth = 51;
            this.dataGridViewFileTable.RowTemplate.Height = 29;
            this.dataGridViewFileTable.Size = new System.Drawing.Size(1564, 328);
            this.dataGridViewFileTable.TabIndex = 1;
            this.dataGridViewFileTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFileTable_CellContentClick);
            // 
            // Name
            // 
            this.Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Name.HeaderText = "Name";
            this.Name.MinimumWidth = 6;
            this.Name.Name = "Name";
            // 
            // Type
            // 
            this.Type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Type.HeaderText = "Type";
            this.Type.MinimumWidth = 6;
            this.Type.Name = "Type";
            // 
            // textBoxFileName
            // 
            this.textBoxFileName.Location = new System.Drawing.Point(72, 369);
            this.textBoxFileName.Name = "textBoxFileName";
            this.textBoxFileName.Size = new System.Drawing.Size(467, 27);
            this.textBoxFileName.TabIndex = 2;
            // 
            // textBoxFolderName
            // 
            this.textBoxFolderName.Location = new System.Drawing.Point(72, 411);
            this.textBoxFolderName.Name = "textBoxFolderName";
            this.textBoxFolderName.Size = new System.Drawing.Size(467, 27);
            this.textBoxFolderName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 376);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "File";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 418);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Folder";
            // 
            // btnCreateFile
            // 
            this.btnCreateFile.Location = new System.Drawing.Point(571, 367);
            this.btnCreateFile.Name = "btnCreateFile";
            this.btnCreateFile.Size = new System.Drawing.Size(147, 29);
            this.btnCreateFile.TabIndex = 4;
            this.btnCreateFile.Text = "Create File";
            this.btnCreateFile.UseVisualStyleBackColor = true;
            this.btnCreateFile.Click += new System.EventHandler(this.btnCreateFile_Click);
            // 
            // btnCreateFolder
            // 
            this.btnCreateFolder.Location = new System.Drawing.Point(571, 409);
            this.btnCreateFolder.Name = "btnCreateFolder";
            this.btnCreateFolder.Size = new System.Drawing.Size(147, 29);
            this.btnCreateFolder.TabIndex = 4;
            this.btnCreateFolder.Text = "Create Folder";
            this.btnCreateFolder.UseVisualStyleBackColor = true;
            this.btnCreateFolder.Click += new System.EventHandler(this.btnCreateFolder_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.richTextBox1.Location = new System.Drawing.Point(0, 477);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1564, 308);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Enabled = false;
            this.btnSaveChanges.Location = new System.Drawing.Point(1369, 429);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(183, 42);
            this.btnSaveChanges.TabIndex = 6;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1564, 785);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnCreateFolder);
            this.Controls.Add(this.btnCreateFile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxFolderName);
            this.Controls.Add(this.textBoxFileName);
            this.Controls.Add(this.dataGridViewFileTable);
            this.Controls.Add(this.btnOpen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Page";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFileTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogOpenFile;
        private System.Windows.Forms.DataGridView dataGridViewFileTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.TextBox textBoxFileName;
        private System.Windows.Forms.TextBox textBoxFolderName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCreateFile;
        private System.Windows.Forms.Button btnCreateFolder;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnSaveChanges;
    }
}

