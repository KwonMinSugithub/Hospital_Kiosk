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
    public partial class Form3_1 : Form
    {
        public Form3_1()
        {
            InitializeComponent();
        }

        private void cbPay_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbPayInfo.Items.Clear();

            if (cbPay.SelectedIndex == 0)
            {
                lbPayInfo.Items.Add("일시불");
                lbPayInfo.Items.Add("3개월 할부");
                lbPayInfo.Items.Add("6개월 할부");
                lbPayInfo.Items.Add("12개월 할부");
            }
        }
        private void btPay_Click(object sender, EventArgs e)
        {
            if (cbPay.Text == "" || lbPayInfo.Text == "") //콤보박스와 리스트박스가 공백이라면
            {
                MessageBox.Show("결제방법 및 정보를 다시 확인해 주세요");
                return;              
            }
            string str = cbPay.Text + "(으)로 " + lbPayInfo.Text + "결제방법을 " + "선택하셨습니다.";
            MessageBox.Show(str);
            
            Form3_2 form3_2 = new Form3_2();
            form3_2.Show();
            this.Close();
        }
    }
}
