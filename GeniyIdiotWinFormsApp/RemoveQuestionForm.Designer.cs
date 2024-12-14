namespace GeniyIdiotWinFormsApp
{
    partial class RemoveQuestionForm
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
            questionsDataGridView = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            RemoveButton = new Button();
            ((System.ComponentModel.ISupportInitialize)questionsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // questionsDataGridView
            // 
            questionsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            questionsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            questionsDataGridView.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            questionsDataGridView.Location = new Point(0, 39);
            questionsDataGridView.Name = "questionsDataGridView";
            questionsDataGridView.RightToLeft = RightToLeft.No;
            questionsDataGridView.RowHeadersWidth = 51;
            questionsDataGridView.Size = new Size(908, 250);
            questionsDataGridView.TabIndex = 1;
            // 
            // Column1
            // 
            Column1.HeaderText = "Текст вопроса";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 158;
            // 
            // Column2
            // 
            Column2.HeaderText = "Ответ";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 95;
            // 
            // RemoveButton
            // 
            RemoveButton.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RemoveButton.Location = new Point(0, 0);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(210, 39);
            RemoveButton.TabIndex = 2;
            RemoveButton.Text = "Удалить";
            RemoveButton.UseVisualStyleBackColor = true;
            RemoveButton.Click += RemoveButton_Click;
            // 
            // RemoveQuestionForm
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(904, 289);
            Controls.Add(RemoveButton);
            Controls.Add(questionsDataGridView);
            Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "RemoveQuestionForm";
            Text = "Удаление вопроса";
            Load += RemoveQuestionForm_Load;
            ((System.ComponentModel.ISupportInitialize)questionsDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView questionsDataGridView;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private Button RemoveButton;
    }
}