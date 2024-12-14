namespace GeniyIdiotWinFormsApp
{
    partial class ChoiceForm
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
            components = new System.ComponentModel.Container();
            timer1 = new System.Windows.Forms.Timer(components);
            menuStrip1 = new MenuStrip();
            StartGameButton = new Button();
            ShowResultButton = new Button();
            ExitGameButton = new Button();
            ShowRulesButton = new Button();
            GetAdminButton = new Button();
            ChoiceLabel = new Label();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "Выбор дальнейших действий";
            // 
            // StartGameButton
            // 
            StartGameButton.BackColor = SystemColors.ControlLight;
            StartGameButton.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            StartGameButton.Location = new Point(193, 144);
            StartGameButton.Name = "StartGameButton";
            StartGameButton.Size = new Size(428, 74);
            StartGameButton.TabIndex = 2;
            StartGameButton.Text = "Начать играть";
            StartGameButton.UseVisualStyleBackColor = false;
            StartGameButton.Click += StartGameButton_Click_1;
            StartGameButton.MouseLeave += StartGameButton_MouseLeave;
            StartGameButton.MouseHover += StartGameButton_MouseHover;
            // 
            // ShowResultButton
            // 
            ShowResultButton.BackColor = SystemColors.ControlLight;
            ShowResultButton.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ShowResultButton.Location = new Point(193, 224);
            ShowResultButton.Name = "ShowResultButton";
            ShowResultButton.Size = new Size(428, 71);
            ShowResultButton.TabIndex = 3;
            ShowResultButton.Text = "Показать результаты игр";
            ShowResultButton.UseVisualStyleBackColor = false;
            ShowResultButton.Click += ShowResultButton_Click;
            ShowResultButton.MouseLeave += ShowResultButton_MouseLeave;
            ShowResultButton.MouseHover += ShowResultButton_MouseHover;
            // 
            // ExitGameButton
            // 
            ExitGameButton.BackColor = SystemColors.ControlLight;
            ExitGameButton.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ExitGameButton.Location = new Point(193, 365);
            ExitGameButton.Name = "ExitGameButton";
            ExitGameButton.Size = new Size(428, 60);
            ExitGameButton.TabIndex = 4;
            ExitGameButton.Text = "Выход";
            ExitGameButton.UseVisualStyleBackColor = false;
            ExitGameButton.Click += ExitGameButton_Click;
            ExitGameButton.MouseLeave += ExitGameButton_MouseLeave;
            ExitGameButton.MouseHover += ExitGameButton_MouseHover_1;
            // 
            // ShowRulesButton
            // 
            ShowRulesButton.BackColor = SystemColors.ControlLight;
            ShowRulesButton.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ShowRulesButton.Location = new Point(193, 74);
            ShowRulesButton.Name = "ShowRulesButton";
            ShowRulesButton.Size = new Size(428, 64);
            ShowRulesButton.TabIndex = 5;
            ShowRulesButton.Text = "Правила игры";
            ShowRulesButton.UseVisualStyleBackColor = false;
            ShowRulesButton.Click += ShowRulesButton_Click;
            ShowRulesButton.MouseLeave += ShowRulesButton_MouseLeave;
            ShowRulesButton.MouseHover += ShowRulesButton_MouseHover;
            // 
            // GetAdminButton
            // 
            GetAdminButton.BackColor = SystemColors.ControlLight;
            GetAdminButton.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GetAdminButton.Location = new Point(193, 301);
            GetAdminButton.Name = "GetAdminButton";
            GetAdminButton.Size = new Size(428, 58);
            GetAdminButton.TabIndex = 6;
            GetAdminButton.Text = "Я администратор";
            GetAdminButton.UseVisualStyleBackColor = false;
            GetAdminButton.Click += GetAdminButton_Click;
            GetAdminButton.MouseLeave += GetAdminButton_MouseLeave_1;
            GetAdminButton.MouseHover += GetAdminButton_MouseHover;
            // 
            // ChoiceLabel
            // 
            ChoiceLabel.AutoSize = true;
            ChoiceLabel.Font = new Font("Cambria", 18F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            ChoiceLabel.Location = new Point(243, 35);
            ChoiceLabel.Name = "ChoiceLabel";
            ChoiceLabel.Size = new Size(334, 36);
            ChoiceLabel.TabIndex = 8;
            ChoiceLabel.Text = "Сделайте Ваш выбор!";
            // 
            // ChoiceForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(800, 450);
            Controls.Add(ChoiceLabel);
            Controls.Add(GetAdminButton);
            Controls.Add(ShowRulesButton);
            Controls.Add(ExitGameButton);
            Controls.Add(ShowResultButton);
            Controls.Add(StartGameButton);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "ChoiceForm";
            Text = "Выбор действий";
            Load += ChoiceForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private MenuStrip menuStrip1;
        private Label StartGameLabel;
        private Button StartGameButton;
        private Button ShowResultButton;
        private Button ExitGameButton;
        private Button ShowRulesButton;
        private Button GetAdminButton;
        private Label ChoiceLabel;
    }
}