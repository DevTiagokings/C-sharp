namespace ProjetoWeb;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        var app = builder.Build();

        app.MapGet("/", () => "Hello World!");

        app.MapGet("/cliente" , () => "Clientes !!!!!");

        app.MapGet("/produtos", () => "Produtos !!!!!");

        app.UseStaticFiles();

        app.MapGet("/clientes" , (string nome) => $"O nome do cliente escolhido é : {nome} " );


        app.Run();
    }
}
