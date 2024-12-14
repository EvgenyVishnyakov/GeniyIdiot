namespace GeniyIdiotWinFormsApp
{
    partial class QuestionAnswerForm
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
            ShowQuestionsButton = new Button();
            AddQuestionButton = new Button();
            RemoveQuestionButton = new Button();
            changePasswordButton = new Button();
            SuspendLayout();
            // 
            // ShowQuestionsButton
            // 
            ShowQuestionsButton.BackColor = Color.Silver;
            ShowQuestionsButton.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ShowQuestionsButton.Location = new Point(156, 38);
            ShowQuestionsButton.Name = "ShowQuestionsButton";
            ShowQuestionsButton.Size = new Size(491, 65);
            ShowQuestionsButton.TabIndex = 0;
            ShowQuestionsButton.Text = "Показать список вопросов";
            ShowQuestionsButton.UseVisualStyleBackColor = false;
            ShowQuestionsButton.Click += ShowQuestionsButton_Click;
            ShowQuestionsButton.MouseLeave += ShowQuestionsButton_MouseLeave;
            ShowQuestionsButton.MouseHover += ShowQuestionsButton_MouseHover;
            // 
            // AddQuestionButton
            // 
            AddQuestionButton.BackColor = Color.Silver;
            AddQuestionButton.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddQuestionButton.Location = new Point(156, 125);
            AddQuestionButton.Name = "AddQuestionButton";
            AddQuestionButton.Size = new Size(491, 63);
            AddQuestionButton.TabIndex = 1;
            AddQuestionButton.Text = "Добавить вопрос и ответ";
            AddQuestionButton.UseVisualStyleBackColor = false;
            AddQuestionButton.Click += AddQuestionButton_Click;
            AddQuestionButton.MouseLeave += AddQuestionButton_MouseLeave;
            AddQuestionButton.MouseHover += AddQuestionButton_MouseHover;
            // 
            // RemoveQuestionButton
            // 
            RemoveQuestionButton.BackColor = Color.Silver;
            RemoveQuestionButton.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RemoveQuestionButton.Location = new Point(156, 204);
            RemoveQuestionButton.Name = "RemoveQuestionButton";
            RemoveQuestionButton.Size = new Size(491, 72);
            RemoveQuestionButton.TabIndex = 2;
            RemoveQuestionButton.Text = "Удалить вопрос и ответ";
            RemoveQuestionButton.UseVisualStyleBackColor = false;
            RemoveQuestionButton.Click += RemoveQuestionButton_Click;
            RemoveQuestionButton.MouseLeave += RemoveQuestionButton_MouseLeave;
            RemoveQuestionButton.MouseHover += RemoveQuestionButton_MouseHover;
            // 
            // changePasswordButton
            // 
            changePasswordButton.BackColor = Color.Silver;
            changePasswordButton.Font = new Font("Cambria", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            changePasswordButton.Location = new Point(156, 295);
            changePasswordButton.Name = "changePasswordButton";
            changePasswordButton.Size = new Size(491, 62);
            changePasswordButton.TabIndex = 3;
            changePasswordButton.Text = "Изменить пароль";
            changePasswordButton.UseVisualStyleBackColor = false;
            changePasswordButton.Click += changePasswordButton_Click;
            changePasswordButton.MouseLeave += changePasswordButton_MouseLeave;
            changePasswordButton.MouseHover += changePasswordButton_MouseHover;
            // 
            // QuestionAnswerForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(778, 384);
            Controls.Add(changePasswordButton);
            Controls.Add(RemoveQuestionButton);
            Controls.Add(AddQuestionButton);
            Controls.Add(ShowQuestionsButton);
            Name = "QuestionAnswerForm";
            Text = "Вопрос-ответ";
            ResumeLayout(false);
        }

        #endregion

        private Button ShowQuestionsButton;
        private Button AddQuestionButton;
        private Button RemoveQuestionButton;
        private Button changePasswordButton;
    }
}