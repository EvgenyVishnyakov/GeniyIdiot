using GeniyIdiot.Common;

namespace GeniyIdiotWinFormsApp
{
    public partial class СhangePasswordForm : Form
    {

        Password passwords;
        public СhangePasswordForm()
        {
            InitializeComponent();
        }

        private void confirmPasswordButton_MouseHover(object sender, EventArgs e)
        {
            confirmPasswordButton.BackColor = Color.Gray;
        }

        private void confirmPasswordButton_MouseLeave(object sender, EventArgs e)
        {
            confirmPasswordButton.BackColor = Color.LightGray;
        }

        private void ConfirmPasswordButton(object sender, EventArgs e)
        {
            var password = new Password(newPasswordTextBox.Text);
            AdminStorage.Save(password);
            this.Close();
        }
    }
}
