namespace KazanNeft_Desktop.Views.EmployeeForms
{
    partial class MainEmployeeForm
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
            label1 = new Label();
            requestBtn = new Button();
            emergencyTable = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)emergencyTable).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Myriad Pro", 13.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(35, 10);
            label1.Name = "label1";
            label1.Size = new Size(290, 28);
            label1.TabIndex = 5;
            label1.Text = "List of Assets Requesting EM:";
            // 
            // requestBtn
            // 
            requestBtn.FlatStyle = FlatStyle.Flat;
            requestBtn.Font = new Font("Myriad Pro", 13.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            requestBtn.ForeColor = Color.White;
            requestBtn.Location = new Point(683, 432);
            requestBtn.Name = "requestBtn";
            requestBtn.Size = new Size(265, 40);
            requestBtn.TabIndex = 4;
            requestBtn.Text = "Manage Request";
            requestBtn.UseVisualStyleBackColor = true;
            requestBtn.Click += RequestBtn_Click;
            // 
            // emergencyTable
            // 
            emergencyTable.BackgroundColor = Color.White;
            emergencyTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            emergencyTable.Location = new Point(35, 46);
            emergencyTable.Name = "emergencyTable";
            emergencyTable.RowHeadersWidth = 51;
            emergencyTable.Size = new Size(913, 373);
            emergencyTable.TabIndex = 3;
            emergencyTable.CellClick += EmergencyTable_CellClick;
            // 
            // MainEmployeeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 92, 185);
            ClientSize = new Size(982, 483);
            Controls.Add(label1);
            Controls.Add(requestBtn);
            Controls.Add(emergencyTable);
            Name = "MainEmployeeForm";
            Text = "MainEmployeeForm";
            ((System.ComponentModel.ISupportInitialize)emergencyTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button requestBtn;
        private DataGridView emergencyTable;
    }
}