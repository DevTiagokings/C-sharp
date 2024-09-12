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
                    "Database=projetoclientes;"

                );


        }catch(Exception e) 
        {
                //exception
                System.Console.WriteLine("Erro:" + e.ToString());

        }
    }
}
