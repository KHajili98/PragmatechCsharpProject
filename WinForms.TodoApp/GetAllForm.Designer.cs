
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnSuspended = new System.Windows.Forms.Button();
            this.btnInCompleted = new System.Windows.Forms.Button();
            this.btnCanceled = new System.Windows.Forms.Button();
            this.btnCompleted = new System.Windows.Forms.Button();
            this.btnPending = new System.Windows.Forms.Button();
            this.btnGetAll = new System.Windows.Forms.Button();
            this.grpBoxList = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCountOfList = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.panelLeftSideBar.SuspendLayout();
            this.groupBoxOperations.SuspendLayout();
            this.grpBoxList.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLeftSideBar
            // 
            this.panelLeftSideBar.Controls.Add(this.groupBoxOperations);
            this.panelLeftSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeftSideBar.Location = new System.Drawing.Point(0, 0);
            this.panelLeftSideBar.Name = "panelLeftSideBar";
            this.panelLeftSideBar.Size = new System.Drawing.Size(267, 727);
            this.panelLeftSideBar.TabIndex = 0;
            // 
            // groupBoxOperations
            // 
            this.groupBoxOperations.Controls.Add(this.label1);
            this.groupBoxOperations.Controls.Add(this.btnSuspended);
            this.groupBoxOperations.Controls.Add(this.btnInCompleted);
            this.groupBoxOperations.Controls.Add(this.btnCanceled);
            this.groupBoxOperations.Controls.Add(this.btnCompleted);
            this.groupBoxOperations.Controls.Add(this.btnPending);
            this.groupBoxOperations.Controls.Add(this.btnGetAll);
            this.groupBoxOperations.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxOperations.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOperations.Name = "groupBoxOperations";
            this.groupBoxOperations.Size = new System.Drawing.Size(254, 727);
            this.groupBoxOperations.TabIndex = 1;
            this.groupBoxOperations.TabStop = false;
            this.groupBoxOperations.Text = "Operations";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(669, 645);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // btnSuspended
            // 
            this.btnSuspended.Location = new System.Drawing.Point(3, 169);
            this.btnSuspended.Name = "btnSuspended";
            this.btnSuspended.Size = new System.Drawing.Size(248, 29);
            this.btnSuspended.TabIndex = 4;
            this.btnSuspended.Text = "Suspended";
            this.btnSuspended.UseVisualStyleBackColor = true;
            this.btnSuspended.Click += new System.EventHandler(this.btnSuspended_Click);
            // 
            // btnInCompleted
            // 
            this.btnInCompleted.Location = new System.Drawing.Point(3, 140);
            this.btnInCompleted.Name = "btnInCompleted";
            this.btnInCompleted.Size = new System.Drawing.Size(248, 29);
            this.btnInCompleted.TabIndex = 3;
            this.btnInCompleted.Text = "InCompleted";
            this.btnInCompleted.UseVisualStyleBackColor = true;
            this.btnInCompleted.Click += new System.EventHandler(this.btnInCompleted_Click);
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
            this.grpBoxList.Controls.Add(this.panel1);
            this.grpBoxList.Controls.Add(this.dataGridView);
            this.grpBoxList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBoxList.Location = new System.Drawing.Point(267, 0);
            this.grpBoxList.Name = "grpBoxList";
            this.grpBoxList.Size = new System.Drawing.Size(975, 727);
            this.grpBoxList.TabIndex = 1;
            this.grpBoxList.TabStop = false;
            this.grpBoxList.Text = "List";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblCountOfList);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 591);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(969, 133);
            this.panel1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(779, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 35);
            this.label2.TabIndex = 3;
            this.label2.Text = "Count : ";
            // 
            // lblCountOfList
            // 
            this.lblCountOfList.AutoSize = true;
            this.lblCountOfList.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCountOfList.Location = new System.Drawing.Point(885, 31);
            this.lblCountOfList.Name = "lblCountOfList";
            this.lblCountOfList.Size = new System.Drawing.Size(29, 35);
            this.lblCountOfList.TabIndex = 4;
            this.lblCountOfList.Text = "0";
            // 
            // dataGridView
            // 
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView.Location = new System.Drawing.Point(3, 23);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 29;
            this.dataGridView.Size = new System.Drawing.Size(969, 568);
            this.dataGridView.TabIndex = 2;
            // 
            // GetAllForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 727);
            this.Controls.Add(this.grpBoxList);
            this.Controls.Add(this.panelLeftSideBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "GetAllForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "GetAllForm";
            this.Load += new System.EventHandler(this.GetAllForm_Load);
            this.panelLeftSideBar.ResumeLayout(false);
            this.groupBoxOperations.ResumeLayout(false);
            this.groupBoxOperations.PerformLayout();
            this.grpBoxList.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Button btnInCompleted;
        private System.Windows.Forms.Button btnSuspended;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCountOfList;
        private System.Windows.Forms.Panel panel1;
    }
}