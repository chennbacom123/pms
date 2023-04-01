using CRS.Pms.Server.DBContext;
using CRS.Pms.Server.Domain.User.Bussiness;
using CRS.Pms.Server.Domain.User.Mapper;
using CRS.Pms.Server.Domain.User.Repository;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
//builder.Services.AddControllers().AddJsonOptions(option => 
//{
//    option.JsonSerializerOptions.PropertyNameCaseInsensitive = false;
//    option.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
//    option.JsonSerializerOptions.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull;
//    option.JsonSerializerOptions.UnknownTypeHandling = JsonUnknownTypeHandling.JsonElement;
//});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<IDBConfig, DBConfig>(p => new DBConfig 
{
    ConnectionString = builder.Configuration.GetConnectionString(DBMSType.SqlServer.ToString()),
    DBMSType = DBMSType.SqlServer,
    DataBaseName = "pms_db",
});
builder.Services.AddSingleton<IDBContext, DBContext>();

builder.Services.AddScoped<IUserBussiness, UserBussiness>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IUserArgDtoMapper, UserArgDtoMapper>();
builder.Services.AddScoped<IUserDtoEntityMapper, UserDtoEntityMapper>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
