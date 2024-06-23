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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tbName.Text == Info.Instance.Name && tbIdNumber.Text == Info.Instance.IdNumber)
            {
                MessageBox.Show(string.Format("{0}님의 수납 요금은 100만원 입니다.\n결제창으로 넘어갑니다.", tbName.Text));
            }
            else
            {
                MessageBox.Show("수납자의 정보가 올바르지 않습니다.\n다시 입력해주세요."); return;
            }
            Form3_1 form3_1 = new Form3_1();
            form3_1.Show();
            this.Close();

        }
    }
}
