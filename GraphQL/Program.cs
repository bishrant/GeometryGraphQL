using ConferencePlanner.GraphQL.Data;
using GraphQL;
using HotChocolate.Types.Spatial;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<ApplicationDbContext>(options => 
options.UseSqlite("Data Source=conferences.db"));

builder.Services.AddGraphQLServer()
    // .AddSpatialTypes()
    .AddType(new GeometryType("Geometry", BindingBehavior.Implicit))
    .AddQueryType<Query>()
    ;
var app = builder.Build();
app.UseRouting();
app.UseEndpoints(endpoints => endpoints.MapGraphQL());

app.Run();
