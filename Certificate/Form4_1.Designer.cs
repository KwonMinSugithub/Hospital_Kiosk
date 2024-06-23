namespace Hospital_Kiosk
{
    partial class Form4_1
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
            groupBox1 = new System.Windows.Forms.GroupBox();
            label1 = new System.Windows.Forms.Label();
            lbPayInfo = new System.Windows.Forms.ListBox();
            btPay = new System.Windows.Forms.Button();
            cbPay = new System.Windows.Forms.ComboBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(lbPayInfo);
            groupBox1.Controls.Add(btPay);
            groupBox1.Controls.Add(cbPay);
            groupBox1.Location = new System.Drawing.Point(11, 11);
            groupBox1.Margin = new System.Windows.Forms.Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(2);
            groupBox1.Size = new System.Drawing.Size(455, 208);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(21, 17);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(258, 25);
            label1.TabIndex = 6;
            label1.Text = "2. 결제 방법을 선택해주세요";
            // 
            // lbPayInfo
            // 
            lbPayInfo.FormattingEnabled = true;
            lbPayInfo.ItemHeight = 15;
            lbPayInfo.Items.AddRange(new object[] { "일시불 및 할부 " });
            lbPayInfo.Location = new System.Drawing.Point(207, 82);
            lbPayInfo.Margin = new System.Windows.Forms.Padding(2);
            lbPayInfo.Name = "lbPayInfo";
            lbPayInfo.Size = new System.Drawing.Size(118, 79);
            lbPayInfo.TabIndex = 4;
            // 
            // btPay
            // 
            btPay.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btPay.Location = new System.Drawing.Point(381, 176);
            btPay.Margin = new System.Windows.Forms.Padding(2);
            btPay.Name = "btPay";
            btPay.Size = new System.Drawing.Size(70, 28);
            btPay.TabIndex = 2;
            btPay.Text = "결제";
            btPay.UseVisualStyleBackColor = true;
            btPay.Click += btPay_Click;
            // 
            // cbPay
            // 
            cbPay.FormattingEnabled = true;
            cbPay.Items.AddRange(new object[] { "신용카드" });
            cbPay.Location = new System.Drawing.Point(85, 82);
            cbPay.Margin = new System.Windows.Forms.Padding(2);
            cbPay.Name = "cbPay";
            cbPay.Size = new System.Drawing.Size(118, 23);
            cbPay.TabIndex = 0;
            cbPay.SelectedIndexChanged += cbPay_SelectedIndexChanged;
            // 
            // Form4_1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.Info;
            ClientSize = new System.Drawing.Size(483, 237);
            Controls.Add(groupBox1);
            Name = "Form4_1";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Form4_1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbPayInfo;
        private System.Windows.Forms.Button btPay;
        private System.Windows.Forms.ComboBox cbPay;
    }
}