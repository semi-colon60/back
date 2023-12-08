global using dotnet.DataAccess.Models;
using dotnet.DataAccess.DbContexts;
using dotnet.DataAccess.Interfaces;
using dotnet.DataAccess.Repositories;
using dotnet.Services;
using dotnet.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// Database Connection
builder.Services.AddDbContext<ApplicationContext>(options =>
	options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

//Dependency injection for repositories
builder.Services.AddScoped<IMaterialRepository, MaterialRepository>();
builder.Services.AddScoped<IMainGroupRepository, MainGroupRepository>();
builder.Services.AddScoped<ISubGroupRepository, SubGroupRepository>();
builder.Services.AddScoped<ICommercialIdRepository, CommercialIdRepository>();
builder.Services.AddScoped<IOrderRepository, OrderRepository>();
builder.Services.AddScoped<IOrderDetailRepository, OrderDetailRepository>();

//Dependency injection for services
builder.Services.AddScoped<ILoginService, LoginService>();
builder.Services.AddScoped<IReviewOrderService, ReviewOrderService>();
builder.Services.AddScoped<IUserListMaterialsService, UserListMaterialsService>();

builder.Services.AddScoped<IAddUserService, AddUserService>();

// Add policy for CORS
builder.Services.AddCors(options =>
{
	options.AddPolicy("AllowAll", builder =>
	{
		builder.AllowAnyOrigin()
			.AllowAnyMethod()
			.AllowAnyHeader();
	});
});

// Add policy for CORS
builder.Services.AddCors(options =>
{
	options.AddPolicy("AllowAll", builder =>
	{
		builder.AllowAnyOrigin()
			.AllowAnyMethod()
			.AllowAnyHeader();
	});
});

builder.Services.AddControllers();
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

// app.UseAuthorization();

app.MapControllers();
app.UseCors("AllowAll");

app.UseCors("AllowAll");

app.Run();

// unit test for db connection
// app.MapGet("/testConnection", async (ApplicationContext dbContext) =>
// {
// 	try
// 	{
// 		// Try to open a connection
// 		await dbContext.Database.OpenConnectionAsync();

// 		// If the connection is successful, return a success message
// 		return Results.Ok("Database connection is okay!");
// 	}
// 	catch (Exception ex)
// 	{
// 		// If there's an exception, return an error message
// 		return Results.BadRequest($"Database connection error: {ex.Message}");
// 	}
// 	finally
// 	{
// 		// Always close the connection in the finally block
// 		dbContext.Database.CloseConnection();
// 	}
// })
// .WithName("TestConnection")
// .WithOpenApi();

// // unit test dbContext
// app.MapGet("/testDbContext/{id}", async (ApplicationContext dbContext, int id) =>
// {
// 	if (dbContext.Materials == null)
// 		return Results.BadRequest("Material not found!");

// 	// material 
// 	var material = await dbContext.Materials.FindAsync(id);
// 	if (material == null)
// 		return Results.BadRequest("Material not found!");
// 	Console.WriteLine(material.Name);

// 	// access the main group
// 	var mainGroup = await dbContext.MainGroups.FindAsync(material.MainGroupId);
// 	if (mainGroup != null)
// 	{
// 		Console.WriteLine(material.Name + ", " + mainGroup.Name);
// 		return Results.Ok(material);
// 	}
// 	else
// 		return Results.BadRequest("Main Group not found!");
// })
// .WithName("TestDbContext")
// .WithOpenApi();

// app.MapGet("/testMaterialRepository/{id}", async (IMaterialRepository materialRepository, IMainGroupRepository mainGroupRepository, int id) =>
// {
// 	var material = await materialRepository.GetByIdAsync(id);

// 	if (material == null)
// 		return Results.BadRequest("material not found!");

// 	Console.WriteLine(material.Name);

// 	// Access the MainGroup
// 	var mainGroup = await mainGroupRepository.GetByIdAsync(material.MainGroupId);

// 	if (mainGroup != null)
// 	{
// 		Console.WriteLine(material.Name + ", " + mainGroup.Name);
// 		return Results.Ok(material);
// 	}
// 	else
// 		return Results.BadRequest("Main Group not found!");
// })
// .WithName("TestMaterialRepository")
// .WithOpenApi();

// app.MapPost("/addCommercialId", async (CommercialId commercialId, ICommercialIdRepository commercialIdRepository) =>
// {
// 	// Validate the input
// 	if (commercialId == null || string.IsNullOrWhiteSpace(commercialId.Name))
// 	{
// 		return Results.BadRequest("Invalid input data");
// 	}

// 	// Add the new CommercialId to the repository
// 	await commercialIdRepository.AddAsync(commercialId);

// 	return Results.Created($"/commercialIds/{commercialId.CommercialID}", commercialId);
// })
// .WithName("AddCommercialId")
// .WithOpenApi();
