using ProjetoAula.Modelos;
using ProjetoAula.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Lógica interna para CadastroCliente.xaml
    /// </summary>
    public partial class CadastroCliente : Window
    {
        public CadastroCliente()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, RoutedEventArgs e)
        {

            if (ValidarCampos())
            {


                //Partes do Banco de Dados a seguir...
                ClienteRepositorio cliRep = new ClienteRepositorio(Conexao.stringConexao);

                Cliente clienteNovo = new Cliente();

                clienteNovo.Nome = txtNome.Text;
                clienteNovo.CPF = Convert.ToInt32( txtCPF.Text);
                clienteNovo.Senha = txtSenha.Password;
                clienteNovo.Email = txtEmail.Text;

                cliRep.InserirCliente(clienteNovo);


            }

            


        }


        private bool ValidarCampos()
        {
            if (String.IsNullOrEmpty(txtNome.Text) || txtNome.Text.Length <= 3)
            {
                txtNome.Focus();    
                MessageBox.Show("O nome é muito curto ou inválido");
                return false;
            }


            if (String.IsNullOrEmpty(txtSenha.Password) || txtSenha.Password.Length <= 6)
            {
                txtSenha.Focus();
                MessageBox.Show("A senha é muito curta ou inválida.");
                return false;
            }



            if (String.IsNullOrEmpty(txtEmail.Text) || txtEmail.Text.Length <= 10)
            {
                txtEmail.Focus();
                MessageBox.Show("O e-mail é muito curto ou inválido.");
                return false;
            }

            BigInteger numeroCPF;


            if (String.IsNullOrEmpty(txtCPF.Text) || txtCPF.Text.Length < 9
               ||  !BigInteger.TryParse( txtCPF.Text, out numeroCPF)  
               
               )
            {
                txtCPF.Focus();
                MessageBox.Show("O CPF é muito curto ou inválido.");
                return false;
            }


            return true;

        }

    }
}
