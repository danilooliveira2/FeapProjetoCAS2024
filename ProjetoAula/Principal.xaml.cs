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

        public static Cliente UsuarioLogado;


        public Principal()
        {

            InitializeComponent();

            //Demonstração de uso da variável, para monstrar uma mensagem
            //Como essa janela é a "Principal", não precisa colocar "Principal.",
            //é só colocar o nome da variável direto.
            MessageBox.Show("Bem-vindo ao sistema " + UsuarioLogado.Nome);
        
        }




        private void btnCadastrarCliente_Click(object sender, RoutedEventArgs e)
        {

            //Chama a janela de cadastro de cliente
            CadastroCliente janelaCadastroCliente = new CadastroCliente();
            janelaCadastroCliente.Show();

            //Se quiser que a janela seja obrigatoria, e impeça a pessoa
            //de fazer qualquer outra coisa, enquanto não finaliza o cadastro,
            //poderá ser chamado o ShowDialog()

        }
    }
}
