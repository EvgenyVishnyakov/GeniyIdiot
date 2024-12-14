namespace GeniyIdiotWinFormsApp
{
    partial class СhangePasswordForm
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
            enterNewPasswordLabel = new Label();
            confirmPasswordButton = new Button();
            newPasswordTextBox = new TextBox();
            SuspendLayout();
            // 
            // enterNewPasswordLabel
            // 
            enterNewPasswordLabel.AutoSize = true;
            enterNewPasswordLabel.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            enterNewPasswordLabel.Location = new Point(254, 105);
            enterNewPasswordLabel.Name = "enterNewPasswordLabel";
            enterNewPasswordLabel.Size = new Size(327, 33);
            enterNewPasswordLabel.TabIndex = 0;
            enterNewPasswordLabel.Text = "Введите новый пароль";
            // 
            // confirmPasswordButton
            // 
            confirmPasswordButton.BackColor = Color.LightGray;
            confirmPasswordButton.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            confirmPasswordButton.Location = new Point(258, 230);
            confirmPasswordButton.Name = "confirmPasswordButton";
            confirmPasswordButton.Size = new Size(323, 65);
            confirmPasswordButton.TabIndex = 1;
            confirmPasswordButton.Text = "Подтвердить";
            confirmPasswordButton.UseVisualStyleBackColor = false;
            confirmPasswordButton.Click += ConfirmPasswordButton;
            confirmPasswordButton.MouseLeave += confirmPasswordButton_MouseLeave;
            confirmPasswordButton.MouseHover += confirmPasswordButton_MouseHover;
            // 
            // newPasswordTextBox
            // 
            newPasswordTextBox.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            newPasswordTextBox.Location = new Point(258, 162);
            newPasswordTextBox.Name = "newPasswordTextBox";
            newPasswordTextBox.Size = new Size(323, 34);
            newPasswordTextBox.TabIndex = 2;
            // 
            // СhangePasswordForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(800, 450);
            Controls.Add(newPasswordTextBox);
            Controls.Add(confirmPasswordButton);
            Controls.Add(enterNewPasswordLabel);
            Name = "СhangePasswordForm";
            Text = "Смена пароля";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label enterNewPasswordLabel;
        private Button confirmPasswordButton;
        private TextBox newPasswordTextBox;
    }
}