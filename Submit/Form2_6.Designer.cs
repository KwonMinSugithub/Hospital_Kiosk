namespace Hospital_Kiosk
{
    partial class Form2_6
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
            groupBox3 = new System.Windows.Forms.GroupBox();
            btCheck = new System.Windows.Forms.Button();
            label6 = new System.Windows.Forms.Label();
            RichBoxInput = new System.Windows.Forms.RichTextBox();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btCheck);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(RichBoxInput);
            groupBox3.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            groupBox3.Location = new System.Drawing.Point(10, 10);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new System.Drawing.Size(651, 385);
            groupBox3.TabIndex = 41;
            groupBox3.TabStop = false;
            // 
            // btCheck
            // 
            btCheck.Location = new System.Drawing.Point(559, 329);
            btCheck.Name = "btCheck";
            btCheck.Size = new System.Drawing.Size(75, 43);
            btCheck.TabIndex = 18;
            btCheck.Text = "확인";
            btCheck.UseVisualStyleBackColor = true;
            btCheck.Click += btCheck_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(11, 20);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(123, 25);
            label6.TabIndex = 17;
            label6.Text = "3. 증상입력 :";
            // 
            // RichBoxInput
            // 
            RichBoxInput.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            RichBoxInput.Location = new System.Drawing.Point(135, 19);
            RichBoxInput.Name = "RichBoxInput";
            RichBoxInput.Size = new System.Drawing.Size(499, 306);
            RichBoxInput.TabIndex = 0;
            RichBoxInput.Text = "";
            // 
            // Form2_6
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.Info;
            ClientSize = new System.Drawing.Size(671, 404);
            Controls.Add(groupBox3);
            Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            Name = "Form2_6";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Form2_6";
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btCheck;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox RichBoxInput;
    }
}