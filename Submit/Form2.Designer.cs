namespace Hospital_Kiosk
{
    partial class Form2
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
            groupBox2 = new System.Windows.Forms.GroupBox();
            richTextBox1 = new System.Windows.Forms.RichTextBox();
            tbName = new System.Windows.Forms.TextBox();
            lbName = new System.Windows.Forms.Label();
            lbIdNumber = new System.Windows.Forms.Label();
            lbCallNumber = new System.Windows.Forms.Label();
            lbAdress = new System.Windows.Forms.Label();
            tbIdNumber = new System.Windows.Forms.TextBox();
            tbCallNumber = new System.Windows.Forms.TextBox();
            btCheck = new System.Windows.Forms.Button();
            rbDisAgree = new System.Windows.Forms.RadioButton();
            rbAgree = new System.Windows.Forms.RadioButton();
            label2 = new System.Windows.Forms.Label();
            groupBox1 = new System.Windows.Forms.GroupBox();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(richTextBox1);
            groupBox2.Controls.Add(tbName);
            groupBox2.Controls.Add(lbName);
            groupBox2.Controls.Add(lbIdNumber);
            groupBox2.Controls.Add(lbCallNumber);
            groupBox2.Controls.Add(lbAdress);
            groupBox2.Controls.Add(tbIdNumber);
            groupBox2.Controls.Add(tbCallNumber);
            groupBox2.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            groupBox2.Location = new System.Drawing.Point(0, 10);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(460, 206);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            groupBox2.Text = "1. 개인정보입력";
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            richTextBox1.Location = new System.Drawing.Point(144, 120);
            richTextBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new System.Drawing.Size(310, 74);
            richTextBox1.TabIndex = 3;
            richTextBox1.Text = "";
            // 
            // tbName
            // 
            tbName.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            tbName.Location = new System.Drawing.Point(143, 46);
            tbName.Name = "tbName";
            tbName.Size = new System.Drawing.Size(311, 23);
            tbName.TabIndex = 0;
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbName.Location = new System.Drawing.Point(87, 46);
            lbName.Name = "lbName";
            lbName.Size = new System.Drawing.Size(58, 21);
            lbName.TabIndex = 3;
            lbName.Text = "성함 : ";
            // 
            // lbIdNumber
            // 
            lbIdNumber.AutoSize = true;
            lbIdNumber.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbIdNumber.Location = new System.Drawing.Point(4, 70);
            lbIdNumber.Name = "lbIdNumber";
            lbIdNumber.Size = new System.Drawing.Size(138, 21);
            lbIdNumber.TabIndex = 4;
            lbIdNumber.Text = "주민번호 앞자리 :";
            // 
            // lbCallNumber
            // 
            lbCallNumber.AutoSize = true;
            lbCallNumber.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbCallNumber.Location = new System.Drawing.Point(72, 93);
            lbCallNumber.Name = "lbCallNumber";
            lbCallNumber.Size = new System.Drawing.Size(68, 21);
            lbCallNumber.TabIndex = 5;
            lbCallNumber.Text = "연락처 :";
            // 
            // lbAdress
            // 
            lbAdress.AutoSize = true;
            lbAdress.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbAdress.Location = new System.Drawing.Point(87, 117);
            lbAdress.Name = "lbAdress";
            lbAdress.Size = new System.Drawing.Size(52, 21);
            lbAdress.TabIndex = 6;
            lbAdress.Text = "주소 :";
            // 
            // tbIdNumber
            // 
            tbIdNumber.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            tbIdNumber.Location = new System.Drawing.Point(143, 70);
            tbIdNumber.Name = "tbIdNumber";
            tbIdNumber.Size = new System.Drawing.Size(311, 23);
            tbIdNumber.TabIndex = 1;
            // 
            // tbCallNumber
            // 
            tbCallNumber.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            tbCallNumber.Location = new System.Drawing.Point(143, 94);
            tbCallNumber.Name = "tbCallNumber";
            tbCallNumber.Size = new System.Drawing.Size(311, 23);
            tbCallNumber.TabIndex = 2;
            // 
            // btCheck
            // 
            btCheck.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btCheck.Location = new System.Drawing.Point(379, 134);
            btCheck.Name = "btCheck";
            btCheck.Size = new System.Drawing.Size(75, 40);
            btCheck.TabIndex = 6;
            btCheck.Text = "확인";
            btCheck.UseVisualStyleBackColor = true;
            btCheck.Click += btCheck_Click;
            // 
            // rbDisAgree
            // 
            rbDisAgree.AutoSize = true;
            rbDisAgree.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            rbDisAgree.Location = new System.Drawing.Point(215, 100);
            rbDisAgree.Name = "rbDisAgree";
            rbDisAgree.Size = new System.Drawing.Size(83, 21);
            rbDisAgree.TabIndex = 5;
            rbDisAgree.TabStop = true;
            rbDisAgree.Text = "동의 안함";
            rbDisAgree.UseVisualStyleBackColor = true;
            // 
            // rbAgree
            // 
            rbAgree.AutoSize = true;
            rbAgree.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            rbAgree.Location = new System.Drawing.Point(117, 100);
            rbAgree.Name = "rbAgree";
            rbAgree.Size = new System.Drawing.Size(52, 21);
            rbAgree.TabIndex = 4;
            rbAgree.TabStop = true;
            rbAgree.Text = "동의";
            rbAgree.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(60, 46);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(320, 25);
            label2.TabIndex = 8;
            label2.Text = "개인정보 수집에 동의하시겠습니까?\r\n";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btCheck);
            groupBox1.Controls.Add(rbDisAgree);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(rbAgree);
            groupBox1.Location = new System.Drawing.Point(4, 221);
            groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            groupBox1.Size = new System.Drawing.Size(456, 178);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.Info;
            ClientSize = new System.Drawing.Size(471, 409);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form2";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Form2";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbIdNumber;
        private System.Windows.Forms.Label lbCallNumber;
        private System.Windows.Forms.Label lbAdress;
        private System.Windows.Forms.TextBox tbIdNumber;
        private System.Windows.Forms.TextBox tbCallNumber;
        private System.Windows.Forms.RadioButton rbDisAgree;
        private System.Windows.Forms.RadioButton rbAgree;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btCheck;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}