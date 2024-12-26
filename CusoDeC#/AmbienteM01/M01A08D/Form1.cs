using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M01A08D
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ulong num = Convert.ToUInt64(txtNum.Text);
            lblRes.Text = "O dobro de "+num+" é "+(num*2);
            lblRes.Visible = true;
        }
    }
}
