namespace Hospital_Kiosk
{
    partial class Form2_1
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
            btCheck = new System.Windows.Forms.Button();
            label5 = new System.Windows.Forms.Label();
            rbLogy = new System.Windows.Forms.RadioButton();
            rbMed = new System.Windows.Forms.RadioButton();
            rbEar = new System.Windows.Forms.RadioButton();
            rbSur = new System.Windows.Forms.RadioButton();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btCheck);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(rbLogy);
            groupBox1.Controls.Add(rbMed);
            groupBox1.Controls.Add(rbEar);
            groupBox1.Controls.Add(rbSur);
            groupBox1.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            groupBox1.Location = new System.Drawing.Point(15, 16);
            groupBox1.Margin = new System.Windows.Forms.Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(4);
            groupBox1.Size = new System.Drawing.Size(441, 277);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            // 
            // btCheck
            // 
            btCheck.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btCheck.Location = new System.Drawing.Point(360, 219);
            btCheck.Margin = new System.Windows.Forms.Padding(4);
            btCheck.Name = "btCheck";
            btCheck.Size = new System.Drawing.Size(73, 51);
            btCheck.TabIndex = 12;
            btCheck.Text = "확인";
            btCheck.UseVisualStyleBackColor = true;
            btCheck.Click += btCheck_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(35, 69);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(170, 32);
            label5.TabIndex = 11;
            label5.Text = "2. 진료과 선택";
            // 
            // rbLogy
            // 
            rbLogy.AutoSize = true;
            rbLogy.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            rbLogy.Location = new System.Drawing.Point(224, 175);
            rbLogy.Margin = new System.Windows.Forms.Padding(4);
            rbLogy.Name = "rbLogy";
            rbLogy.Size = new System.Drawing.Size(99, 27);
            rbLogy.TabIndex = 10;
            rbLogy.Text = "비뇨기과";
            rbLogy.UseVisualStyleBackColor = true;
            // 
            // rbMed
            // 
            rbMed.AutoSize = true;
            rbMed.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            rbMed.Location = new System.Drawing.Point(94, 139);
            rbMed.Margin = new System.Windows.Forms.Padding(4);
            rbMed.Name = "rbMed";
            rbMed.Size = new System.Drawing.Size(65, 27);
            rbMed.TabIndex = 9;
            rbMed.Text = "내과";
            rbMed.UseVisualStyleBackColor = true;
            // 
            // rbEar
            // 
            rbEar.AutoSize = true;
            rbEar.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            rbEar.Location = new System.Drawing.Point(94, 175);
            rbEar.Margin = new System.Windows.Forms.Padding(4);
            rbEar.Name = "rbEar";
            rbEar.Size = new System.Drawing.Size(116, 27);
            rbEar.TabIndex = 9;
            rbEar.Text = "이비인후과";
            rbEar.UseVisualStyleBackColor = true;
            // 
            // rbSur
            // 
            rbSur.AutoSize = true;
            rbSur.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            rbSur.Location = new System.Drawing.Point(224, 139);
            rbSur.Margin = new System.Windows.Forms.Padding(4);
            rbSur.Name = "rbSur";
            rbSur.Size = new System.Drawing.Size(65, 27);
            rbSur.TabIndex = 9;
            rbSur.Text = "외과";
            rbSur.UseVisualStyleBackColor = true;
            // 
            // Form2_1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.Info;
            ClientSize = new System.Drawing.Size(480, 328);
            Controls.Add(groupBox1);
            Margin = new System.Windows.Forms.Padding(4);
            Name = "Form2_1";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Form2_1";
            TopMost = true;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btCheck;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbLogy;
        private System.Windows.Forms.RadioButton rbMed;
        private System.Windows.Forms.RadioButton rbEar;
        private System.Windows.Forms.RadioButton rbSur;
    }
}