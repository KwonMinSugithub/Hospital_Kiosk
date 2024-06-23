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
    public partial class Form3_2 : Form
    {
        public Form3_2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("결제가 완료되었습니다.");

            this.Close();
            Form3_3 form3_3 = new Form3_3();
            form3_3.Show();
        }
    }
}
