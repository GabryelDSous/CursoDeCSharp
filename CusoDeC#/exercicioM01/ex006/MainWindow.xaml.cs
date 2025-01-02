using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ex006
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            // Ano atual
            int anoAtul = DateTime.Now.Year;

            // Pegando o ano de nascimento do usuario
            int anoNasc = Convert.ToInt16(blocoAnoNasc.Text);

            // Sobre o ano atual
            txtAnoAtual.Text = $"Estamo no ano de {anoAtul}";
            txtAnoAtual.Visibility = Visibility.Visible;

            // Sobre a idade do usuario
            int idade = anoAtul - anoNasc;
            txtIdade.Text = $"Quem nasceu em {anoNasc} vai ter {idade} anos.";
            txtIdade.Visibility = Visibility.Visible;
        }
    }
}
