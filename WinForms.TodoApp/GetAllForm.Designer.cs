
namespace WinForms.TodoApp
{
    partial class GetAllForm
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
            this.panelLeftSideBar = new System.Windows.Forms.Panel();
            this.groupBoxOperations = new System.Windows.Forms.GroupBox();
            this.btnCanceled = new System.Windows.Forms.Button();
            this.btnCompleted = new System.Windows.Forms.Button();
            this.btnPending = new System.Windows.Forms.Button();
            this.btnGetAll = new System.Windows.Forms.Button();
            this.grpBoxList = new System.Windows.Forms.GroupBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.panelLeftSideBar.SuspendLayout();
            this.groupBoxOperations.SuspendLayout();
            this.grpBoxList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLeftSideBar
            // 
            this.panelLeftSideBar.Controls.Add(this.groupBoxOperations);
            this.panelLeftSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeftSideBar.Location = new System.Drawing.Point(0, 0);
            this.panelLeftSideBar.Name = "panelLeftSideBar";
            this.panelLeftSideBar.Size = new System.Drawing.Size(267, 756);
            this.panelLeftSideBar.TabIndex = 0;
            // 
            // groupBoxOperations
            // 
            this.groupBoxOperations.Controls.Add(this.btnCanceled);
            this.groupBoxOperations.Controls.Add(this.btnCompleted);
            this.groupBoxOperations.Controls.Add(this.btnPending);
            this.groupBoxOperations.Controls.Add(this.btnGetAll);
            this.groupBoxOperations.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxOperations.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOperations.Name = "groupBoxOperations";
            this.groupBoxOperations.Size = new System.Drawing.Size(254, 756);
            this.groupBoxOperations.TabIndex = 1;
            this.groupBoxOperations.TabStop = false;
            this.groupBoxOperations.Text = "Operations";
            // 
            // btnCanceled
            // 
            this.btnCanceled.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCanceled.Location = new System.Drawing.Point(3, 110);
            this.btnCanceled.Name = "btnCanceled";
            this.btnCanceled.Size = new System.Drawing.Size(248, 29);
            this.btnCanceled.TabIndex = 2;
            this.btnCanceled.Text = "Canceled";
            this.btnCanceled.UseVisualStyleBackColor = true;
            this.btnCanceled.Click += new System.EventHandler(this.btnCanceled_Click);
            // 
            // btnCompleted
            // 
            this.btnCompleted.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCompleted.Location = new System.Drawing.Point(3, 81);
            this.btnCompleted.Name = "btnCompleted";
            this.btnCompleted.Size = new System.Drawing.Size(248, 29);
            this.btnCompleted.TabIndex = 2;
            this.btnCompleted.Text = "Completed";
            this.btnCompleted.UseVisualStyleBackColor = true;
            this.btnCompleted.Click += new System.EventHandler(this.btnCompleted_Click);
            // 
            // btnPending
            // 
            this.btnPending.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPending.Location = new System.Drawing.Point(3, 52);
            this.btnPending.Name = "btnPending";
            this.btnPending.Size = new System.Drawing.Size(248, 29);
            this.btnPending.TabIndex = 2;
            this.btnPending.Text = "Pending";
            this.btnPending.UseVisualStyleBackColor = true;
            this.btnPending.Click += new System.EventHandler(this.btnPending_Click);
            // 
            // btnGetAll
            // 
            this.btnGetAll.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGetAll.Location = new System.Drawing.Point(3, 23);
            this.btnGetAll.Name = "btnGetAll";
            this.btnGetAll.Size = new System.Drawing.Size(248, 29);
            this.btnGetAll.TabIndex = 2;
            this.btnGetAll.Text = "Get All";
            this.btnGetAll.UseVisualStyleBackColor = true;
            this.btnGetAll.Click += new System.EventHandler(this.btnGetAll_Click);
            // 
            // grpBoxList
            // 
            this.grpBoxList.Controls.Add(this.dataGridView);
            this.grpBoxList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBoxList.Location = new System.Drawing.Point(267, 0);
            this.grpBoxList.Name = "grpBoxList";
            this.grpBoxList.Size = new System.Drawing.Size(1017, 756);
            this.grpBoxList.TabIndex = 1;
            this.grpBoxList.TabStop = false;
            this.grpBoxList.Text = "List";
            // 
            // dataGridView
            // 
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(3, 23);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 29;
            this.dataGridView.Size = new System.Drawing.Size(1011, 730);
            this.dataGridView.TabIndex = 2;
            // 
            // GetAllForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 756);
            this.Controls.Add(this.grpBoxList);
            this.Controls.Add(this.panelLeftSideBar);
            this.Name = "GetAllForm";
            this.Text = "GetAllForm";
            this.Load += new System.EventHandler(this.GetAllForm_Load);
            this.panelLeftSideBar.ResumeLayout(false);
            this.groupBoxOperations.ResumeLayout(false);
            this.grpBoxList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLeftSideBar;
        private System.Windows.Forms.GroupBox groupBoxOperations;
        private System.Windows.Forms.Button btnCanceled;
        private System.Windows.Forms.Button btnCompleted;
        private System.Windows.Forms.Button btnPending;
        private System.Windows.Forms.Button btnGetAll;
        private System.Windows.Forms.GroupBox grpBoxList;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}