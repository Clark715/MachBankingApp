namespace MachBankingApp
{
    partial class LoginForm
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
            TextboxUser = new TextBox();
            TextboxPassword = new TextBox();
            ButtonLogin = new Button();
            SuspendLayout();
            // 
            // TextboxUser
            // 
            TextboxUser.Location = new System.Drawing.Point(178, 33);
            TextboxUser.MaxLength = 20;
            TextboxUser.Name = "TextboxUser";
            TextboxUser.Size = new System.Drawing.Size(206, 23);
            TextboxUser.TabIndex = 0;
            TextboxUser.Text = "Username...";
            // 
            // TextboxPassword
            // 
            TextboxPassword.Location = new System.Drawing.Point(178, 62);
            TextboxPassword.MaxLength = 20;
            TextboxPassword.Name = "TextboxPassword";
            TextboxPassword.Size = new System.Drawing.Size(206, 23);
            TextboxPassword.TabIndex = 1;
            TextboxPassword.Text = "Password...";
            // 
            // ButtonLogin
            // 
            ButtonLogin.Location = new System.Drawing.Point(178, 91);
            ButtonLogin.Name = "ButtonLogin";
            ButtonLogin.Size = new System.Drawing.Size(206, 23);
            ButtonLogin.TabIndex = 2;
            ButtonLogin.Text = "Login";
            ButtonLogin.UseVisualStyleBackColor = true;
            ButtonLogin.Click += ButtonLogin_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(570, 162);
            Controls.Add(ButtonLogin);
            Controls.Add(TextboxPassword);
            Controls.Add(TextboxUser);
            MaximizeBox = false;
            MaximumSize = new System.Drawing.Size(586, 201);
            MinimumSize = new System.Drawing.Size(586, 201);
            Name = "LoginForm";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TextboxUser;
        private TextBox TextboxPassword;
        private Button ButtonLogin;
    }
}