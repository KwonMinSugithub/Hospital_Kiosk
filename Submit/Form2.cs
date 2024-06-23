using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Kiosk
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btCheck_Click(object sender, EventArgs e)
        {
            if (tbName.Text == "")
            {
                MessageBox.Show("성함을 입력하지 않았습니다."); return;
            }
            if (tbIdNumber.Text == "") 
            {
                MessageBox.Show("주민번호 앞자리를 입력하지 않았습니다."); return;
            }
            if (tbCallNumber.Text == "") 
            {
                MessageBox.Show("연락처를 입력하지 않았습니다."); return;
            }
            if (richTextBox1.Text == "") 
            {
                MessageBox.Show("주소를 입력하지 않았습니다."); return;
            }
            if (rbAgree.Checked == false && rbDisAgree.Checked == false) 
            {
                MessageBox.Show("개인정보 수집에 동의에 체크하지 않으셨습니다."); return;
            }
            if (rbDisAgree.Checked == true)
            {
                MessageBox.Show("개인정보 수집에 동의하지 않으셨습니다."); return;
            }
            if (rbAgree.Checked == true) MessageBox.Show("개인정보 수집에 동의하셨습니다.");

            Info.Instance.Name = tbName.Text;
            Info.Instance.IdNumber = tbIdNumber.Text;
            Info.Instance.CallNumber = tbCallNumber.Text;
            Info.Instance.Adress = richTextBox1.Text;
            
            Form2_1 form2_1 = new Form2_1();
            form2_1.Show();
            this.Close();
        }
        
    }
}
