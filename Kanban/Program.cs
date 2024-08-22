using Context;
using dotenv.net;
using Services.Teams;
using Services.Users;
using Services.Utils;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();

builder.Services.AddSqlite<KanbanContext>("Data Source=kanban.db");

builder.Services.AddSingleton<PasswordUserHasher>();
builder.Services.AddScoped<TeamService>();
builder.Services.AddScoped<UserService>();

if(builder.Environment.IsDevelopment())
{
    DotEnv.Load();
}

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseStaticFiles();
app.UseRouting();
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();



