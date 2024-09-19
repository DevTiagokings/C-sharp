using System.Data.Common;

namespace ProjetoLista;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        ClientesPF cl1= new ClientesPF();
         cl1.id=1;
         cl1.nome="Ana";

         ClientesPF cl2= new ClientesPF();
         cl2.id=2;
         cl2.nome="Bruno";

         List<ClientesPF> lista=new List<ClientesPF>();

         lista.Add( new ClientesPF());

         lista.Add(cl1);

         lista.Add(new ClientesPF() {id=2 , nome="carlos"} ); 

         foreach( ClientesPF aux in lista)
         {
            System.Console.WriteLine("Cliente: {0}", aux.nome);
         }

    }
}
