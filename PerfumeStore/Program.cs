using MediatR;
using PerfumeStore.Dal;
using PerfumeStore.Dal.Repositories;
using PerfumeStore.Domain.IRepositories;
using PerfumeStore.Middleware;
using PerfumeStore.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IScopedService, ScopedService>();
builder.Services.AddTransient<ITransientService, TransientService>();
builder.Services.AddSingleton<ISingletonService, SingletonService>();

builder.Services.AddScoped<IAddressRepository, AddressRepository>();
builder.Services.AddScoped<ICartRepository, CartRepository>();
builder.Services.AddScoped<IEntryRepository, EntryRepository>();
builder.Services.AddScoped<IOptionTypeRepository, OptionTypeRepository>();
builder.Services.AddScoped<IOptionValueRepository, OptionValueRepository>();
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IVariantRepository, VariantRepository>();

builder.Services.AddMediatR(typeof(Program));
builder.Services.AddAutoMapper(typeof(Program));

builder.Services.AddDbContext<PerfumeStoreContext>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseMyMiddleware();

app.MapControllers();

app.Run();
