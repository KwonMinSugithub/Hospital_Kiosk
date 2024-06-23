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
    public partial class Form2_5 : Form
    {
        public Form2_5()
        {
            InitializeComponent();
            rbrjsdk.Checked = false;
            rbehdals.Checked = false;
            rbrhkddnr.Checked = false;
            rbwodud.Checked = false;
            rbalstjr.Checked = false;
            rbgkfla.Checked = false;

        }

        Form2_6 form2_6 = new Form2_6();
        private void btclick_Click(object sender, EventArgs e)
        {
            if (rbrjsdk.Checked == false && rbehdals.Checked == false && rbrhkddnr.Checked == false && rbwodud.Checked == false &&
                  rbalstjr.Checked == false && rbgkfla.Checked == false)
            {               
                MessageBox.Show("원장님을 선택하지 않으셨습니다.");
                return;
            }
            else if (rbrjsdk.Checked == true)
            {
                Info.Instance.Doctor = rbrjsdk.Text;
                MessageBox.Show("전건아 원장님을 선택하셨습니다.");
                form2_6.Show(); this.Close();
            }
            else if (rbehdals.Checked == true)
            {
                Info.Instance.Doctor = rbehdals.Text;
                MessageBox.Show("신동민 원장님을 선택하셨습니다.");
                form2_6.Show(); this.Close();
            }
            else if (rbrhkddnr.Checked == true)
            {
                Info.Instance.Doctor = rbrhkddnr.Text;
                MessageBox.Show("김광욱 원장님을 선택하셨습니다.");
                form2_6.Show(); this.Close();
            }
            else if (rbwodud.Checked == true)
            {
                Info.Instance.Doctor = rbwodud.Text;
                MessageBox.Show("박재영 원장님을 선택하셨습니다.");
                form2_6.Show(); this.Close();
            }
            else if (rbalstjr.Checked == true)
            {
                Info.Instance.Doctor = rbalstjr.Text;
                MessageBox.Show("김민석 원장님을 선택하셨습니다.");
                form2_6.Show(); this.Close();
            }
            else if (rbgkfla.Checked == true)
            {
                Info.Instance.Doctor = rbgkfla.Text;
                MessageBox.Show("강하림 원장님을 선택하셨습니다.");
                form2_6.Show(); this.Close();
            }
        }
    }
}
