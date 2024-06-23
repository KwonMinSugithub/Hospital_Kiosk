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
    public partial class Form2_2 : Form
    {
        public Form2_2()
        {
            InitializeComponent();

            rbwndhr.Checked = false;
            rbalrud.Checked = false;
            rbrbwls.Checked = false;
            rbdmsxo.Checked = false;
            rbwnsry.Checked = false;
            rbehdnjs.Checked = false;
            rbdnduf.Checked = false;
        }

        Form2_6 form2_6 = new Form2_6();

        private void btInsert_Click(object sender, EventArgs e)
        {
            
            if (rbwndhr.Checked == false && rbalrud.Checked == false && rbrbwls.Checked == false && rbdmsxo.Checked == false &&
                rbwnsry.Checked == false && rbehdnjs.Checked == false && rbdnduf.Checked == false)
            {
                MessageBox.Show("원장님을 선택하지 않으셨습니다.");
                return;
            }
            else if (rbwndhr.Checked == true)
            {
                Info.Instance.Doctor = rbwndhr.Text;
                MessageBox.Show("허주옥 원장님을 선택하셨습니다.");
                form2_6.Show(); this.Close();
            }
            else if (rbalrud.Checked == true)
            {
                Info.Instance.Doctor = rbalrud.Text;
                MessageBox.Show("이미경 원장님을 선택하셨습니다.");
                form2_6.Show(); this.Close();
            }
            else if (rbrbwls.Checked == true)
            {
                Info.Instance.Doctor = rbrbwls.Text;
                MessageBox.Show("이규진 원장님을 선택하셨습니다.");
                form2_6.Show(); this.Close();
            }
            else if (rbdmsxo.Checked == true)
            {
                Info.Instance.Doctor = rbdmsxo.Text;
                MessageBox.Show("정은태 원장님을 선택하셨습니다.");
                form2_6.Show(); this.Close();
            }
            else if (rbwnsry.Checked == true)
            {
                Info.Instance.Doctor = rbwnsry.Text;
                MessageBox.Show("오준교 원장님을 선택하셨습니다.");
                form2_6.Show(); this.Close();
            }
            else if (rbehdnjs.Checked == true)
            {
                Info.Instance.Doctor = rbehdnjs.Text;
                MessageBox.Show("신도원 원장님을 선택하셨습니다.");
                form2_6.Show(); this.Close();
            }
            else if (rbdnduf.Checked == true)
            {
                Info.Instance.Doctor = rbdnduf.Text;
                MessageBox.Show("이우열 원장님을 선택하셨습니다.");
                form2_6.Show(); this.Close();
            }
        }


    }
}
