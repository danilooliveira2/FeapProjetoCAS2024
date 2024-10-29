using ProjetoAula.Modelos;
using ProjetoAula.Repositorios;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProjetoAula
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

      //public static  Cliente usuarioLogado;

        private void btnEntrar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //MessageBox.Show("Olá Mundo!");
                //MessageBox.Show("Olá Mundo!", "Atenção");

                //MessageBox.Show("Você confirma que quer exibir a mensagem?", "Atenção", MessageBoxButton.YesNo);

                //MessageBox.Show("Você confirma que quer exibir a mensagem?", "Atenção", MessageBoxButton.YesNo, MessageBoxImage.Error);


                string login = txtLogin.Text;

                string senha = txtSenha.Password;

                
                
                //Valida os campos, antes de passar para o Banco de Dados analisar se existe o cliente

                if (String.IsNullOrEmpty(login) || login.Length < 3)
                {
                    MessageBox.Show("Digite um login.");
                    return;
                }

                if (String.IsNullOrEmpty(senha))
                {

                    MessageBox.Show("Digite a senha.");
                    return;
                }



                //MessageBox.Show(
                //    $"Esses são os dados digitados pelo usuário: " +
                //    $"\nLogin: {login} " +
                //    $"\nSenha: {senha}",
                //    "Atenção", MessageBoxButton.OK, MessageBoxImage.Information);



                //Cria o repositorio, que cria o cliente
                ClienteRepositorio cliRep = new ClienteRepositorio(Conexao.stringConexao);

                //Guarda o cliente logado, na janela chamada Principal.
                //Assim, ficará centralizado nessa janela Principal os dados do usuário que entrou no sistema.
                Principal.UsuarioLogado = cliRep.FazerLogin(login, senha);

                //Se o cliente retornado, for diferente de nulo, 
                //quer dizer que foi retornado corretamente os dados do usuário logado
                //E foi atribuido em uma variável estática da janela Principal
                //Assim, qualquer janela pode chamar o Principal.UsuarioLogado para pegar 
                //Os dados do usuário, como o nome, ou ID.
                if (Principal.UsuarioLogado != null)
                {

                    Principal janelaPrincipal = new Principal();
                    this.Close();
                    janelaPrincipal.Show();

                }

                //Próximos passos:

                // Criar a conexão com o banco de dados para verificar se o login e senha da pessoa está correto.


            }
            catch (Exception excecao)
            {
                MessageBox.Show("Ocorreu um erro inesperado: \n" + excecao.Message);

            }




        }



    }
}