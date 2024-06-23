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
    public partial class Form2_3 : Form
    {
        public Form2_3()
        {
            InitializeComponent();

            rbalstn.Checked = false;
            rbghksgml.Checked = false;
            rbghrbs.Checked = false;
            rbcofls.Checked = false;
            rbwogud.Checked = false;
            rbgustn.Checked = false;
            rbwjdtn.Checked = false;
        }

        Form2_6 form2_6 = new Form2_6();
        private void btclick_Click(object sender, EventArgs e)
        {
            if (rbalstn.Checked == false && rbghksgml.Checked == false && rbghrbs.Checked == false &&
                rbcofls.Checked == false && rbwogud.Checked == false && rbgustn.Checked == false && rbwjdtn.Checked == false)
            {
                MessageBox.Show("원장님을 선택하지 않으셨습니다."); return;
            }
            else if (rbalstn.Checked == true)
            {
                Info.Instance.Doctor = rbalstn.Text;
                MessageBox.Show("권민수 원장님을 선택하셨습니다.");
                form2_6.Show(); this.Close();
            }
            else if (rbghksgml.Checked == true)
            {
                Info.Instance.Doctor = rbghksgml.Text;
                MessageBox.Show("이환희 원장님을 선택하셨습니다.");
                form2_6.Show(); this.Close();
            }
            else if (rbghrbs.Checked == true)
            {
                Info.Instance.Doctor = rbghrbs.Text;
                MessageBox.Show("정호균 원장님을 선택하셨습니다.");
                form2_6.Show(); this.Close();
            }
            else if (rbcofls.Checked == true)
            {
                Info.Instance.Doctor = rbcofls.Text;
                MessageBox.Show("박채린 원장님을 선택하셨습니다.");
                form2_6.Show(); this.Close();
            }
            else if (rbwogud.Checked == true)
            {
                Info.Instance.Doctor = rbwogud.Text;
                MessageBox.Show("박재형 원장님을 선택하셨습니다.");
                form2_6.Show(); this.Close();
            }
            else if (rbgustn.Checked == true)
            {
                Info.Instance.Doctor = rbgustn.Text;
                MessageBox.Show("경현수 원장님을 선택하셨습니다.");
                form2_6.Show(); this.Close();
            }
            else if (rbwjdtn.Checked == true)
            {
                Info.Instance.Doctor = rbwjdtn.Text;
                MessageBox.Show("김정수 원장님을 선택하셨습니다.");
                form2_6.Show(); this.Close();
            }

        }
    }
}
