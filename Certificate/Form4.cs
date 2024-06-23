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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tbName.Text == Info.Instance.Name && tbIdNumber.Text == Info.Instance.IdNumber)
            {
                MessageBox.Show(string.Format("{0}님 확인되었습니다.\n결제금액은 1,000원입니다.", tbName.Text));
            }
            else if (tbName.Text == "")
            {
                MessageBox.Show("성함을 입력하지 않았습니다."); return;
            }
            else if(tbIdNumber.Text =="")
            {
                MessageBox.Show("주민번호 앞자리를 입력하지 않았습니다."); return;
            }
            else if(tbName.Text != Info.Instance.Name || tbIdNumber.Text != Info.Instance.IdNumber)
            {
                MessageBox.Show("올바르지 않습니다."); return;
            }

            Form4_1 form4_1 = new Form4_1();
            form4_1.ShowDialog();
            this.Close();
               
        }
    }
}
