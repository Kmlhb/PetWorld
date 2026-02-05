using PetWorld.Domain.Interfaces;
using PetWorld.Infrastructure.Repositories;
using PetWorld.Application.UseCases;
using PetWorld.Web.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

builder.Services.AddScoped<IChatRepo, MySqlChatRepository>();
builder.Services.AddScoped<IProductRepo, MySqlProductRepository>();
builder.Services.AddScoped<HandleClientQuestionUseCase>();
builder.Services.AddScoped<ClientChatService>();

var app = builder.Build();

app.UseStaticFiles();
app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();