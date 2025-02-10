using MudBlazor.Services;
using FinanceMan.Web.Components;
using FinanceMan.Database;
using FinanceMan.Database.Repositories;
using FinanceMan.Domain.Contracts;
using FinanceMan.Shared.Contracts;
using FinanceMan.Web.Services;
using FinanceMan.Shared.Dtos;

var builder = WebApplication.CreateBuilder(args);

// Add MudBlazor services
builder.Services.AddMudServices();
builder.Services.AddDbContext<ApplicationDbContext>();
builder.Services.AddScoped<ITransactionRepository, TransactionRepository>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IUserService, UserService>();

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveWebAssemblyComponents();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseAntiforgery();
app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveWebAssemblyRenderMode()
    .AddAdditionalAssemblies(typeof(FinanceMan.Web.Client._Imports).Assembly);


app.MapPost("/api/register", async (IUserService userService, CreateUserDto userDto) =>
{
    var result = await userService.CreateUser(userDto);
    if (result.IsSuccess)
        return Results.Ok();
    return Results.BadRequest();
});
app.Run();
