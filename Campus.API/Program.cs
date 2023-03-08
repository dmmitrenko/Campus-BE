using Campus.API.Extensions;
using Campus.Subject.DataContext;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCampusMvc();
builder.Services.ConfigureValidation();
builder.Services.ConfigureSwagger();
builder.Services.ConfigureApplicationService();

builder.Services.AddDataContext(builder.Configuration);
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddEndpointsApiExplorer();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
