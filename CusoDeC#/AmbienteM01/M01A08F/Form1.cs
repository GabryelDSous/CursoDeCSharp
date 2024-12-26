using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M01A08F
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDobro_Click(object sender, EventArgs e)
        {
            int n;
            string texto = txtNum.Text;
            txtNum.Visible = true;
            int.TryParse(texto, out n);
            int d = n * 2;
            lblRes.Text = $"O dobro de {n} é {d}";
            lblRes.Visible = true;
        }
    }
}
