namespace GeniyIdiotWinFormsApp
{
    partial class GameForm
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
            components = new System.ComponentModel.Container();
            nextButton = new Button();
            questionNumberLabel = new Label();
            questionTextLabel = new Label();
            userAnswerTextBox = new TextBox();
            showResults = new ToolStripTextBox();
            buttonExit = new ToolStripTextBox();
            menuStrip1 = new MenuStrip();
            Timer = new System.Windows.Forms.Timer(components);
            TimerLabel = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // nextButton
            // 
            nextButton.BackColor = SystemColors.ButtonHighlight;
            nextButton.Font = new Font("Cambria", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nextButton.Location = new Point(134, 256);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(672, 116);
            nextButton.TabIndex = 0;
            nextButton.Text = "Далее";
            nextButton.UseVisualStyleBackColor = false;
            nextButton.Click += NextButton_Click;
            // 
            // questionNumberLabel
            // 
            questionNumberLabel.AutoSize = true;
            questionNumberLabel.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            questionNumberLabel.Location = new Point(106, 65);
            questionNumberLabel.Name = "questionNumberLabel";
            questionNumberLabel.Size = new Size(119, 23);
            questionNumberLabel.TabIndex = 1;
            questionNumberLabel.Text = "Вопрос № 1";
            // 
            // questionTextLabel
            // 
            questionTextLabel.AutoSize = true;
            questionTextLabel.Font = new Font("Cambria", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            questionTextLabel.Location = new Point(106, 130);
            questionTextLabel.Name = "questionTextLabel";
            questionTextLabel.Size = new Size(140, 23);
            questionTextLabel.TabIndex = 2;
            questionTextLabel.Text = "Текст вопроса";
            questionTextLabel.Click += questionTextLabel_Click;
            // 
            // userAnswerTextBox
            // 
            userAnswerTextBox.Font = new Font("Cambria", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userAnswerTextBox.Location = new Point(284, 187);
            userAnswerTextBox.Name = "userAnswerTextBox";
            userAnswerTextBox.Size = new Size(338, 43);
            userAnswerTextBox.TabIndex = 3;
            userAnswerTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // showResults
            // 
            showResults.BackColor = SystemColors.ButtonHighlight;
            showResults.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            showResults.Name = "showResults";
            showResults.Size = new Size(449, 38);
            showResults.Text = "Показать результаты игры";
            // 
            // buttonExit
            // 
            buttonExit.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(597, 38);
            buttonExit.Text = "Выход";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(955, 24);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // Timer
            // 
            Timer.Interval = 1000;
            Timer.Tick += Timer_Tick;
            // 
            // TimerLabel
            // 
            TimerLabel.AutoSize = true;
            TimerLabel.BackColor = Color.FromArgb(128, 255, 128);
            TimerLabel.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TimerLabel.Location = new Point(557, 47);
            TimerLabel.Name = "TimerLabel";
            TimerLabel.Size = new Size(174, 23);
            TimerLabel.TabIndex = 5;
            TimerLabel.Text = "Осталось секунд:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(754, 49);
            label2.Name = "label2";
            label2.Size = new Size(0, 21);
            label2.TabIndex = 6;
            // 
            // GameForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(955, 435);
            Controls.Add(label2);
            Controls.Add(TimerLabel);
            Controls.Add(userAnswerTextBox);
            Controls.Add(questionTextLabel);
            Controls.Add(questionNumberLabel);
            Controls.Add(nextButton);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "GameForm";
            Text = "Гений Идиот";
            Load += MainForm_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button nextButton;
        private Label questionNumberLabel;
        private Label questionTextLabel;
        public TextBox userAnswerTextBox;        
        private ToolStripTextBox buttonExit;        
        private ToolStripTextBox showResults;
        public ToolStripItem restartButton;
        private MenuStrip menuStrip1;
        private System.Windows.Forms.Timer Timer;
        private Label TimerLabel;
        private Label label2;
    }
}
