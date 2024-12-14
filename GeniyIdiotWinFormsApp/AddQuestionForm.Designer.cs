namespace GeniyIdiotWinFormsApp
{
    partial class AddQuestionForm
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
            ShowTextLabel = new Label();
            ShowAnswerLabel = new Label();
            questionTextBox = new TextBox();
            answerTextBox = new TextBox();
            addButton = new Button();
            SuspendLayout();
            // 
            // ShowTextLabel
            // 
            ShowTextLabel.AutoSize = true;
            ShowTextLabel.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ShowTextLabel.Location = new Point(121, 73);
            ShowTextLabel.Name = "ShowTextLabel";
            ShowTextLabel.Size = new Size(144, 23);
            ShowTextLabel.TabIndex = 0;
            ShowTextLabel.Text = "Текст вопроса";
            // 
            // ShowAnswerLabel
            // 
            ShowAnswerLabel.AutoSize = true;
            ShowAnswerLabel.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ShowAnswerLabel.Location = new Point(121, 173);
            ShowAnswerLabel.Name = "ShowAnswerLabel";
            ShowAnswerLabel.Size = new Size(163, 23);
            ShowAnswerLabel.TabIndex = 1;
            ShowAnswerLabel.Text = "Ответ на вопрос";
            // 
            // questionTextBox
            // 
            questionTextBox.Font = new Font("Cambria", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            questionTextBox.Location = new Point(281, 67);
            questionTextBox.Name = "questionTextBox";
            questionTextBox.Size = new Size(240, 31);
            questionTextBox.TabIndex = 2;
            // 
            // answerTextBox
            // 
            answerTextBox.Font = new Font("Cambria", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            answerTextBox.Location = new Point(290, 167);
            answerTextBox.Name = "answerTextBox";
            answerTextBox.Size = new Size(231, 31);
            answerTextBox.TabIndex = 3;
            // 
            // addButton
            // 
            addButton.CausesValidation = false;
            addButton.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addButton.Location = new Point(126, 251);
            addButton.Name = "addButton";
            addButton.Size = new Size(571, 62);
            addButton.TabIndex = 4;
            addButton.Text = "Добавить";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += AddButton_Click;
            addButton.MouseLeave += AddButton_MouseLeave;
            addButton.MouseHover += AddButton_MouseHover;
            // 
            // AddQuestionForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(792, 422);
            Controls.Add(addButton);
            Controls.Add(answerTextBox);
            Controls.Add(questionTextBox);
            Controls.Add(ShowAnswerLabel);
            Controls.Add(ShowTextLabel);
            Name = "AddQuestionForm";
            Text = "Добавление вопроса";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ShowTextLabel;
        private Label ShowAnswerLabel;
        private TextBox questionTextBox;
        private TextBox answerTextBox;
        private Button addButton;
    }
}