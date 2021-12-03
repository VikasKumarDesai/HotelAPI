using System.Globalization;

var builder = WebApplication.CreateBuilder(args);
//var cultureInfo = new CultureInfo("en-US");

//var formatInfo = new NumberFormatInfo
//{
//    NumberDecimalSeparator = ".",
//    NumberDecimalDigits = 2
//};
//cultureInfo.NumberFormat.NumberDecimalSeparator = ".";
//cultureInfo.NumberFormat.NumberDecimalDigits = 2;
//cultureInfo.NumberFormat.CurrencySymbol = "£";
//CultureInfo.DefaultThreadCurrentCulture = cultureInfo;
//CultureInfo.DefaultThreadCurrentUICulture = cultureInfo;

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(
        builder =>
        {
            builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
        });
});

// Add services to the container.

builder.Services.AddControllers();
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

app.UseCors();

app.UseAuthorization();

app.MapControllers();

app.Run();
