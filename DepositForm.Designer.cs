namespace MachBankingApp
{
    partial class DepositFormWindow
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
            textboxDeposit = new TextBox();
            labelDeposit = new Label();
            depositSubmit = new Button();
            depositCancel = new Button();
            SuspendLayout();
            // 
            // textboxDeposit
            // 
            textboxDeposit.Location = new System.Drawing.Point(183, 65);
            textboxDeposit.Name = "textboxDeposit";
            textboxDeposit.Size = new System.Drawing.Size(205, 23);
            textboxDeposit.TabIndex = 0;
            // 
            // labelDeposit
            // 
            labelDeposit.AutoSize = true;
            labelDeposit.Location = new System.Drawing.Point(80, 68);
            labelDeposit.Name = "labelDeposit";
            labelDeposit.Size = new System.Drawing.Size(97, 15);
            labelDeposit.TabIndex = 1;
            labelDeposit.Text = "Deposit Amount:";
            // 
            // depositSubmit
            // 
            depositSubmit.Location = new System.Drawing.Point(12, 94);
            depositSubmit.Name = "depositSubmit";
            depositSubmit.Size = new System.Drawing.Size(457, 23);
            depositSubmit.TabIndex = 2;
            depositSubmit.Text = "Submit";
            depositSubmit.UseVisualStyleBackColor = true;
            depositSubmit.Click += depositSubmit_Click;
            // 
            // depositCancel
            // 
            depositCancel.Location = new System.Drawing.Point(12, 122);
            depositCancel.Name = "depositCancel";
            depositCancel.Size = new System.Drawing.Size(457, 23);
            depositCancel.TabIndex = 3;
            depositCancel.Text = "Cancel";
            depositCancel.UseVisualStyleBackColor = true;
            depositCancel.Click += depositCancel_Click;
            // 
            // DepositFormWindow
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(481, 157);
            Controls.Add(depositCancel);
            Controls.Add(depositSubmit);
            Controls.Add(labelDeposit);
            Controls.Add(textboxDeposit);
            MaximizeBox = false;
            MaximumSize = new System.Drawing.Size(497, 196);
            MinimumSize = new System.Drawing.Size(497, 196);
            Name = "DepositFormWindow";
            Text = "Deposit";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textboxDeposit;
        private Label labelDeposit;
        private Button depositSubmit;
        private Button depositCancel;
    }
}