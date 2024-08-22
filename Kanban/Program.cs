using Context;
using dotenv.net;
using Services;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();

builder.Services.AddSqlite<KanbanContext>("Data Source=kanban.db");

builder.Services.AddSingleton<PasswordUserHasher>();

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



