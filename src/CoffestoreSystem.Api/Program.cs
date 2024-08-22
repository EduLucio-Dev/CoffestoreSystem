using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.CustomSchemaIds(type => type.FullName);
});

builder.Services.AddTransient<Handler>();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.MapPost(
    pattern:"/v1/products",
    handler:(Request request,Handler handler) 
    => handler.handle(request))
        .WithName("Transaction Create")
    .WithSummary("Cria uma nova transação")
    .Produces<Response>();
app.Run();


//Request > referente a requisições pela api
public class Request() {
    public string Title { get; set; } = string.Empty;
    public double Price { get; set; }
    public int Type { get; set; }

}

//Response
public class Response()
{
    public int Id { get; set; }
    public string Title { get; set; }
}
//Handler
public class Handler
{
    public Response handle(Request request)
    {
        return new Response
        {
            Id = 1,
            Title = request.Title,
        };
    }
}