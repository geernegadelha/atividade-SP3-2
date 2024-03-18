namespace Projeto_Web_Lh_Pets_Alunos;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        var app = builder.Build();

        app.MapGet("/", () => "Projeto Web - LH pets versão 1");

        app.UseStaticFiles();
        app.MapGet("/index", (HttpContext contexto) =>
        {
            contexto.Response.Redirect("index.html", false);
        });

private List<Clientes> lista=new List<Clientes>();
public List<Clientes> GetLista()
{
return lista;
} 


        app.Run();
    }
}
