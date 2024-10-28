using MySql.Data.MySqlClient;
using ProjetoAula.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ProjetoAula.Repositorios
{


    internal class ClienteRepositorio
    {

        private string conexaoBancoDeDados;

        public ClienteRepositorio(string conexaoBancoDeDados)
        {
            this.conexaoBancoDeDados = conexaoBancoDeDados;
        }




        public Cliente FazerLogin(string emailDigitadoUsuario, string senhaDigitadoUsuario)
        {
            //Verifica se existe um cliente com o email digitado no console
            Cliente clienteLogin = GetCliente(emailDigitadoUsuario);
            //clienteLogin = null;



            if (clienteLogin == null)
            {
                //Se nao encontrar nenhuma cliente, então informa que os dados estão incorretos.
                MessageBox.Show("Email ou senha inválidos.");

            }
            else
            {
                // No ELSE, quer dizer que foi encontrado um cliente,
                //Então o email já está correto, pois foi encontrado um cliente.
                //Nesse caso, só precisamos confirmar se a senha está correta.
                if (clienteLogin.Senha == senhaDigitadoUsuario)
                {
                    MessageBox.Show($"Seja bem-vindo(a) {clienteLogin.Nome.Split(' ')[0]}!! ");
                    return clienteLogin;
                }
                else
                {
                    MessageBox.Show($"Senha incorreto.");
                }
            }


            return null;
        }


        public Cliente GetCliente(string emailCliente)
        {

            using (MySqlConnection conexao = new MySqlConnection(conexaoBancoDeDados))
            {

                conexao.Open();
                MySqlCommand comando =
                    new MySqlCommand("  SELECT * FROM Cliente WHERE Email =  @Email  ", conexao);
                comando.Parameters.AddWithValue("@Email", emailCliente);
                using (MySqlDataReader reader = comando.ExecuteReader())



                    if (reader.Read())
                        return new Cliente
                        {
                            ClienteID = reader.GetInt32("ClienteID"),
                            Nome = reader.GetString("Nome"),
                            Email = reader.GetString("Email"),
                            Senha = reader.GetString("Senha"),
                        };
            }
            return null;
        }



        public void InserirCliente(Cliente cliente)
        {
            using (MySqlConnection conexao = new MySqlConnection(conexaoBancoDeDados))
            {
                conexao.Open();
                MySqlCommand comando =
                    new MySqlCommand("  INSERT INTO Cliente ( nome, email, senha) " +
                                           "  VALUES (  @nome, @email, @senha )  ", conexao);
                comando.Parameters.AddWithValue("@nome", cliente.Nome);
                comando.Parameters.AddWithValue("@email", cliente.Email);
                comando.Parameters.AddWithValue("@senha", cliente.Senha);
                comando.ExecuteNonQuery();
                comando.Dispose();
            }

        }



    }


}
