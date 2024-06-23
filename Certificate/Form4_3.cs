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
    public partial class Form4_3 : Form
    {
        public Form4_3()
        {
            InitializeComponent();
        }

        private void Form4_3_Load(object sender, EventArgs e)
        {
            lbName.Text = Info.Instance.Name;
            lbAdress.Text = Info.Instance.Adress;
            lbIdNumber.Text = Info.Instance.IdNumber;
            lbDoctor.Text = Info.Instance.Doctor;
            label6.Text = string.Format("{0}\n\n\n 위와 같은 증상에 대한 진료를 하였습니다.", Info.Instance.RichBox);

            DateTime now = DateTime.Now;
            int year = now.Year;
            int month = now.Month;
            int day = now.Day;
            lbTime.Text = string.Format("{0}년 {1}월 {2}일", year, month, day);
            lbTime2.Text = string.Format("{0}년 {1}월 {2}일", year, month, day);
            lbTime3.Text = string.Format("{0}년 {1}월 {2}일", year, month, day);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("진료확인서가 출력되었습니다.");
            this.Close();
        }
    }
}
