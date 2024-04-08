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
            dataLogin();
            textBoxCreateUser.Select();
            groupLogin.Hide();
        }
        // End

        // Data Register
        private void dataRegister()
        {
            CreateUser = textBoxCreateUser.Text;
            CreateName = textBoxCreateName.Text;
            CreatePassword = textBoxCreatePassword.Text;
            groupRegister = groupBoxRegister;
        }
        // End


        // Data Login
        private void dataLogin()
        {
            LoginName = textBoxName.Text;
            LoginPassword = textBoxPassword.Text;
            groupLogin = groupBoxLogin;
        }
        // End

        // Create Button Click
        private void buttonAcceptRegister_Click(object sender, EventArgs e)
        {
            dataRegister();
            if (!string.IsNullOrEmpty(textBoxCreateUser.Text) &&
                !string.IsNullOrEmpty(textBoxCreateName.Text) &&
                !string.IsNullOrEmpty(textBoxCreatePassword.Text))
            {
                MessageBox.Show("Akun Anda Telah Dibuat!", "Register Successfully",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                groupRegister.Hide();
                groupBoxLogin.Show();
                textBoxName.Select();
            }
            else
            {
                MessageBox.Show("Periksa Kembali Inputan Anda!", "Terjadi Kesalahan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        // End

        //Private Variables Login
        private string LoginName;
        private string LoginPassword;
        private GroupBox groupLogin;
        // End


        // Button Accept Login Click
        private void buttonAcceptLogin_Click(object sender, EventArgs e)
        {
            dataRegister();
            dataLogin();
            if (!string.IsNullOrEmpty(textBoxName.Text) &&
                !string.IsNullOrEmpty(textBoxPassword.Text) && 
                textBoxName.Text == textBoxCreateName.Text &&
                textBoxPassword.Text == textBoxCreatePassword.Text
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
    }
}
