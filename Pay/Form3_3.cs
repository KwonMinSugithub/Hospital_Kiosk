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
    public partial class Form3_3 : Form
    {
        public Form3_3()
        {
            InitializeComponent();
        }

        private void Form3_3_Load(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            label1.Text = Info.Instance.Name;
            label3.Text = Info.Instance.IdNumber;
            label4.Text = Info.Instance.RichBox + "\n" + "위와 같은 증상을 해결해주는 약";
            label8.Text = Info.Instance.Doctor;

            DateTime now = DateTime.Now;
            int year = now.Year;
            int month = now.Month;
            int day = now.Day;
            label9.Text = string.Format("{0}년 {1}월 {2}일", year, month, day);

        }

        private void btStart_Click(object sender, EventArgs e)
        {
            MessageBox.Show("처방전이 출력되었습니다.");
            Program.cnt--;
            this.Close();
        }
    }
}
