namespace MachBankingApp
{
    partial class NewAccountForm
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
            NewAccountLabel = new Label();
            TextboxFirstName = new TextBox();
            LabelFirstName = new Label();
            label1 = new Label();
            TextboxLastName = new TextBox();
            label2 = new Label();
            TextboxUser = new TextBox();
            TextboxPass = new TextBox();
            label3 = new Label();
            LabelUsernameHint = new Label();
            TextboxEmail = new TextBox();
            LabelEmail = new Label();
            TextboxPhoneNum = new TextBox();
            LabelPhoneNum = new Label();
            ButtonCreateAccount = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // NewAccountLabel
            // 
            NewAccountLabel.AutoSize = true;
            NewAccountLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            NewAccountLabel.Location = new System.Drawing.Point(12, 9);
            NewAccountLabel.Name = "NewAccountLabel";
            NewAccountLabel.Size = new System.Drawing.Size(733, 20);
            NewAccountLabel.TabIndex = 0;
            NewAccountLabel.Text = "Welcome to Colby's Mach Banking! To create an account, simply fill out the required information below.";
            // 
            // TextboxFirstName
            // 
            TextboxFirstName.Location = new System.Drawing.Point(85, 62);
            TextboxFirstName.Name = "TextboxFirstName";
            TextboxFirstName.Size = new System.Drawing.Size(276, 23);
            TextboxFirstName.TabIndex = 1;
            // 
            // LabelFirstName
            // 
            LabelFirstName.AutoSize = true;
            LabelFirstName.Location = new System.Drawing.Point(12, 65);
            LabelFirstName.Name = "LabelFirstName";
            LabelFirstName.Size = new System.Drawing.Size(67, 15);
            LabelFirstName.TabIndex = 2;
            LabelFirstName.Text = "First Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(13, 94);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(66, 15);
            label1.TabIndex = 3;
            label1.Text = "Last Name:";
            // 
            // TextboxLastName
            // 
            TextboxLastName.Location = new System.Drawing.Point(85, 91);
            TextboxLastName.Name = "TextboxLastName";
            TextboxLastName.Size = new System.Drawing.Size(276, 23);
            TextboxLastName.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(16, 123);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(63, 15);
            label2.TabIndex = 5;
            label2.Text = "Username:";
            // 
            // TextboxUser
            // 
            TextboxUser.Location = new System.Drawing.Point(85, 120);
            TextboxUser.MaxLength = 20;
            TextboxUser.Name = "TextboxUser";
            TextboxUser.Size = new System.Drawing.Size(276, 23);
            TextboxUser.TabIndex = 6;
            // 
            // TextboxPass
            // 
            TextboxPass.Location = new System.Drawing.Point(85, 149);
            TextboxPass.MaxLength = 20;
            TextboxPass.Name = "TextboxPass";
            TextboxPass.Size = new System.Drawing.Size(276, 23);
            TextboxPass.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(19, 152);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(60, 15);
            label3.TabIndex = 7;
            label3.Text = "Password:";
            // 
            // LabelUsernameHint
            // 
            LabelUsernameHint.AutoSize = true;
            LabelUsernameHint.Font = new Font("Segoe UI", 8F, FontStyle.Italic, GraphicsUnit.Point);
            LabelUsernameHint.Location = new System.Drawing.Point(384, 123);
            LabelUsernameHint.Name = "LabelUsernameHint";
            LabelUsernameHint.Size = new System.Drawing.Size(359, 13);
            LabelUsernameHint.TabIndex = 9;
            LabelUsernameHint.Text = "(Username must be greater than 8 characters, and less than 20 characters.)";
            // 
            // TextboxEmail
            // 
            TextboxEmail.Location = new System.Drawing.Point(85, 178);
            TextboxEmail.Name = "TextboxEmail";
            TextboxEmail.Size = new System.Drawing.Size(276, 23);
            TextboxEmail.TabIndex = 12;
            // 
            // LabelEmail
            // 
            LabelEmail.AutoSize = true;
            LabelEmail.Location = new System.Drawing.Point(40, 181);
            LabelEmail.Name = "LabelEmail";
            LabelEmail.Size = new System.Drawing.Size(39, 15);
            LabelEmail.TabIndex = 11;
            LabelEmail.Text = "Email:";
            LabelEmail.TextAlign = ContentAlignment.TopRight;
            // 
            // TextboxPhoneNum
            // 
            TextboxPhoneNum.Location = new System.Drawing.Point(85, 207);
            TextboxPhoneNum.MaxLength = 10;
            TextboxPhoneNum.Name = "TextboxPhoneNum";
            TextboxPhoneNum.Size = new System.Drawing.Size(276, 23);
            TextboxPhoneNum.TabIndex = 14;
            // 
            // LabelPhoneNum
            // 
            LabelPhoneNum.AutoSize = true;
            LabelPhoneNum.Location = new System.Drawing.Point(25, 210);
            LabelPhoneNum.Name = "LabelPhoneNum";
            LabelPhoneNum.Size = new System.Drawing.Size(54, 15);
            LabelPhoneNum.TabIndex = 13;
            LabelPhoneNum.Text = "Phone #:";
            // 
            // ButtonCreateAccount
            // 
            ButtonCreateAccount.Location = new System.Drawing.Point(610, 228);
            ButtonCreateAccount.Name = "ButtonCreateAccount";
            ButtonCreateAccount.Size = new System.Drawing.Size(135, 23);
            ButtonCreateAccount.TabIndex = 15;
            ButtonCreateAccount.Text = "Create Account";
            ButtonCreateAccount.UseVisualStyleBackColor = true;
            ButtonCreateAccount.Click += ButtonCreateAccount_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 8F, FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(384, 153);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(356, 13);
            label4.TabIndex = 16;
            label4.Text = "(Password must be greater than 8 characters, and less than 20 characters.)";
            // 
            // NewAccountForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(757, 263);
            Controls.Add(label4);
            Controls.Add(ButtonCreateAccount);
            Controls.Add(TextboxPhoneNum);
            Controls.Add(LabelPhoneNum);
            Controls.Add(TextboxEmail);
            Controls.Add(LabelEmail);
            Controls.Add(LabelUsernameHint);
            Controls.Add(TextboxPass);
            Controls.Add(label3);
            Controls.Add(TextboxUser);
            Controls.Add(label2);
            Controls.Add(TextboxLastName);
            Controls.Add(label1);
            Controls.Add(LabelFirstName);
            Controls.Add(TextboxFirstName);
            Controls.Add(NewAccountLabel);
            MaximizeBox = false;
            MaximumSize = new System.Drawing.Size(773, 302);
            MinimumSize = new System.Drawing.Size(773, 302);
            Name = "NewAccountForm";
            Text = "NewAccountForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label NewAccountLabel;
        private TextBox TextboxFirstName;
        private Label LabelFirstName;
        private Label label1;
        private TextBox TextboxLastName;
        private Label label2;
        private TextBox TextboxUser;
        private TextBox TextboxPass;
        private Label label3;
        private Label LabelUsernameHint;
        private TextBox TextboxEmail;
        private Label LabelEmail;
        private TextBox TextboxPhoneNum;
        private Label LabelPhoneNum;
        private Button ButtonCreateAccount;
        private Label label4;
    }
}