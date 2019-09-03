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
    /// Lógica interna para WPF_Contato.xaml
    /// </summary>
    public partial class WPF_Contato : Window
    {

        public ViewModel.AgendaViewModel AgendaViewModel { get; set; }

        public WPF_Contato()
        {
            InitializeComponent();
            this.AgendaViewModel = new ViewModel.AgendaViewModel();
            this.DataContext = this;
        }

        private void btn_adicionar_Click(object sender, RoutedEventArgs e)
        {
            this.AgendaViewModel.Adicionar();
        }

        private void btn_salvar_Click(object sender, RoutedEventArgs e)
        {
            this.AgendaViewModel.Salvar();
            this.Close();
        }
    }
}
