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
    public partial class Form4_2 : Form
    {
        public Form4_2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("결제가 완료되었습니다.");
            Form4_3 form4_3 = new Form4_3();
            form4_3.Show();
            this.Close();
        }
       
    }
}
