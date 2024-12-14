namespace GeniyIdiotWinFormsApp
{
    partial class WelcomeFormGame
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
        public void InitializeComponent()
        {
            userNameTextBox = new TextBox();
            userStartButton = new Button();
            userWelcomeLabel = new Label();
            userWelcomeLabel2 = new Label();
            SuspendLayout();
            // 
            // userNameTextBox
            // 
            userNameTextBox.Font = new Font("Cambria", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            userNameTextBox.Location = new Point(200, 203);
            userNameTextBox.Name = "userNameTextBox";
            userNameTextBox.Size = new Size(438, 46);
            userNameTextBox.TabIndex = 0;
            userNameTextBox.TextAlign = HorizontalAlignment.Center;
            //userNameTextBox.TextChanged += userNameTextBox_TextChanged;
            // 
            // userStartButton
            // 
            userStartButton.Font = new Font("Cambria", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            userStartButton.Location = new Point(258, 275);
            userStartButton.Name = "userStartButton";
            userStartButton.Size = new Size(318, 103);
            userStartButton.TabIndex = 1;
            userStartButton.Text = "Начать!";
            userStartButton.UseVisualStyleBackColor = true;
            userStartButton.Click += StartUserButton_Click;
            // 
            // userWelcomeLabel
            // 
            userWelcomeLabel.AutoSize = true;
            userWelcomeLabel.Font = new Font("Cambria", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            userWelcomeLabel.Location = new Point(200, 80);
            userWelcomeLabel.Name = "userWelcomeLabel";
            userWelcomeLabel.Size = new Size(438, 40);
            userWelcomeLabel.TabIndex = 2;
            userWelcomeLabel.Text = "Добро пожаловать в игру!";
            // 
            // userWelcomeLabel2
            // 
            userWelcomeLabel2.AutoSize = true;
            userWelcomeLabel2.Font = new Font("Cambria", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            userWelcomeLabel2.Location = new Point(258, 137);
            userWelcomeLabel2.Name = "userWelcomeLabel2";
            userWelcomeLabel2.Size = new Size(318, 40);
            userWelcomeLabel2.TabIndex = 3;
            userWelcomeLabel2.Text = "Введите Ваше имя";
            // 
            // WelcomeFormGame
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(782, 453);
            Controls.Add(userWelcomeLabel2);
            Controls.Add(userWelcomeLabel);
            Controls.Add(userStartButton);
            Controls.Add(userNameTextBox);
            ForeColor = Color.Black;
            Name = "WelcomeFormGame";
            Text = "Welcome To Game!";
            //Load += welcomeFormGame_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public TextBox userNameTextBox;
        private Button userStartButton;
        private Label userWelcomeLabel;
        public Label userWelcomeLabel2;
        private Label label2;
    }
}