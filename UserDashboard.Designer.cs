namespace MachBankingApp
{
    partial class UserDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserDashboard));
            dashLabelGreeting = new Label();
            dashButtonSignout = new Button();
            dashLabelBalance = new Label();
            textboxbalance = new TextBox();
            dashButtonDeposit = new Button();
            dashButtonWithdraw = new Button();
            pictureBox1 = new PictureBox();
            dashLabelLastLogin = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dashLabelGreeting
            // 
            dashLabelGreeting.AutoSize = true;
            dashLabelGreeting.Font = new Font("Sitka Banner", 15F, FontStyle.Bold, GraphicsUnit.Point);
            dashLabelGreeting.Location = new System.Drawing.Point(12, 9);
            dashLabelGreeting.Name = "dashLabelGreeting";
            dashLabelGreeting.Size = new System.Drawing.Size(140, 29);
            dashLabelGreeting.TabIndex = 0;
            dashLabelGreeting.Text = "PLACEHOLDER";
            // 
            // dashButtonSignout
            // 
            dashButtonSignout.Location = new System.Drawing.Point(643, 415);
            dashButtonSignout.Name = "dashButtonSignout";
            dashButtonSignout.Size = new System.Drawing.Size(145, 23);
            dashButtonSignout.TabIndex = 1;
            dashButtonSignout.Text = "Sign Out";
            dashButtonSignout.UseVisualStyleBackColor = true;
            dashButtonSignout.Click += dashButtonSignout_Click;
            // 
            // dashLabelBalance
            // 
            dashLabelBalance.AutoSize = true;
            dashLabelBalance.Location = new System.Drawing.Point(241, 134);
            dashLabelBalance.Name = "dashLabelBalance";
            dashLabelBalance.Size = new System.Drawing.Size(96, 15);
            dashLabelBalance.TabIndex = 2;
            dashLabelBalance.Text = "Account Balance";
            // 
            // textboxbalance
            // 
            textboxbalance.BorderStyle = BorderStyle.FixedSingle;
            textboxbalance.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textboxbalance.Location = new System.Drawing.Point(241, 152);
            textboxbalance.Name = "textboxbalance";
            textboxbalance.ReadOnly = true;
            textboxbalance.Size = new System.Drawing.Size(297, 23);
            textboxbalance.TabIndex = 3;
            textboxbalance.TabStop = false;
            // 
            // dashButtonDeposit
            // 
            dashButtonDeposit.Location = new System.Drawing.Point(287, 181);
            dashButtonDeposit.Name = "dashButtonDeposit";
            dashButtonDeposit.Size = new System.Drawing.Size(210, 58);
            dashButtonDeposit.TabIndex = 4;
            dashButtonDeposit.Text = "Deposit";
            dashButtonDeposit.UseVisualStyleBackColor = true;
            dashButtonDeposit.Click += dashButtonDeposit_Click;
            // 
            // dashButtonWithdraw
            // 
            dashButtonWithdraw.Location = new System.Drawing.Point(287, 245);
            dashButtonWithdraw.Name = "dashButtonWithdraw";
            dashButtonWithdraw.Size = new System.Drawing.Size(210, 58);
            dashButtonWithdraw.TabIndex = 5;
            dashButtonWithdraw.Text = "Withdraw";
            dashButtonWithdraw.UseVisualStyleBackColor = true;
            dashButtonWithdraw.Click += dashButtonWithdraw_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(206, 355);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(390, 83);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // dashLabelLastLogin
            // 
            dashLabelLastLogin.AutoSize = true;
            dashLabelLastLogin.Font = new Font("Segoe UI", 8F, FontStyle.Italic, GraphicsUnit.Point);
            dashLabelLastLogin.Location = new System.Drawing.Point(15, 35);
            dashLabelLastLogin.Name = "dashLabelLastLogin";
            dashLabelLastLogin.Size = new System.Drawing.Size(36, 13);
            dashLabelLastLogin.TabIndex = 7;
            dashLabelLastLogin.Text = "label1";
            // 
            // UserDashboard
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(dashLabelLastLogin);
            Controls.Add(pictureBox1);
            Controls.Add(dashButtonWithdraw);
            Controls.Add(dashButtonDeposit);
            Controls.Add(textboxbalance);
            Controls.Add(dashLabelBalance);
            Controls.Add(dashButtonSignout);
            Controls.Add(dashLabelGreeting);
            MaximizeBox = false;
            MaximumSize = new System.Drawing.Size(816, 489);
            MinimumSize = new System.Drawing.Size(816, 489);
            Name = "UserDashboard";
            Text = "Account Dashboard";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label dashLabelGreeting;
        private Button dashButtonSignout;
        private Label dashLabelBalance;
        private TextBox textboxbalance;
        private Button dashButtonDeposit;
        private Button dashButtonWithdraw;
        private PictureBox pictureBox1;
        private Label dashLabelLastLogin;
    }
}