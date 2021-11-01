using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCong_Click(object sender, EventArgs e)
        {
            int a, b, KetQua;
            if (txtSoA.Text!="")
            {
                a = Int32.Parse(txtSoA.ToString());
                b = Int32.Parse(txtSoB.ToString());
                KetQua = a + b;
                txtKQ.Text = KetQua.ToString(); 
            }

        }
    }
}
