namespace Client_For_SemesterProject
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
            this.welcomeANDstandard = new System.Windows.Forms.TabControl();
            this.LoadingPage = new System.Windows.Forms.TabPage();
            this.CouldNotConnect = new System.Windows.Forms.RichTextBox();
            this.ConnectToServer = new System.Windows.Forms.Button();
            this.WelcomePage = new System.Windows.Forms.TabPage();
            this.GotoCreateNewUser = new System.Windows.Forms.Button();
            this.GotoSignIn = new System.Windows.Forms.Button();
            this.SigninPage = new System.Windows.Forms.TabPage();
            this.Backtowelcome = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SignInPassword = new System.Windows.Forms.TextBox();
            this.SignInUname = new System.Windows.Forms.TextBox();
            this.SignInTextbox = new System.Windows.Forms.TextBox();
            this.NewUserPage = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.NewUserConfirmPword = new System.Windows.Forms.TextBox();
            this.NewUserErrorMessage = new System.Windows.Forms.RichTextBox();
            this.CreateUserButton = new System.Windows.Forms.Button();
            this.NewUserPword = new System.Windows.Forms.TextBox();
            this.NewUserUname = new System.Windows.Forms.TextBox();
            this.CreateNewUsertitle = new System.Windows.Forms.TextBox();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.welcomeANDstandard.SuspendLayout();
            this.LoadingPage.SuspendLayout();
            this.WelcomePage.SuspendLayout();
            this.SigninPage.SuspendLayout();
            this.panel1.SuspendLayout();
            this.NewUserPage.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // welcomeANDstandard
            // 
            this.welcomeANDstandard.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.welcomeANDstandard.Controls.Add(this.LoadingPage);
            this.welcomeANDstandard.Controls.Add(this.WelcomePage);
            this.welcomeANDstandard.Controls.Add(this.SigninPage);
            this.welcomeANDstandard.Controls.Add(this.NewUserPage);
            this.welcomeANDstandard.ItemSize = new System.Drawing.Size(0, 1);
            this.welcomeANDstandard.Location = new System.Drawing.Point(0, -1);
            this.welcomeANDstandard.Multiline = true;
            this.welcomeANDstandard.Name = "welcomeANDstandard";
            this.welcomeANDstandard.SelectedIndex = 0;
            this.welcomeANDstandard.Size = new System.Drawing.Size(800, 451);
            this.welcomeANDstandard.TabIndex = 0;
            // 
            // LoadingPage
            // 
            this.LoadingPage.Controls.Add(this.CouldNotConnect);
            this.LoadingPage.Controls.Add(this.ConnectToServer);
            this.LoadingPage.Location = new System.Drawing.Point(4, 5);
            this.LoadingPage.Name = "LoadingPage";
            this.LoadingPage.Padding = new System.Windows.Forms.Padding(3);
            this.LoadingPage.Size = new System.Drawing.Size(792, 442);
            this.LoadingPage.TabIndex = 0;
            this.LoadingPage.Text = "tabPage1";
            this.LoadingPage.UseVisualStyleBackColor = true;
            // 
            // CouldNotConnect
            // 
            this.CouldNotConnect.Enabled = false;
            this.CouldNotConnect.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CouldNotConnect.Location = new System.Drawing.Point(267, 153);
            this.CouldNotConnect.Name = "CouldNotConnect";
            this.CouldNotConnect.ReadOnly = true;
            this.CouldNotConnect.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.CouldNotConnect.Size = new System.Drawing.Size(245, 87);
            this.CouldNotConnect.TabIndex = 1;
            this.CouldNotConnect.TabStop = false;
            this.CouldNotConnect.Text = "Could Not Connect.\nMake Sure the Server is online then try again.\n";
            this.CouldNotConnect.Visible = false;
            // 
            // ConnectToServer
            // 
            this.ConnectToServer.Location = new System.Drawing.Point(339, 246);
            this.ConnectToServer.Name = "ConnectToServer";
            this.ConnectToServer.Size = new System.Drawing.Size(96, 61);
            this.ConnectToServer.TabIndex = 0;
            this.ConnectToServer.Text = "Connect To Server";
            this.ConnectToServer.UseVisualStyleBackColor = true;
            this.ConnectToServer.Click += new System.EventHandler(this.ConnectToServer_Click);
            // 
            // WelcomePage
            // 
            this.WelcomePage.Controls.Add(this.GotoCreateNewUser);
            this.WelcomePage.Controls.Add(this.GotoSignIn);
            this.WelcomePage.Location = new System.Drawing.Point(4, 5);
            this.WelcomePage.Name = "WelcomePage";
            this.WelcomePage.Padding = new System.Windows.Forms.Padding(3);
            this.WelcomePage.Size = new System.Drawing.Size(792, 442);
            this.WelcomePage.TabIndex = 1;
            this.WelcomePage.Text = "tabPage2";
            this.WelcomePage.UseVisualStyleBackColor = true;
            // 
            // GotoCreateNewUser
            // 
            this.GotoCreateNewUser.Location = new System.Drawing.Point(420, 189);
            this.GotoCreateNewUser.Name = "GotoCreateNewUser";
            this.GotoCreateNewUser.Size = new System.Drawing.Size(131, 63);
            this.GotoCreateNewUser.TabIndex = 1;
            this.GotoCreateNewUser.Text = "Create a New User";
            this.GotoCreateNewUser.UseVisualStyleBackColor = true;
            this.GotoCreateNewUser.Click += new System.EventHandler(this.GotoCreateNewUser_Click);
            // 
            // GotoSignIn
            // 
            this.GotoSignIn.Location = new System.Drawing.Point(234, 189);
            this.GotoSignIn.Name = "GotoSignIn";
            this.GotoSignIn.Size = new System.Drawing.Size(145, 63);
            this.GotoSignIn.TabIndex = 0;
            this.GotoSignIn.Text = "Sign in";
            this.GotoSignIn.UseVisualStyleBackColor = true;
            this.GotoSignIn.Click += new System.EventHandler(this.GotoSignIn_Click);
            // 
            // SigninPage
            // 
            this.SigninPage.Controls.Add(this.Backtowelcome);
            this.SigninPage.Controls.Add(this.panel1);
            this.SigninPage.Location = new System.Drawing.Point(4, 5);
            this.SigninPage.Name = "SigninPage";
            this.SigninPage.Size = new System.Drawing.Size(792, 442);
            this.SigninPage.TabIndex = 2;
            this.SigninPage.Text = "tabPage1";
            this.SigninPage.UseVisualStyleBackColor = true;
            this.SigninPage.Click += new System.EventHandler(this.BackToWelcome);
            // 
            // Backtowelcome
            // 
            this.Backtowelcome.Location = new System.Drawing.Point(709, 6);
            this.Backtowelcome.Name = "Backtowelcome";
            this.Backtowelcome.Size = new System.Drawing.Size(75, 23);
            this.Backtowelcome.TabIndex = 1;
            this.Backtowelcome.Text = "Back";
            this.Backtowelcome.UseVisualStyleBackColor = true;
            this.Backtowelcome.Click += new System.EventHandler(this.BackToWelcome);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.SignInPassword);
            this.panel1.Controls.Add(this.SignInUname);
            this.panel1.Controls.Add(this.SignInTextbox);
            this.panel1.Location = new System.Drawing.Point(269, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(222, 265);
            this.panel1.TabIndex = 0;
            // 
            // richTextBox1
            // 
            this.richTextBox1.ForeColor = System.Drawing.Color.Red;
            this.richTextBox1.Location = new System.Drawing.Point(15, 47);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(189, 96);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(69, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Sign In";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // SignInPassword
            // 
            this.SignInPassword.Location = new System.Drawing.Point(43, 178);
            this.SignInPassword.Name = "SignInPassword";
            this.SignInPassword.PasswordChar = '*';
            this.SignInPassword.PlaceholderText = "Enter Password Here";
            this.SignInPassword.Size = new System.Drawing.Size(128, 23);
            this.SignInPassword.TabIndex = 2;
            this.SignInPassword.UseSystemPasswordChar = true;
            // 
            // SignInUname
            // 
            this.SignInUname.Location = new System.Drawing.Point(43, 149);
            this.SignInUname.Name = "SignInUname";
            this.SignInUname.PlaceholderText = "Enter Username Here";
            this.SignInUname.Size = new System.Drawing.Size(128, 23);
            this.SignInUname.TabIndex = 1;
            // 
            // SignInTextbox
            // 
            this.SignInTextbox.Location = new System.Drawing.Point(59, 18);
            this.SignInTextbox.Name = "SignInTextbox";
            this.SignInTextbox.Size = new System.Drawing.Size(94, 23);
            this.SignInTextbox.TabIndex = 0;
            this.SignInTextbox.Text = "Sign in";
            this.SignInTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NewUserPage
            // 
            this.NewUserPage.Controls.Add(this.button3);
            this.NewUserPage.Controls.Add(this.panel2);
            this.NewUserPage.Location = new System.Drawing.Point(4, 5);
            this.NewUserPage.Name = "NewUserPage";
            this.NewUserPage.Size = new System.Drawing.Size(792, 442);
            this.NewUserPage.TabIndex = 3;
            this.NewUserPage.Text = "NewUserPage";
            this.NewUserPage.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(711, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Back";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.BackToWelcome);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Info;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.NewUserConfirmPword);
            this.panel2.Controls.Add(this.NewUserErrorMessage);
            this.panel2.Controls.Add(this.CreateUserButton);
            this.panel2.Controls.Add(this.NewUserPword);
            this.panel2.Controls.Add(this.NewUserUname);
            this.panel2.Controls.Add(this.CreateNewUsertitle);
            this.panel2.Location = new System.Drawing.Point(271, 83);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(222, 265);
            this.panel2.TabIndex = 2;
            // 
            // NewUserConfirmPword
            // 
            this.NewUserConfirmPword.Location = new System.Drawing.Point(43, 206);
            this.NewUserConfirmPword.Name = "NewUserConfirmPword";
            this.NewUserConfirmPword.PasswordChar = '*';
            this.NewUserConfirmPword.PlaceholderText = "Confirm Password";
            this.NewUserConfirmPword.Size = new System.Drawing.Size(128, 23);
            this.NewUserConfirmPword.TabIndex = 5;
            this.NewUserConfirmPword.UseSystemPasswordChar = true;
            // 
            // NewUserErrorMessage
            // 
            this.NewUserErrorMessage.ForeColor = System.Drawing.Color.Red;
            this.NewUserErrorMessage.Location = new System.Drawing.Point(15, 47);
            this.NewUserErrorMessage.Name = "NewUserErrorMessage";
            this.NewUserErrorMessage.Size = new System.Drawing.Size(189, 96);
            this.NewUserErrorMessage.TabIndex = 4;
            this.NewUserErrorMessage.Text = "";
            // 
            // CreateUserButton
            // 
            this.CreateUserButton.Location = new System.Drawing.Point(68, 235);
            this.CreateUserButton.Name = "CreateUserButton";
            this.CreateUserButton.Size = new System.Drawing.Size(75, 23);
            this.CreateUserButton.TabIndex = 3;
            this.CreateUserButton.Text = "Create User";
            this.CreateUserButton.UseVisualStyleBackColor = true;
            // 
            // NewUserPword
            // 
            this.NewUserPword.Location = new System.Drawing.Point(43, 178);
            this.NewUserPword.Name = "NewUserPword";
            this.NewUserPword.PasswordChar = '*';
            this.NewUserPword.PlaceholderText = "Enter Password";
            this.NewUserPword.Size = new System.Drawing.Size(128, 23);
            this.NewUserPword.TabIndex = 2;
            this.NewUserPword.UseSystemPasswordChar = true;
            // 
            // NewUserUname
            // 
            this.NewUserUname.Location = new System.Drawing.Point(43, 149);
            this.NewUserUname.Name = "NewUserUname";
            this.NewUserUname.PlaceholderText = "Enter Username Here";
            this.NewUserUname.Size = new System.Drawing.Size(128, 23);
            this.NewUserUname.TabIndex = 1;
            // 
            // CreateNewUsertitle
            // 
            this.CreateNewUsertitle.Location = new System.Drawing.Point(55, 18);
            this.CreateNewUsertitle.Name = "CreateNewUsertitle";
            this.CreateNewUsertitle.Size = new System.Drawing.Size(107, 23);
            this.CreateNewUsertitle.TabIndex = 0;
            this.CreateNewUsertitle.Text = "Create A New User";
            this.CreateNewUsertitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tabControl2
            // 
            this.tabControl2.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl2.Controls.Add(this.tabPage1);
            this.tabControl2.Controls.Add(this.tabPage2);
            this.tabControl2.Enabled = false;
            this.tabControl2.ItemSize = new System.Drawing.Size(0, 1);
            this.tabControl2.Location = new System.Drawing.Point(0, -1);
            this.tabControl2.Multiline = true;
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(800, 451);
            this.tabControl2.TabIndex = 0;
            this.tabControl2.Visible = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 442);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 442);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.welcomeANDstandard);
            this.Controls.Add(this.tabControl2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.welcomeANDstandard.ResumeLayout(false);
            this.LoadingPage.ResumeLayout(false);
            this.WelcomePage.ResumeLayout(false);
            this.SigninPage.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.NewUserPage.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl welcomeANDstandard;
        internal TabPage LoadingPage;
        private Button ConnectToServer;
        private TabPage SigninPage;
        private TabControl tabControl2;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private RichTextBox CouldNotConnect;
        private TabPage WelcomePage;
        private Panel panel1;
        private RichTextBox richTextBox1;
        private Button button1;
        private TextBox SignInPassword;
        private TextBox SignInUname;
        private TextBox SignInTextbox;
        private TabPage NewUserPage;
        private Button Backtowelcome;
        private Button GotoCreateNewUser;
        private Button GotoSignIn;
        private Button button3;
        private Panel panel2;
        private TextBox NewUserConfirmPword;
        private RichTextBox NewUserErrorMessage;
        private Button CreateUserButton;
        private TextBox NewUserPword;
        private TextBox NewUserUname;
        private TextBox CreateNewUsertitle;
    }
}