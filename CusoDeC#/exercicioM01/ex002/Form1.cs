using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex002
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnClick_Click(object sender, EventArgs e)
        {
            txtMeu.Visible = true;
            txtBrasil.Visible = true;
            txtBrasileiro.Visible = true;

            await Task.Delay(1000);
            txtMeu.BackColor = Color.Blue;
            txtMeu.ForeColor = Color.White;

            await Task.Delay(1000);
            txtBrasil.BackColor = Color.Yellow;
            txtBrasil.ForeColor = Color.Green;

            await Task.Delay(1000);
            txtBrasileiro.BackColor = Color.Green;
            txtBrasileiro.ForeColor = Color.Yellow;
        }
    }
}
