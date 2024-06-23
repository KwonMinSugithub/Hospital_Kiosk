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
    public partial class Form2_1 : Form
    {
        public Form2_1()
        {
            InitializeComponent();
            rbMed.Checked = false;
            rbEar.Checked = false;
            rbLogy.Checked = false;
            rbSur.Checked = false;
        }

        private void btCheck_Click(object sender, EventArgs e)
        {
            
            if(rbMed.Checked == false && rbEar.Checked == false && rbSur.Checked == false && rbLogy.Checked == false)
            {
                MessageBox.Show("진료과를 선택하지 않으셨습니다. "); return;
            }
            if (rbMed.Checked) MessageBox.Show("내과를 선택하셨습니다.");
            if (rbEar.Checked) MessageBox.Show("이비인후과를 선택하셨습니다.");
            if (rbSur.Checked) MessageBox.Show("외과를 선택하셨습니다.");
            if (rbLogy.Checked) MessageBox.Show("비뇨기과를 선택하셨습니다.");

            Form2_2 form2_2 = new Form2_2();
            Form2_3 form2_3 = new Form2_3();
            Form2_4 form2_4 = new Form2_4();
            Form2_5 form2_5 = new Form2_5();

            if (rbMed.Checked == true)
            {
                form2_2.Show();
                this.Close();
            }
            if(rbSur.Checked == true)
            {
                form2_3.Show();
                this.Close();
            }
            if(rbEar.Checked == true)
            {
                form2_4.Show();
                this.Close();
            }
            if(rbLogy.Checked == true)
            {
                form2_5.Show();
                this.Close();
            }
        }
    }
}
