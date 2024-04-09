namespace halamanLogin
{
    partial class Form1
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
            groupBoxRegister = new GroupBox();
            groupBoxSignIn = new GroupBox();
            labelDontHaveAccount = new Label();
            label3 = new Label();
            groupBox2 = new GroupBox();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            labelSignIn = new Label();
            ButtonCancelSignIn = new Button();
            buttonAcceptSignIn = new Button();
            textBoxPasswordLogin = new TextBox();
            textBoxEmailLogin = new TextBox();
            buttonAcceptRegister = new Button();
            labelSingUp = new Label();
            buttonCancelRegister = new Button();
            textBoxCreatePassword = new TextBox();
            textBoxCreateName = new TextBox();
            labelCreateEmail = new Label();
            textBoxCreateEmail = new TextBox();
            buttonCancelLogin = new Button();
            buttonAcceptLogin = new Button();
            labelPassword = new Label();
            textBoxPassword = new TextBox();
            labelEmail = new Label();
            textBoxEmail = new TextBox();
            groupBoxRegister.SuspendLayout();
            groupBoxSignIn.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxRegister
            // 
            groupBoxRegister.BackColor = Color.Black;
            groupBoxRegister.BackgroundImageLayout = ImageLayout.Center;
            groupBoxRegister.Controls.Add(buttonAcceptRegister);
            groupBoxRegister.Controls.Add(labelSingUp);
            groupBoxRegister.Controls.Add(buttonCancelRegister);
            groupBoxRegister.Controls.Add(textBoxCreatePassword);
            groupBoxRegister.Controls.Add(textBoxCreateName);
            groupBoxRegister.Controls.Add(labelCreateEmail);
            groupBoxRegister.Controls.Add(textBoxCreateEmail);
            groupBoxRegister.ForeColor = SystemColors.Highlight;
            groupBoxRegister.Location = new Point(279, 101);
            groupBoxRegister.Name = "groupBoxRegister";
            groupBoxRegister.Padding = new Padding(0);
            groupBoxRegister.Size = new Size(253, 268);
            groupBoxRegister.TabIndex = 4;
            groupBoxRegister.TabStop = false;
            // 
            // groupBoxSignIn
            // 
            groupBoxSignIn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxSignIn.BackColor = Color.Black;
            groupBoxSignIn.BackgroundImageLayout = ImageLayout.Center;
            groupBoxSignIn.Controls.Add(labelDontHaveAccount);
            groupBoxSignIn.Controls.Add(label3);
            groupBoxSignIn.Controls.Add(groupBox2);
            groupBoxSignIn.Controls.Add(labelSignIn);
            groupBoxSignIn.Controls.Add(ButtonCancelSignIn);
            groupBoxSignIn.Controls.Add(buttonAcceptSignIn);
            groupBoxSignIn.Controls.Add(textBoxPasswordLogin);
            groupBoxSignIn.Controls.Add(textBoxEmailLogin);
            groupBoxSignIn.ForeColor = SystemColors.Highlight;
            groupBoxSignIn.Location = new Point(279, 111);
            groupBoxSignIn.Name = "groupBoxSignIn";
            groupBoxSignIn.Padding = new Padding(0);
            groupBoxSignIn.Size = new Size(253, 268);
            groupBoxSignIn.TabIndex = 10;
            groupBoxSignIn.TabStop = false;
            // 
            // labelDontHaveAccount
            // 
            labelDontHaveAccount.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelDontHaveAccount.AutoSize = true;
            labelDontHaveAccount.Cursor = Cursors.Hand;
            labelDontHaveAccount.Location = new Point(70, 164);
            labelDontHaveAccount.Name = "labelDontHaveAccount";
            labelDontHaveAccount.Size = new Size(119, 15);
            labelDontHaveAccount.TabIndex = 12;
            labelDontHaveAccount.Text = "Dont Have Account ?";
            labelDontHaveAccount.Click += labelDontHaveAccount_Click;
            labelDontHaveAccount.MouseEnter += labelDontHaveAccount_MouseEnter;
            labelDontHaveAccount.MouseLeave += labelDontHaveAccount_MouseLeave;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(57, 50);
            label3.Name = "label3";
            label3.Size = new Size(142, 15);
            label3.TabIndex = 11;
            label3.Text = "Sign In Into Your Account";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.None;
            groupBox2.BackColor = Color.Black;
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Location = new Point(285, 103);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(253, 268);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button1.BackColor = SystemColors.Highlight;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(122, 196);
            button1.Name = "button1";
            button1.Size = new Size(128, 191);
            button1.TabIndex = 7;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button2.BackColor = SystemColors.Highlight;
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(41, 196);
            button2.Name = "button2";
            button2.Size = new Size(128, 191);
            button2.TabIndex = 6;
            button2.Text = "Login";
            button2.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(55, 50);
            label1.Name = "label1";
            label1.Size = new Size(142, 15);
            label1.TabIndex = 5;
            label1.Text = "Sign In Into Your Account";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.BackColor = Color.Black;
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(23, 116);
            textBox1.Name = "textBox1";
            textBox1.PasswordChar = '*';
            textBox1.PlaceholderText = "Password";
            textBox1.Size = new Size(236, 23);
            textBox1.TabIndex = 4;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(84, 19);
            label2.Name = "label2";
            label2.Size = new Size(70, 25);
            label2.TabIndex = 3;
            label2.Text = "Sign In";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox2.BackColor = SystemColors.MenuText;
            textBox2.ForeColor = Color.White;
            textBox2.Location = new Point(23, 87);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Email";
            textBox2.Size = new Size(236, 23);
            textBox2.TabIndex = 2;
            // 
            // labelSignIn
            // 
            labelSignIn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelSignIn.AutoSize = true;
            labelSignIn.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelSignIn.ForeColor = Color.GhostWhite;
            labelSignIn.Location = new Point(91, 16);
            labelSignIn.Name = "labelSignIn";
            labelSignIn.Size = new Size(70, 25);
            labelSignIn.TabIndex = 9;
            labelSignIn.Text = "Sign In";
            // 
            // ButtonCancelSignIn
            // 
            ButtonCancelSignIn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ButtonCancelSignIn.BackColor = SystemColors.Highlight;
            ButtonCancelSignIn.Cursor = Cursors.Hand;
            ButtonCancelSignIn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonCancelSignIn.ForeColor = SystemColors.Desktop;
            ButtonCancelSignIn.Location = new Point(131, 196);
            ButtonCancelSignIn.Name = "ButtonCancelSignIn";
            ButtonCancelSignIn.Size = new Size(75, 23);
            ButtonCancelSignIn.TabIndex = 7;
            ButtonCancelSignIn.Text = "Cancel";
            ButtonCancelSignIn.UseVisualStyleBackColor = false;
            ButtonCancelSignIn.Click += ButtonCancelSignIn_Click;
            ButtonCancelSignIn.MouseEnter += ButtonCancelSignIn_MouseEnter;
            ButtonCancelSignIn.MouseLeave += ButtonCancelSignIn_MouseLeave;
            // 
            // buttonAcceptSignIn
            // 
            buttonAcceptSignIn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonAcceptSignIn.BackColor = SystemColors.Highlight;
            buttonAcceptSignIn.Cursor = Cursors.Hand;
            buttonAcceptSignIn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAcceptSignIn.ForeColor = SystemColors.Desktop;
            buttonAcceptSignIn.Location = new Point(50, 196);
            buttonAcceptSignIn.Name = "buttonAcceptSignIn";
            buttonAcceptSignIn.Size = new Size(75, 23);
            buttonAcceptSignIn.TabIndex = 6;
            buttonAcceptSignIn.Text = "Sign In";
            buttonAcceptSignIn.UseVisualStyleBackColor = false;
            buttonAcceptSignIn.Click += buttonAcceptSignIn_Click;
            buttonAcceptSignIn.MouseEnter += buttonAcceptSignIn_MouseEnter;
            buttonAcceptSignIn.MouseLeave += buttonAcceptSignIn_MouseLeave;
            // 
            // textBoxPasswordLogin
            // 
            textBoxPasswordLogin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxPasswordLogin.BackColor = SystemColors.MenuText;
            textBoxPasswordLogin.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPasswordLogin.ForeColor = Color.White;
            textBoxPasswordLogin.Location = new Point(36, 116);
            textBoxPasswordLogin.Name = "textBoxPasswordLogin";
            textBoxPasswordLogin.PasswordChar = '*';
            textBoxPasswordLogin.PlaceholderText = "Password";
            textBoxPasswordLogin.Size = new Size(183, 23);
            textBoxPasswordLogin.TabIndex = 4;
            // 
            // textBoxEmailLogin
            // 
            textBoxEmailLogin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxEmailLogin.BackColor = Color.Black;
            textBoxEmailLogin.ForeColor = SystemColors.Window;
            textBoxEmailLogin.Location = new Point(36, 87);
            textBoxEmailLogin.Name = "textBoxEmailLogin";
            textBoxEmailLogin.PlaceholderText = "Email";
            textBoxEmailLogin.Size = new Size(183, 23);
            textBoxEmailLogin.TabIndex = 0;
            // 
            // buttonAcceptRegister
            // 
            buttonAcceptRegister.BackColor = SystemColors.Highlight;
            buttonAcceptRegister.Cursor = Cursors.Hand;
            buttonAcceptRegister.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAcceptRegister.ForeColor = Color.Black;
            buttonAcceptRegister.Location = new Point(44, 196);
            buttonAcceptRegister.Name = "buttonAcceptRegister";
            buttonAcceptRegister.Size = new Size(75, 23);
            buttonAcceptRegister.TabIndex = 10;
            buttonAcceptRegister.Text = "Sign Up";
            buttonAcceptRegister.UseVisualStyleBackColor = false;
            buttonAcceptRegister.Click += buttonAcceptRegister_Click;
            buttonAcceptRegister.MouseEnter += buttonAcceptRegister_MouseEnter;
            buttonAcceptRegister.MouseLeave += buttonAcceptRegister_MouseLeave;
            // 
            // labelSingUp
            // 
            labelSingUp.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelSingUp.AutoSize = true;
            labelSingUp.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelSingUp.ForeColor = Color.GhostWhite;
            labelSingUp.Location = new Point(76, 16);
            labelSingUp.Name = "labelSingUp";
            labelSingUp.Size = new Size(78, 25);
            labelSingUp.TabIndex = 9;
            labelSingUp.Text = "Sign Up";
            // 
            // buttonCancelRegister
            // 
            buttonCancelRegister.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonCancelRegister.BackColor = SystemColors.Highlight;
            buttonCancelRegister.Cursor = Cursors.Hand;
            buttonCancelRegister.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCancelRegister.ForeColor = SystemColors.Desktop;
            buttonCancelRegister.Location = new Point(125, 196);
            buttonCancelRegister.Name = "buttonCancelRegister";
            buttonCancelRegister.Size = new Size(75, 23);
            buttonCancelRegister.TabIndex = 7;
            buttonCancelRegister.Text = "Cancel";
            buttonCancelRegister.UseVisualStyleBackColor = false;
            buttonCancelRegister.Click += buttonCancelRegister_Click;
            buttonCancelRegister.MouseEnter += buttonCancelRegister_MouseEnter;
            buttonCancelRegister.MouseLeave += buttonCancelRegister_MouseLeave;
            // 
            // textBoxCreatePassword
            // 
            textBoxCreatePassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxCreatePassword.BackColor = SystemColors.MenuText;
            textBoxCreatePassword.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCreatePassword.ForeColor = Color.White;
            textBoxCreatePassword.Location = new Point(26, 145);
            textBoxCreatePassword.Name = "textBoxCreatePassword";
            textBoxCreatePassword.PasswordChar = '*';
            textBoxCreatePassword.PlaceholderText = "Password";
            textBoxCreatePassword.Size = new Size(183, 23);
            textBoxCreatePassword.TabIndex = 4;
            // 
            // textBoxCreateName
            // 
            textBoxCreateName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxCreateName.BackColor = Color.Black;
            textBoxCreateName.ForeColor = Color.White;
            textBoxCreateName.Location = new Point(27, 116);
            textBoxCreateName.Name = "textBoxCreateName";
            textBoxCreateName.PlaceholderText = "Name";
            textBoxCreateName.Size = new Size(183, 23);
            textBoxCreateName.TabIndex = 2;
            // 
            // labelCreateEmail
            // 
            labelCreateEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelCreateEmail.AutoSize = true;
            labelCreateEmail.Location = new Point(61, 50);
            labelCreateEmail.Name = "labelCreateEmail";
            labelCreateEmail.Size = new Size(116, 15);
            labelCreateEmail.TabIndex = 1;
            labelCreateEmail.Text = "Create Your Account";
            // 
            // textBoxCreateEmail
            // 
            textBoxCreateEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxCreateEmail.BackColor = Color.Black;
            textBoxCreateEmail.ForeColor = SystemColors.Window;
            textBoxCreateEmail.Location = new Point(26, 87);
            textBoxCreateEmail.Name = "textBoxCreateEmail";
            textBoxCreateEmail.PlaceholderText = "Email";
            textBoxCreateEmail.Size = new Size(183, 23);
            textBoxCreateEmail.TabIndex = 0;
            // 
            // buttonCancelLogin
            // 
            buttonCancelLogin.Location = new Point(0, 0);
            buttonCancelLogin.Name = "buttonCancelLogin";
            buttonCancelLogin.Size = new Size(75, 23);
            buttonCancelLogin.TabIndex = 0;
            // 
            // buttonAcceptLogin
            // 
            buttonAcceptLogin.Location = new Point(0, 0);
            buttonAcceptLogin.Name = "buttonAcceptLogin";
            buttonAcceptLogin.Size = new Size(75, 23);
            buttonAcceptLogin.TabIndex = 0;
            // 
            // labelPassword
            // 
            labelPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelPassword.AutoSize = true;
            labelPassword.ForeColor = SystemColors.Highlight;
            labelPassword.Location = new Point(55, 50);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(142, 15);
            labelPassword.TabIndex = 5;
            labelPassword.Text = "Sign In Into Your Account";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxPassword.BackColor = Color.Black;
            textBoxPassword.ForeColor = Color.White;
            textBoxPassword.Location = new Point(23, 116);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.PlaceholderText = "Password";
            textBoxPassword.Size = new Size(183, 23);
            textBoxPassword.TabIndex = 4;
            // 
            // labelEmail
            // 
            labelEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelEmail.ForeColor = Color.White;
            labelEmail.Location = new Point(84, 19);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(70, 25);
            labelEmail.TabIndex = 3;
            labelEmail.Text = "Sign In";
            labelEmail.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxEmail.BackColor = SystemColors.MenuText;
            textBoxEmail.ForeColor = Color.White;
            textBoxEmail.Location = new Point(23, 87);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.PlaceholderText = "Email";
            textBoxEmail.Size = new Size(183, 23);
            textBoxEmail.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBoxSignIn);
            Controls.Add(groupBoxRegister);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            groupBoxRegister.ResumeLayout(false);
            groupBoxRegister.PerformLayout();
            groupBoxSignIn.ResumeLayout(false);
            groupBoxSignIn.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxRegister;
        private TextBox textBoxCreateUser;
        private TextBox textBoxCreatePassword;
        private TextBox textBoxCreateName;
        private Label labelCreateUser;
        private Button buttonCancelRegister;
        private Button buttonCancelLogin;
        private Button buttonAcceptLogin;
        private Label labelPassword;
        private TextBox textBoxPassword;
        private Label labelEmail;
        private TextBox textBoxEmail;
        private Label labelCreateEmail;
        private TextBox textBoxCreateEmail;
        private Label labelSingUp;
        private GroupBox groupBoxSignIn;
        private GroupBox groupBox2;
        private Button button1;
        private Button button2;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Label labelSignIn;
        private Button ButtonCancelSignIn;
        private Button buttonAcceptSignIn;
        private TextBox textBoxPasswordLogin;
        private TextBox textBoxEmailLogin;
        private Button buttonAcceptRegister;
        private Label label3;
        private Label labelDontHaveAccount;
    }
}
