var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())


app.UseStaticFiles();
app.UseRouting();
app.UseHttpsRedirection();
app.MapControllers();

app.Run();

