using GeniyIdiot.Common;
using System.Xml.Linq;

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
            passwords = new Password(newPasswordTextBox.Text);
            AdminStorage.SavePassword(passwords);
            this.Close();
        }
    }
}
