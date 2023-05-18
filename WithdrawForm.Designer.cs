namespace MachBankingApp
{
    partial class WithdrawFormWindow
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
            withdrawCancel = new Button();
            withdrawSubmit = new Button();
            labelWithdraw = new Label();
            textboxWithdraw = new TextBox();
            SuspendLayout();
            // 
            // withdrawCancel
            // 
            withdrawCancel.Location = new System.Drawing.Point(12, 122);
            withdrawCancel.Name = "withdrawCancel";
            withdrawCancel.Size = new System.Drawing.Size(457, 23);
            withdrawCancel.TabIndex = 7;
            withdrawCancel.Text = "Cancel";
            withdrawCancel.UseVisualStyleBackColor = true;
            withdrawCancel.Click += withdrawCancel_Click;
            // 
            // withdrawSubmit
            // 
            withdrawSubmit.Location = new System.Drawing.Point(12, 94);
            withdrawSubmit.Name = "withdrawSubmit";
            withdrawSubmit.Size = new System.Drawing.Size(457, 23);
            withdrawSubmit.TabIndex = 6;
            withdrawSubmit.Text = "Submit";
            withdrawSubmit.UseVisualStyleBackColor = true;
            withdrawSubmit.Click += withdrawSubmit_Click;
            // 
            // labelWithdraw
            // 
            labelWithdraw.AutoSize = true;
            labelWithdraw.Location = new System.Drawing.Point(72, 68);
            labelWithdraw.Name = "labelWithdraw";
            labelWithdraw.Size = new System.Drawing.Size(108, 15);
            labelWithdraw.TabIndex = 5;
            labelWithdraw.Text = "Withdraw Amount:";
            // 
            // textboxWithdraw
            // 
            textboxWithdraw.Location = new System.Drawing.Point(183, 65);
            textboxWithdraw.Name = "textboxWithdraw";
            textboxWithdraw.Size = new System.Drawing.Size(205, 23);
            textboxWithdraw.TabIndex = 4;
            // 
            // WithdrawFormWindow
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(481, 157);
            Controls.Add(withdrawCancel);
            Controls.Add(withdrawSubmit);
            Controls.Add(labelWithdraw);
            Controls.Add(textboxWithdraw);
            MaximumSize = new System.Drawing.Size(497, 196);
            MinimumSize = new System.Drawing.Size(497, 196);
            Name = "WithdrawFormWindow";
            Text = "WithdrawForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button withdrawCancel;
        private Button withdrawSubmit;
        private Label labelWithdraw;
        private TextBox textboxWithdraw;
    }
}