
namespace WinForms.TodoApp
{
    partial class NewTodoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtBoxTitle = new System.Windows.Forms.TextBox();
            this.lblShortDesc = new System.Windows.Forms.Label();
            this.txtBoxShortDesc = new System.Windows.Forms.TextBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.txtBoxDesc = new System.Windows.Forms.TextBox();
            this.lblILevel = new System.Windows.Forms.Label();
            this.txtImportanceLevel = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(33, 41);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(38, 20);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title";
            // 
            // txtBoxTitle
            // 
            this.txtBoxTitle.Location = new System.Drawing.Point(171, 38);
            this.txtBoxTitle.Name = "txtBoxTitle";
            this.txtBoxTitle.Size = new System.Drawing.Size(330, 27);
            this.txtBoxTitle.TabIndex = 0;
            this.txtBoxTitle.Enter += new System.EventHandler(this.txtBox_Enter);
            this.txtBoxTitle.Leave += new System.EventHandler(this.txtBox_Leave);
            // 
            // lblShortDesc
            // 
            this.lblShortDesc.AutoSize = true;
            this.lblShortDesc.Location = new System.Drawing.Point(33, 104);
            this.lblShortDesc.Name = "lblShortDesc";
            this.lblShortDesc.Size = new System.Drawing.Size(122, 20);
            this.lblShortDesc.TabIndex = 0;
            this.lblShortDesc.Text = "Short description";
            // 
            // txtBoxShortDesc
            // 
            this.txtBoxShortDesc.Location = new System.Drawing.Point(171, 101);
            this.txtBoxShortDesc.Multiline = true;
            this.txtBoxShortDesc.Name = "txtBoxShortDesc";
            this.txtBoxShortDesc.Size = new System.Drawing.Size(330, 124);
            this.txtBoxShortDesc.TabIndex = 1;
            this.txtBoxShortDesc.Enter += new System.EventHandler(this.txtBox_Enter);
            this.txtBoxShortDesc.Leave += new System.EventHandler(this.txtBox_Leave);
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(33, 270);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(85, 20);
            this.lblDesc.TabIndex = 0;
            this.lblDesc.Text = "Description";
            // 
            // txtBoxDesc
            // 
            this.txtBoxDesc.Location = new System.Drawing.Point(171, 267);
            this.txtBoxDesc.Multiline = true;
            this.txtBoxDesc.Name = "txtBoxDesc";
            this.txtBoxDesc.Size = new System.Drawing.Size(330, 153);
            this.txtBoxDesc.TabIndex = 2;
            this.txtBoxDesc.Enter += new System.EventHandler(this.txtBox_Enter);
            this.txtBoxDesc.Leave += new System.EventHandler(this.txtBox_Leave);
            // 
            // lblILevel
            // 
            this.lblILevel.AutoSize = true;
            this.lblILevel.Location = new System.Drawing.Point(33, 446);
            this.lblILevel.Name = "lblILevel";
            this.lblILevel.Size = new System.Drawing.Size(123, 20);
            this.lblILevel.TabIndex = 0;
            this.lblILevel.Text = "Importance Level";
            // 
            // txtImportanceLevel
            // 
            this.txtImportanceLevel.Location = new System.Drawing.Point(171, 443);
            this.txtImportanceLevel.Name = "txtImportanceLevel";
            this.txtImportanceLevel.Size = new System.Drawing.Size(330, 27);
            this.txtImportanceLevel.TabIndex = 3;
            this.txtImportanceLevel.Enter += new System.EventHandler(this.txtBox_Enter);
            this.txtImportanceLevel.Leave += new System.EventHandler(this.txtBox_Leave);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(33, 507);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(49, 20);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "Status";
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Location = new System.Drawing.Point(171, 503);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(330, 28);
            this.comboBoxStatus.TabIndex = 4;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(256, 576);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(245, 41);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // NewTodoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 641);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.txtImportanceLevel);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblILevel);
            this.Controls.Add(this.txtBoxDesc);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.txtBoxShortDesc);
            this.Controls.Add(this.lblShortDesc);
            this.Controls.Add(this.txtBoxTitle);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "NewTodoForm";
            this.Text = "New Todo Form";
            this.Load += new System.EventHandler(this.NewTodoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtBoxTitle;
        private System.Windows.Forms.Label lblShortDesc;
        private System.Windows.Forms.TextBox txtBoxShortDesc;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.TextBox txtBoxDesc;
        private System.Windows.Forms.Label lblILevel;
        private System.Windows.Forms.TextBox txtImportanceLevel;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.Button btnSave;
    }
}