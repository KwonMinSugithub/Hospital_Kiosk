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
    public partial class Form2_6 : Form
    {
        public Form2_6()
        {
            InitializeComponent();
        }

        private void btCheck_Click(object sender, EventArgs e)
        {
            Info.Instance.RichBox = RichBoxInput.Text;
            if (RichBoxInput.Text == "")
            {
                MessageBox.Show("증상을 입력하지 않았습니다."); return;
            }
            else
            {
                MessageBox.Show(string.Format("접수되었습니다.\n당신의 대기번호는 {0}번입니다.", Hospital_Kiosk.Program.cnt++));
                this.Close();
            }      
        }

    }
}
