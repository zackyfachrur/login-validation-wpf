using System.Media;
using System.Windows.Forms.VisualStyles;

namespace halamanLogin
{
    public partial class Form1 : Form
    {

        // Private Variables Register
        private string CreateUser;
        private string CreateName;
        private string CreatePassword;
        private GroupBox groupRegister;
        // End



        public Form1()
        {
            InitializeComponent();
            Load += Form1_Load;
        }

        // Form1 On Load
        public void Form1_Load(object sender, EventArgs e)
        {
            textBoxCreateEmail.Select();
            groupBoxSignIn.Hide();
        }
        // End

        // Data Register
        private void dataRegister()
        {
            CreateUser = textBoxCreateEmail.Text;
            CreateName = textBoxCreateName.Text;
            CreatePassword = textBoxCreatePassword.Text;
            groupRegister = groupBoxRegister;
        }
        // End


        // Create Button Click
        private void buttonAcceptRegister_Click(object sender, EventArgs e)
        {
            dataRegister();
            if (!string.IsNullOrEmpty(textBoxCreateEmail.Text) &&
                !string.IsNullOrEmpty(textBoxCreateName.Text) &&
                !string.IsNullOrEmpty(textBoxCreatePassword.Text))
            {
                MessageBox.Show("Akun Anda Telah Dibuat!", "Register Successfully",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                groupRegister.Hide();
                groupBoxSignIn.Show();
                textBoxEmailLogin.Select();
            }
            else
            {
                MessageBox.Show("Periksa Kembali Inputan Anda!", "Terjadi Kesalahan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        // End


        // Button Accept Login Click
        private void buttonAcceptSignIn_Click(object sender, EventArgs e)
        {
            dataRegister();
            if (!string.IsNullOrEmpty(textBoxEmailLogin.Text) &&
                !string.IsNullOrEmpty(textBoxPasswordLogin.Text) &&
                textBoxEmailLogin.Text == textBoxCreateEmail.Text &&
                textBoxPasswordLogin.Text == textBoxCreatePassword.Text
                )
            {
                MessageBox.Show("Selamat Anda Telah Login!", "Login Successfully",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Periksa Kembali Inputan Anda!", "Terjadi Kesalahan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        // End

        // Button Styling
        private void buttonAcceptRegister_MouseEnter(object sender, EventArgs e)
        {
            buttonAcceptRegister.BackColor = Color.Black;
            buttonAcceptRegister.ForeColor = SystemColors.Highlight;
            buttonAcceptRegister.Font = new Font(buttonAcceptRegister.Font, FontStyle.Underline);
        }

        private void buttonAcceptRegister_MouseLeave(object sender, EventArgs e)
        {
            buttonAcceptRegister.BackColor = SystemColors.Highlight;
            buttonAcceptRegister.ForeColor = Color.Black;
            buttonAcceptRegister.Font = new Font(buttonAcceptRegister.Font, FontStyle.Bold);
        }

        private void buttonCancelRegister_MouseEnter(object sender, EventArgs e)
        {
            buttonCancelRegister.BackColor = Color.Black;
            buttonCancelRegister.ForeColor = SystemColors.Highlight;
            buttonCancelRegister.Font = new Font(buttonCancelRegister.Font, FontStyle.Underline);
        }

        private void buttonCancelRegister_MouseLeave(object sender, EventArgs e)
        {
            buttonCancelRegister.BackColor = SystemColors.Highlight;
            buttonCancelRegister.ForeColor = Color.Black;
            buttonCancelRegister.Font = new Font(buttonCancelRegister.Font, FontStyle.Bold);
        }
        private void buttonCancelRegister_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelDontHaveAccount_Click(object sender, EventArgs e)
        {
            groupBoxRegister.Show();
            groupBoxSignIn.Hide();
        }

        private void labelDontHaveAccount_MouseEnter(object sender, EventArgs e)
        {
            labelDontHaveAccount.Font = new Font(labelDontHaveAccount.Font, FontStyle.Underline);
        }
        private void labelDontHaveAccount_MouseLeave(object sender, EventArgs e)
        {
            labelDontHaveAccount.Font = new Font(labelDontHaveAccount.Font, FontStyle.Bold);
        }

        private void buttonAcceptSignIn_MouseEnter(object sender, EventArgs e)
        {
            buttonAcceptSignIn.BackColor = Color.Black;
            buttonAcceptSignIn.ForeColor = SystemColors.Highlight;
            buttonAcceptSignIn.Font = new Font(buttonAcceptSignIn.Font, FontStyle.Underline);
        }
        private void buttonAcceptSignIn_MouseLeave(object sender, EventArgs e)
        {
            buttonAcceptSignIn.BackColor = SystemColors.Highlight;
            buttonAcceptSignIn.ForeColor = Color.Black;
            buttonAcceptSignIn.Font = new Font(buttonAcceptSignIn.Font, FontStyle.Bold);
        }

        private void ButtonCancelSignIn_Click(object sender, EventArgs e)
        {
            groupBoxRegister.Show();
            groupBoxSignIn.Hide();
        }

        private void ButtonCancelSignIn_MouseEnter(object sender, EventArgs e)
        {
            ButtonCancelSignIn.BackColor = Color.Black;
            ButtonCancelSignIn.ForeColor = SystemColors.Highlight;
            ButtonCancelSignIn.Font = new Font(ButtonCancelSignIn.Font, FontStyle.Underline);
        }
        private void ButtonCancelSignIn_MouseLeave(object sender, EventArgs e)
        {
            ButtonCancelSignIn.BackColor = SystemColors.Highlight;
            ButtonCancelSignIn.ForeColor = Color.Black;
            ButtonCancelSignIn.Font = new Font(ButtonCancelSignIn.Font, FontStyle.Bold);
        }
        // End


    }
}
