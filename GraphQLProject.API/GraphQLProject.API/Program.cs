using GraphiQl;
using GraphQL;
using GraphQL.Types;
using GraphQLProject.API.Interfaces;
using GraphQLProject.API.Mutation;
using GraphQLProject.API.Query;
using GraphQLProject.API.Schema;
using GraphQLProject.API.Services;
using GraphQLProject.API.Type;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddTransient<IMenuRepository, MenuRepository>();
builder.Services.AddTransient<MenuType>();
builder.Services.AddTransient<MenuQuery>();    
builder.Services.AddTransient<ISchema, MenuSchema>();

builder.Services.AddGraphQL(b=>b.AddAutoSchema<ISchema>().AddSystemTextJson());

builder.Services.AddTransient<MenuMutation>();
builder.Services.AddTransient<MenuInputType>();
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
app.UseGraphiQl("/graphql");
app.UseGraphQL<ISchema>();

app.UseAuthorization();

app.MapControllers();

app.Run();
