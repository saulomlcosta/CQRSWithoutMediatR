using CQRSWithoutMediatR.Endpoints;
using CQRSWithoutMediatR.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSingleton<InMemoryStudentRepository>();

var app = builder.Build();

app.UseHttpsRedirection();

app.AddStudentEndpoints();

app.Run();
