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
<<<<<<< HEAD
            if (txtSoA.Text!="")
            {
                a = Int32.Parse(txtSoA.ToString());
                b = Int32.Parse(txtSoB.ToString());
                KetQua = a + b;
                txtKQ.Text = KetQua.ToString(); 
            }
=======
            a = Int32.Parse(txtSoA.Text);
            b = Int32.Parse(txtSoB.Text);
            KetQua = a + b;
            txtKQ.Text = KetQua.ToString();
>>>>>>> 28e258b7b3cca488b369a5b966f21a285035b90d

        }

        private void btTru_Click(object sender, EventArgs e)
        {
            int a, b, KetQua;
            a = Int32.Parse(txtSoA.Text);
            b = Int32.Parse(txtSoB.Text);
            KetQua = a - b;
            txtKQ.Text = KetQua.ToString();
        }
    }
}
