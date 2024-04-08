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
            groupBoxLogin = new GroupBox();
            buttonCancelLogin = new Button();
            buttonAcceptLogin = new Button();
            labelPassword = new Label();
            textBoxPassword = new TextBox();
            labelName = new Label();
            textBoxName = new TextBox();
            buttonCancelRegister = new Button();
            buttonAcceptRegister = new Button();
            labelCreatePassword = new Label();
            textBoxCreatePassword = new TextBox();
            labelCreateName = new Label();
            textBoxCreateName = new TextBox();
            labelCreateUser = new Label();
            textBoxCreateUser = new TextBox();
            groupBoxRegister.SuspendLayout();
            groupBoxLogin.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxRegister
            // 
            groupBoxRegister.Controls.Add(buttonCancelRegister);
            groupBoxRegister.Controls.Add(buttonAcceptRegister);
            groupBoxRegister.Controls.Add(labelCreatePassword);
            groupBoxRegister.Controls.Add(textBoxCreatePassword);
            groupBoxRegister.Controls.Add(labelCreateName);
            groupBoxRegister.Controls.Add(textBoxCreateName);
            groupBoxRegister.Controls.Add(labelCreateUser);
            groupBoxRegister.Controls.Add(textBoxCreateUser);
            groupBoxRegister.Location = new Point(276, 104);
            groupBoxRegister.Name = "groupBoxRegister";
            groupBoxRegister.Size = new Size(253, 220);
            groupBoxRegister.TabIndex = 4;
            groupBoxRegister.TabStop = false;
            groupBoxRegister.Text = "Create Your Account";
            // 
            // groupBoxLogin
            // 
            groupBoxLogin.Controls.Add(buttonCancelLogin);
            groupBoxLogin.Controls.Add(buttonAcceptLogin);
            groupBoxLogin.Controls.Add(labelPassword);
            groupBoxLogin.Controls.Add(textBoxPassword);
            groupBoxLogin.Controls.Add(labelName);
            groupBoxLogin.Controls.Add(textBoxName);
            groupBoxLogin.Location = new Point(276, 104);
            groupBoxLogin.Name = "groupBoxLogin";
            groupBoxLogin.Size = new Size(253, 220);
            groupBoxLogin.TabIndex = 8;
            groupBoxLogin.TabStop = false;
            groupBoxLogin.Text = "Login Into Your Account";
            // 
            // buttonCancelLogin
            // 
            buttonCancelLogin.Location = new Point(131, 179);
            buttonCancelLogin.Name = "buttonCancelLogin";
            buttonCancelLogin.Size = new Size(75, 23);
            buttonCancelLogin.TabIndex = 7;
            buttonCancelLogin.Text = "Cancel";
            buttonCancelLogin.UseVisualStyleBackColor = true;
            // 
            // buttonAcceptLogin
            // 
            buttonAcceptLogin.Location = new Point(23, 179);
            buttonAcceptLogin.Name = "buttonAcceptLogin";
            buttonAcceptLogin.Size = new Size(75, 23);
            buttonAcceptLogin.TabIndex = 6;
            buttonAcceptLogin.Text = "Login";
            buttonAcceptLogin.UseVisualStyleBackColor = true;
            buttonAcceptLogin.Click += buttonAcceptLogin_Click;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(23, 78);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(84, 15);
            labelPassword.TabIndex = 5;
            labelPassword.Text = "Your Password";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(23, 96);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(183, 23);
            textBoxPassword.TabIndex = 4;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(23, 34);
            labelName.Name = "labelName";
            labelName.Size = new Size(66, 15);
            labelName.TabIndex = 3;
            labelName.Text = "Your Name";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(23, 52);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(183, 23);
            textBoxName.TabIndex = 2;
            // 
            // buttonCancelRegister
            // 
            buttonCancelRegister.Location = new Point(131, 179);
            buttonCancelRegister.Name = "buttonCancelRegister";
            buttonCancelRegister.Size = new Size(75, 23);
            buttonCancelRegister.TabIndex = 7;
            buttonCancelRegister.Text = "Cancel";
            buttonCancelRegister.UseVisualStyleBackColor = true;
            // 
            // buttonAcceptRegister
            // 
            buttonAcceptRegister.Location = new Point(24, 179);
            buttonAcceptRegister.Name = "buttonAcceptRegister";
            buttonAcceptRegister.Size = new Size(75, 23);
            buttonAcceptRegister.TabIndex = 6;
            buttonAcceptRegister.Text = "Create";
            buttonAcceptRegister.UseVisualStyleBackColor = true;
            buttonAcceptRegister.Click += buttonAcceptRegister_Click;
            // 
            // labelCreatePassword
            // 
            labelCreatePassword.AutoSize = true;
            labelCreatePassword.Location = new Point(23, 122);
            labelCreatePassword.Name = "labelCreatePassword";
            labelCreatePassword.Size = new Size(94, 15);
            labelCreatePassword.TabIndex = 5;
            labelCreatePassword.Text = "Create Password";
            // 
            // textBoxCreatePassword
            // 
            textBoxCreatePassword.Location = new Point(23, 140);
            textBoxCreatePassword.Name = "textBoxCreatePassword";
            textBoxCreatePassword.Size = new Size(183, 23);
            textBoxCreatePassword.TabIndex = 4;
            // 
            // labelCreateName
            // 
            labelCreateName.AutoSize = true;
            labelCreateName.Location = new Point(23, 78);
            labelCreateName.Name = "labelCreateName";
            labelCreateName.Size = new Size(76, 15);
            labelCreateName.TabIndex = 3;
            labelCreateName.Text = "Create Name";
            // 
            // textBoxCreateName
            // 
            textBoxCreateName.Location = new Point(23, 96);
            textBoxCreateName.Name = "textBoxCreateName";
            textBoxCreateName.Size = new Size(183, 23);
            textBoxCreateName.TabIndex = 2;
            // 
            // labelCreateUser
            // 
            labelCreateUser.AutoSize = true;
            labelCreateUser.Location = new Point(23, 34);
            labelCreateUser.Name = "labelCreateUser";
            labelCreateUser.Size = new Size(97, 15);
            labelCreateUser.TabIndex = 1;
            labelCreateUser.Text = "Create Username";
            // 
            // textBoxCreateUser
            // 
            textBoxCreateUser.Location = new Point(23, 52);
            textBoxCreateUser.Name = "textBoxCreateUser";
            textBoxCreateUser.Size = new Size(183, 23);
            textBoxCreateUser.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GhostWhite;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBoxLogin);
            Controls.Add(groupBoxRegister);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "Form1";
            Text = "Form1";
            groupBoxRegister.ResumeLayout(false);
            groupBoxRegister.PerformLayout();
            groupBoxLogin.ResumeLayout(false);
            groupBoxLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxRegister;
        private TextBox textBoxCreateUser;
        private Label labelCreatePassword;
        private TextBox textBoxCreatePassword;
        private Label labelCreateName;
        private TextBox textBoxCreateName;
        private Label labelCreateUser;
        private Button buttonCancelRegister;
        private Button buttonAcceptRegister;
        private GroupBox groupBoxLogin;
        private Button buttonCancelLogin;
        private Button buttonAcceptLogin;
        private Label labelPassword;
        private TextBox textBoxPassword;
        private Label labelName;
        private TextBox textBoxName;
    }
}
