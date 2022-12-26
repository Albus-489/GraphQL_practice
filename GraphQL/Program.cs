//using System.Reflection;
//using GQLPractice.GraphQL;
//using GQLPractice.GraphQL.Data;
//using Microsoft.EntityFrameworkCore;
//using HotChocolate;


//var builder = WebApplication.CreateBuilder(args);

////builder.Services.AddCors(op => op.AddDefaultPolicy(builder => builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader()));

//var migrationsAssembly = typeof(Program).GetTypeInfo().Assembly.GetName().Name;

//builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlite("Data Source=graphql_practice.db"));

//builder.Services.AddControllers();

//builder.Services
//    .AddGraphQLServer()
//    .AddQueryType<Query>()
//    .AddMutationType<Mutation>();

//var app = builder.Build();

//app.UseRouting();

////app.MapGraphQL("/graphql");

//app.UseEndpoints(endpoints =>
//{
//    endpoints.MapControllers();

//});

//app.Run();
using GraphQL;
using GQLPractice.GraphQL.Data;
using Microsoft.EntityFrameworkCore;
using GQLPractice.GraphQL;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlite("Data Source=graphql_practice.db"));

builder.Services
    .AddGraphQLServer()
    .AddQueryType<Query>()
    .AddMutationType<Mutation>();

var app = builder.Build();

app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.MapGraphQL();
});

app.Run();