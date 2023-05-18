namespace MachBankingApp
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            TitlePictureBox = new PictureBox();
            LoginButton = new Button();
            NewUserButton = new Button();
            ((System.ComponentModel.ISupportInitialize)TitlePictureBox).BeginInit();
            SuspendLayout();
            // 
            // TitlePictureBox
            // 
            TitlePictureBox.Image = (System.Drawing.Image)resources.GetObject("TitlePictureBox.Image");
            TitlePictureBox.Location = new System.Drawing.Point(221, 47);
            TitlePictureBox.Name = "TitlePictureBox";
            TitlePictureBox.Size = new System.Drawing.Size(441, 74);
            TitlePictureBox.TabIndex = 0;
            TitlePictureBox.TabStop = false;
            // 
            // LoginButton
            // 
            LoginButton.Location = new System.Drawing.Point(287, 142);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new System.Drawing.Size(219, 84);
            LoginButton.TabIndex = 1;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            // 
            // NewUserButton
            // 
            NewUserButton.Location = new System.Drawing.Point(287, 232);
            NewUserButton.Name = "NewUserButton";
            NewUserButton.Size = new System.Drawing.Size(219, 84);
            NewUserButton.TabIndex = 2;
            NewUserButton.Text = "Create Account";
            NewUserButton.UseVisualStyleBackColor = true;
            NewUserButton.Click += NewUserButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(NewUserButton);
            Controls.Add(LoginButton);
            Controls.Add(TitlePictureBox);
            MaximizeBox = false;
            MaximumSize = new System.Drawing.Size(816, 489);
            MinimumSize = new System.Drawing.Size(816, 489);
            Name = "MainForm";
            Text = "Mach Banking App";
            ((System.ComponentModel.ISupportInitialize)TitlePictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox TitlePictureBox;
        private Button LoginButton;
        private Button NewUserButton;
    }
}