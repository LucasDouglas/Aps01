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
using System.Windows.Shapes;

namespace TrabalhoDesafio
{
    /// <summary>
    /// Lógica interna para WPF_Compromissos.xaml
    /// </summary>
    public partial class WPF_Compromissos : Window
    {
        public ViewModel.CompromissoViewModel CompromissoViewModel { get; set; }
        public WPF_Compromissos()
        {
            InitializeComponent();
            this.CompromissoViewModel = new ViewModel.CompromissoViewModel();
            this.DataContext = this;
        }

        private void btn_adicionar_Click(object sender, RoutedEventArgs e)
        {
            this.CompromissoViewModel.Adicionar();
        }

        private void btn_salvar_Click(object sender, RoutedEventArgs e)
        {
            this.CompromissoViewModel.Salvar();
            this.Close();
        }
    }
}
