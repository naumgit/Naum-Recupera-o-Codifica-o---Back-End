using LH_Pets;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Projeto WEB LH Pets - Versão 1.0 ");
Banco banco = new Banco();
app.MapGet("/listaClientes", (HttpContext context) => {
    context.Response.WriteAsync(banco.GetListaString());
});

app.UseStaticFiles();

app.Run();
