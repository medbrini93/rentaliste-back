
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using rentaliste_api.Models;
using rentaliste_api.Repository;
using rentaliste_api.Repository.Interfaces;
using rentaliste_api.Repository.UnitOfWork;
using rentaliste_api.Repository.UnitOfWork.Interface;
using rentaliste_api.Services;
using rentaliste_api.Services.Interfaces;

namespace rentaliste_api;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddAutoMapper(typeof(Program));
        builder.Services.AddControllers();
        builder.Services.AddDbContext<ApplicationContext>(options =>
        options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection"),
        b => b.MigrationsAssembly(typeof(ApplicationContext).Assembly.FullName)));
        builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();


        #region Repositories
        builder.Services.AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>));
        builder.Services.AddTransient<ICommunicationRepository, CommunicationRepository>();
        builder.Services.AddTransient<ICommunicationTypeRepository, CommunicationTypeRepository>();
        builder.Services.AddTransient<IDocumentRepository, DocumentRepository>();
        builder.Services.AddTransient<IDocumentTypeRepository, DocumentTypeRepository>();
        builder.Services.AddTransient<ILeaseRepository, LeaseRepository>();
        builder.Services.AddTransient<IMaintenanceRequestRepository, MaintenanceRequestRepository>();
        builder.Services.AddTransient<IMaintenanceTypeRepository, MaintenanceTypeRepository>();
        builder.Services.AddTransient<IOwnerRepository, OwnerRepository>();
        builder.Services.AddTransient<IPositionRepository, PositionRepository>();
        builder.Services.AddTransient<IPrivilegeRepository, PrivilegeRepository>();
        builder.Services.AddTransient<IPropertyRepository, PropertyRepository>();
        builder.Services.AddTransient<IPropertyTypeRepository, PropertyTypeRepository>();
        builder.Services.AddTransient<IStaffRepository, StaffRepository>();
        builder.Services.AddTransient<ITenantRepository, TenantRepository>();
        builder.Services.AddTransient<ITransactionRepository, TransactionRepository>();
        builder.Services.AddTransient<ITransactionTypeRepository, TransactionTypeRepository>();
        #endregion

        #region Services
        builder.Services.AddScoped<ICommunicationService, CommunicationService>();
        builder.Services.AddScoped<ICommunicationTypeService, CommunicationTypeService>();
        builder.Services.AddScoped<IDocumentService, DocumentService>();
        builder.Services.AddScoped<IDocumentTypeService, DocumentTypeService>();
        builder.Services.AddScoped<ILeaseService, LeaseService>();
        builder.Services.AddScoped<IMaintenanceRequestService, MaintenanceRequestService>();
        builder.Services.AddScoped<IMaintenanceTypeService, MaintenanceTypeService>();
        builder.Services.AddScoped<IOwnerService, OwnerService>();
        builder.Services.AddScoped<IPositionService, PositionService>();
        builder.Services.AddScoped<IPrivilegeService, PrivilegeService>();
        builder.Services.AddScoped<IPropertyService, PropertyService>();
        builder.Services.AddScoped<IPropertyTypeService, PropertyTypeService>();
        builder.Services.AddScoped<IStaffService, StaffService>();
        builder.Services.AddScoped<ITenantService, TenantService>();
        builder.Services.AddScoped<ITransactionService, TransactionService>();
        builder.Services.AddScoped<ITransactionTypeService, TransactionTypeService>();
        #endregion


        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        //Version manager
        builder.Services.AddApiVersioning(x =>
        {
            x.DefaultApiVersion = new ApiVersion(1, 0);
            x.AssumeDefaultVersionWhenUnspecified = true;
            x.ReportApiVersions = true;
        });

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
    }
}

