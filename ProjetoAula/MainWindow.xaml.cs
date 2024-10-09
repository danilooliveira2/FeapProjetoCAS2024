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


        private void btnEntrar_Click(object sender, RoutedEventArgs e)
        {

            //MessageBox.Show("Olá Mundo!");
            //MessageBox.Show("Olá Mundo!", "Atenção");

            //MessageBox.Show("Você confirma que quer exibir a mensagem?", "Atenção", MessageBoxButton.YesNo);

            //MessageBox.Show("Você confirma que quer exibir a mensagem?", "Atenção", MessageBoxButton.YesNo, MessageBoxImage.Error);

            string login = txtLogin.Text;

            string senha = txtSenha.Text;


            MessageBox.Show(
                $"Esses são os dados digitados pelo usuário: " +
                $"\nLogin: {login} " +
                $"\nSenha: {senha}",
                "Atenção", MessageBoxButton.OKCancel, MessageBoxImage.Information);



            //Próximos passos:

            // Criar a conexão com o banco de dados para verificar se o login e senha da pessoa está correto.

        }



    }
}