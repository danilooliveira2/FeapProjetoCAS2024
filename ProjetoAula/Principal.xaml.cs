using ProjetoAula.Cadastros;
using ProjetoAula.Modelos;
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

namespace ProjetoAula
{
    /// <summary>
    /// Lógica interna para Principal.xaml
    /// </summary>
    public partial class Principal : Window
    {

        Cliente usuarioLogado;

        public Principal()
        {

            InitializeComponent();
            //    usuarioLogado = new Cliente();
            //    this.usuarioLogado = usuarioLogado;
            //}

            //usuarioLogado = MainWindow.usuar
        }



        private void btnCadastrarCliente_Click(object sender, RoutedEventArgs e)
        {


            CadastroCliente janelaCadastroCliente = new CadastroCliente();
            janelaCadastroCliente.Show();


        }
    }
}
