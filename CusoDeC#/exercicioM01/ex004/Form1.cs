using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex004
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            // Capturando o valor digitado
            float val = Convert.ToSingle(caixaNum.Text);
            // O valor digitado é: 
            valDigitado.Text = $"Você digitou o valor {val:c3}";
            valDigitado.Visible = true;
            // O valor inteiro é: 
            valInteiro.Text = $"A parte inteira é {Math.Floor(val)}";
            valInteiro.Visible = true;
            // O valor arredondando para o inteiro mais proximo é: 
            valArredondado.Text = $"Arredondado, temos {Math.Round(val)}";
            valArredondado.Visible = true;
        }
    }
}
