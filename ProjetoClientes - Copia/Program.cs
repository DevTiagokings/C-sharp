using System.Data.SqlClient;

namespace ProjetoClientes;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        try{
                //executar
                SqlConnectionStringBuilder builder=new SqlConnectionStringBuilder(
                    "User id=sa;Password=Gomes0906;"+
                    "Database=projetoclientes;"+
                    "Sever=localhost\\SQLEXPRESS;" +
                    "Trusted_Connection=False;"
                );

                using(SqlConnection conexao = new SqlConnection(builder.ConnectionString) ){

                    string sql = " Select * from clientes " ;

                    using(SqlCommand comando = new SqlCommand (sql, conexao)) {
                         
                         conexao.Open();

                         using(SqlDataReader leitor = comando.ExecuteReader() ) {

                            while(leitor.Read()){

                                System.Console.WriteLine("id: {0}", leitor["id"]);

                            }
                         }
                    }

                }


        }catch(Exception e) 
        {
                //exception
                System.Console.WriteLine("Erro:" + e.ToString());

        }
    }
}
