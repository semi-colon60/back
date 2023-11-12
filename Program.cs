using dotnet.DataAccess.DbContexts;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// Database Connection
builder.Services.AddDbContext<ApplicationContext>(options => 
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// unit test for db connection
app.MapGet("/testConnection", async (ApplicationContext dbContext) =>
{
    try
    {
        // Try to open a connection
        await dbContext.Database.OpenConnectionAsync();

        // If the connection is successful, return a success message
        return Results.Ok("Database connection is okay!");
    }
    catch (Exception ex)
    {
        // If there's an exception, return an error message
        return Results.BadRequest($"Database connection error: {ex.Message}");
    }
    finally
    {
        // Always close the connection in the finally block
        dbContext.Database.CloseConnection();
    }
})
.WithName("TestConnection")
.WithOpenApi();

// unit test dbContext
app.MapGet("/testDbContext/{id}", async (ApplicationContext dbContext, int id) =>
{
    if (dbContext.Materials == null)
        return Results.BadRequest("Material not found!");

    // material 
    var material = await dbContext.Materials.FindAsync(id);
    if (material == null)
        return Results.BadRequest("Material not found!");
    Console.WriteLine(material.Name);

    // access the main group
    var mainGroup = await dbContext.MainGroups.FindAsync(material.MainGroupId);
    if (mainGroup != null)
    {
        Console.WriteLine(material.Name + ", " + mainGroup.Name);
        return Results.Ok(material);
    }
    else
        return Results.BadRequest("Main Group not found!");
})
.WithName("TestDbContext")
.WithOpenApi();

app.Run();