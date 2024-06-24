using Demo_SP;
using DemoDP_Repository;
using DemoDP_Repository.IRepository;
using DemoSP_DataService;
using DemoSP_DataService.Interface;
using DemoSP_DbContext;
using DemoSP_DbContext.Interface;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAutoMapper(typeof(AutoMapperProfile));

builder.Services.AddTransient<IEmpDataService, EmpDataService>();
builder.Services.AddTransient<IEmpRepository, EmpRepository>();
builder.Services.AddTransient<IDapperRepository, DapperRepository>();
builder.Services.AddTransient<IDBContext, DBContext>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(options => options
    .SetIsOriginAllowed(origin=>true)
    .AllowAnyMethod()
    .AllowAnyHeader()
    .AllowCredentials());

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
