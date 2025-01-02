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

namespace ex008
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

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            //pegando o inicio e fim do sorteio
            int inicio = Convert.ToInt32(txtInicio.Text);
            int fim = Convert.ToInt32(txtFim.Text);

            //Random
            Random sorteio = new Random();

            int sorte = sorteio.Next(inicio, fim+1);

            //lblSort
            lblSort.Visibility = Visibility.Visible;
            lblSort.Content = $"Sorteando de {inicio} a {fim}";

            await Task.Delay(2000);
            lblSort.Content = $"Sorteei o valor {sorte}";
            
        }
    }
}
