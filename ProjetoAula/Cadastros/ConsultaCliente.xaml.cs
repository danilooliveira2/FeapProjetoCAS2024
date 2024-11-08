using ProjetoAula.Modelos;
using ProjetoAula.Repositorios;
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

namespace ProjetoAula.Cadastros
{
    /// <summary>
    /// Lógica interna para ConsultaCliente.xaml
    /// </summary>
    public partial class ConsultaCliente : Window
    {


        public ConsultaCliente()
        {
            InitializeComponent();


            repCliente = new ClienteRepositorio(Conexao.stringConexao);
            CarregarClientes();
        }



        private void CarregarClientes()
        {
            // Carregar a lista de clientes
            listaCLientes = repCliente.GetClientes();

            //Limpa o grid, antes de guardar os dados
            gridClientes.Items.Clear();

            //Populo o Grid com os dados da minha lista
            gridClientes.ItemsSource = listaCLientes;

        }



        List<Cliente> listaCLientes;
        ClienteRepositorio repCliente;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CadastroCliente janelaCadastroCliente = new CadastroCliente();
            janelaCadastroCliente.Show();
        }

        private void gridClientes_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {


            if (gridClientes.SelectedItem is Cliente cliente)
            {

                //Demonstração de como capturar o registro clicado no GRID
                //Após a captura, você poderá fazer alguma ação,
                //como editar os dados, cadastrar um pedido para o cliente, e assim por diante.

                int idCliente = cliente.ClienteID;
                
                MessageBox.Show("O ID do cliente clicado é " + idCliente);
                MessageBox.Show("O Nome do cliente clicado  " + cliente.Nome);


            }




        }
    }

}
