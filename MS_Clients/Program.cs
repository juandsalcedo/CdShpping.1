using Microsoft.EntityFrameworkCore;
// --- ARREGLO 1: Corregimos la ruta al Mapper del Adaptador ---
using MS_Clients.Adapter.Restul.v1.Mapper; 
using MS_Clients.Application.Service;
using MS_Clients.Domain;
using MS_Clients.Infraestructure;
using MS_Clients.Infraestructure.Mapper;
using MS_Clients.Application; // Para que encuentre IClientRepository

var builder = WebApplication.CreateBuilder(args);

// Configuración de la Base de Datos
builder.Services.AddDbContext<ClientDbContext>(options =>
    options.UseMySql(
        builder.Configuration.GetConnectionString("DefaultConnection"),
        new MySqlServerVersion(new Version(8, 0, 39)) 
    )
);



// Conexiones de Infraestructura
builder.Services.AddScoped<IClientRepository, Repository>();

builder.Services.AddScoped<IInfraestructureMapper, InfraestructureMapperImp>();

// Conexiones del Adaptador
builder.Services.AddScoped<IAdapterMapper, AdapterMapperImp>();

// Conexión del Servicio
builder.Services.AddScoped<IClientService, ClientServiceImp>();


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
