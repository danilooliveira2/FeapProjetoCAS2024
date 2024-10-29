using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAula.Modelos
{


    //Alterar a classe para PUBLIC
    public class Cliente
    {

        //Sobrecarga do método construtor do cliente
        public Cliente(string nomeNovo, string emailNovo, string v)
        {
            Nome = nomeNovo;
            Email = emailNovo;
        }

        //Sobrecarga do método construtor do cliente
        public Cliente()
        {

        }

        public Cliente(string nomeNovo, string emailNovo, string v, int v1) : this(nomeNovo, emailNovo, v)
        {
        }



        //Atributos da Classe Cliente
        public int ClienteID { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public BigInteger CPF { get; set; }


        //Comportamentos -> Ações / Funções / Métodos
        public void ExibirDetalhes()
        {
            Console.WriteLine($"ID:{ClienteID} Nome:{Nome} \nEmail: {Email}");
        }



        public void mostrarNome()
        {
            Console.WriteLine(Nome);
        }


        public static bool ValidarNome(string textoNome)
        {
            //Static - Varáveis ou funções fixas, que não mudam
            //seus dados de acordo com a instancia

            //Verificar se foi digitado alguma coisa
            //Verificar se o nome tem mais de 3 caracteres
            //Verificar se o nome tem no máximo 70 caracteres
            //Verificar se o nome tem sobrenome
            if (String.IsNullOrEmpty(textoNome))
            {
                Console.WriteLine("O nome não pode ser vazio.");
                return false;
            }
            else if (textoNome.Length <= 3)
            {
                Console.WriteLine("O nome não pode ser menor que 3 caracteres.");
                return false;
            }
            else if (textoNome.Length > 70)
            {
                Console.WriteLine("O nome não pode ser maior que 70 caracteres.");
                return false;
            }
            else if (!textoNome.Contains(" "))
            {
                Console.WriteLine("Digite o nome completo.");
                return false;
            }
            //continua

            //No final, retorna true??? Depende da sua lógica
            return true;
        }

    }


}
