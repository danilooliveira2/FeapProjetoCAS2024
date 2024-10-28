using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAula.Repositorios
{
    internal class Conexao
    {
        //Criando aqui uma string de conexão para a base de dados
        //Criando de forma estática, porém, por segurança não é recomendável!!!
        public static string stringConexao =
            "Server=projetoprodutos.mysql.uhserver.com;Database=projetoprodutos;Uid=alunosfeap;Pwd={Fe@p2024};";
        //"Server=myServerAddress;Database=myDataBase;Uid=myUsername;Pwd=myPassword;";
    }
}
