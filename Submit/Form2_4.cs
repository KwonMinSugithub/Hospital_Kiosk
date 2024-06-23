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
    public partial class Form2_4 : Form
    {
        public Form2_4()
        {
            InitializeComponent();

            rbxodns.Checked = false;
            rbwnsdud.Checked = false; 
            rbtldus.Checked = false;
            rbwjdrl.Checked = false;
            rbqudgns.Checked = false;
            rbgksrlf.Checked = false;
        }

        Form2_6 form2_6 = new Form2_6();
        private void btInsert_Click(object sender, EventArgs e)
        {
            if (rbxodns.Checked == false && rbwnsdud.Checked == false && rbtldus.Checked == false &&
                rbwjdrl.Checked == false && rbqudgns.Checked == false && rbgksrlf.Checked == false)
            {
                MessageBox.Show("원장님을 선택하지 않았습니다."); return;
            }
            else if (rbxodns.Checked == true)
            {
                Info.Instance.Doctor = rbxodns.Text;
                MessageBox.Show("김태운 원장님을 선택하셨습니다.");
                form2_6.Show(); this.Close();
            }
            else if (rbwnsdud.Checked == true)
            {
                Info.Instance.Doctor = rbwnsdud.Text;
                MessageBox.Show("이준영 원장님을 선택하셨습니다.");
                form2_6.Show(); this.Close();
            }
            else if (rbtldus.Checked == true)
            {
                Info.Instance.Doctor = rbtldus.Text;
                MessageBox.Show("박시연 원장님을 선택하셨습니다.");
                form2_6.Show(); this.Close();
            }
            else if (rbwjdrl.Checked == true)
            {
                Info.Instance.Doctor = rbwjdrl.Text;
                MessageBox.Show("김정기 원장님을 선택하셨습니다.");
                form2_6.Show(); this.Close();
            }
            else if (rbqudgns.Checked == true)
            {
                Info.Instance.Doctor = rbqudgns.Text;
                MessageBox.Show("김병훈 원장님을 선택하셨습니다.");
                form2_6.Show(); this.Close();
            }
            else if (rbgksrlf.Checked == true)
            {
                Info.Instance.Doctor = rbgksrlf.Text;
                MessageBox.Show("정한길 원장님을 선택하셨습니다.");
                form2_6.Show(); this.Close();
            }

            form2_6.Show(); this.Close();
        }  
    }
}
