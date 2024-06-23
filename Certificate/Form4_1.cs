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
    public partial class Form4_1 : Form
    {
        public Form4_1()
        {
            InitializeComponent();
        }

        private void cbPay_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbPayInfo.Items.Clear();

            if (cbPay.SelectedIndex == 0)
            {
                lbPayInfo.Items.Add("일시불");
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

            Form4_2 form4_2 = new Form4_2();
            form4_2.Show();
            this.Close();
        }
    }
}
