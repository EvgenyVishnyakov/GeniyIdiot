namespace GeniyIdiotWinFormsApp
{
    partial class AdminForm
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
            AdminLabel = new Label();
            UserPressPasswordLabel = new Label();
            UserPasswordTextBox = new TextBox();
            ConformPasswordButton = new Button();
            SuspendLayout();
            // 
            // AdminLabel
            // 
            AdminLabel.AutoSize = true;
            AdminLabel.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AdminLabel.Location = new Point(159, 74);
            AdminLabel.Name = "AdminLabel";
            AdminLabel.Size = new Size(516, 33);
            AdminLabel.TabIndex = 0;
            AdminLabel.Text = "Введите пароль для подтвреждения ";
            // 
            // UserPressPasswordLabel
            // 
            UserPressPasswordLabel.AutoSize = true;
            UserPressPasswordLabel.BackColor = Color.Silver;
            UserPressPasswordLabel.Font = new Font("Cambria", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            UserPressPasswordLabel.Location = new Point(315, 132);
            UserPressPasswordLabel.Name = "UserPressPasswordLabel";
            UserPressPasswordLabel.Size = new Size(113, 33);
            UserPressPasswordLabel.TabIndex = 3;
            UserPressPasswordLabel.Text = "Пароль:";
            // 
            // UserPasswordTextBox
            // 
            UserPasswordTextBox.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UserPasswordTextBox.Location = new Point(216, 204);
            UserPasswordTextBox.Name = "UserPasswordTextBox";
            UserPasswordTextBox.Size = new Size(333, 34);
            UserPasswordTextBox.TabIndex = 4;
            // 
            // ConformPasswordButton
            // 
            ConformPasswordButton.Font = new Font("Cambria", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ConformPasswordButton.Location = new Point(216, 283);
            ConformPasswordButton.Name = "ConformPasswordButton";
            ConformPasswordButton.Size = new Size(333, 93);
            ConformPasswordButton.TabIndex = 5;
            ConformPasswordButton.Text = "Подтверждаю";
            ConformPasswordButton.UseVisualStyleBackColor = true;
            ConformPasswordButton.Click += ConformPasswordButton_Click;
            ConformPasswordButton.MouseLeave += ConformPasswordButton_MouseLeave;
            ConformPasswordButton.MouseHover += ConformPasswordButton_MouseHover;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(800, 450);
            Controls.Add(ConformPasswordButton);
            Controls.Add(UserPasswordTextBox);
            Controls.Add(UserPressPasswordLabel);
            Controls.Add(AdminLabel);
            Name = "AdminForm";
            Text = "Администратор";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label AdminLabel;
        private DataGridView dataGridView1;
        private Label UserPressPasswordLabel;
        private TextBox UserPasswordTextBox;
        private Button ConformPasswordButton;
    }
}