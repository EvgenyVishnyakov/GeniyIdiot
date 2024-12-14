namespace GeniyIdiotWinFormsApp
{
    partial class ResultsForm
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            resultsDataGridView = new DataGridView();
            userNameColumn = new DataGridViewTextBoxColumn();
            userRightAnswers = new DataGridViewTextBoxColumn();
            userDiagnoses = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)resultsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // resultsDataGridView
            // 
            resultsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resultsDataGridView.Columns.AddRange(new DataGridViewColumn[] { userNameColumn, userRightAnswers, userDiagnoses });
            resultsDataGridView.Location = new Point(-1, 0);
            resultsDataGridView.Name = "resultsDataGridView";
            resultsDataGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            resultsDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            resultsDataGridView.Size = new Size(713, 304);
            resultsDataGridView.TabIndex = 0;
            // 
            // userNameColumn
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.Silver;
            dataGridViewCellStyle1.Font = new Font("Cambria", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.NullValue = null;
            userNameColumn.DefaultCellStyle = dataGridViewCellStyle1;
            userNameColumn.HeaderText = "Имя";
            userNameColumn.MinimumWidth = 6;
            userNameColumn.Name = "userNameColumn";
            userNameColumn.ReadOnly = true;
            userNameColumn.Width = 125;
            // 
            // userRightAnswers
            // 
            userRightAnswers.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new Font("Cambria", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Silver;
            userRightAnswers.DefaultCellStyle = dataGridViewCellStyle2;
            userRightAnswers.HeaderText = "Ваши верные ответы";
            userRightAnswers.MinimumWidth = 6;
            userRightAnswers.Name = "userRightAnswers";
            userRightAnswers.ReadOnly = true;
            // 
            // userDiagnoses
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new Font("Cambria", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.Silver;
            userDiagnoses.DefaultCellStyle = dataGridViewCellStyle3;
            userDiagnoses.HeaderText = "Диагноз";
            userDiagnoses.MinimumWidth = 6;
            userDiagnoses.Name = "userDiagnoses";
            userDiagnoses.ReadOnly = true;
            userDiagnoses.Width = 125;
            // 
            // ResultsForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(711, 301);
            Controls.Add(resultsDataGridView);
            Name = "ResultsForm";
            Text = "ResultsForm";
            Load += ResultsForm_Load;
            ((System.ComponentModel.ISupportInitialize)resultsDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public DataGridView resultsDataGridView;
        private DataGridViewTextBoxColumn userNameColumn;
        private DataGridViewTextBoxColumn userRightAnswers;
        private DataGridViewTextBoxColumn userDiagnoses;
    }
}