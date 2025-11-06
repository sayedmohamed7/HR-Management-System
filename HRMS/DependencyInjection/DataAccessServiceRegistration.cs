using HRMS.Data;
using HRMS.Interfaces;
using HRMS.Interfaces.Services;
using HRMS.Models;
using HRMS.Repositories;
using HRMS.Services.Impelmentation;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace HRMS.DependencyInjection;

public static class DataAccessServiceRegistration
{
    public static IServiceCollection AddDataAccessServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("CS")));

        services.AddIdentity<ApplicationUser, IdentityRole>(options =>
        {
            options.Password.RequireDigit = true;
            options.Password.RequiredLength = 8;
            options.Password.RequireNonAlphanumeric = true;
            options.Password.RequireUppercase = true;
            options.Password.RequireLowercase = true;
            options.User.RequireUniqueEmail = true;
        })
        .AddEntityFrameworkStores<ApplicationDbContext>()
        .AddDefaultTokenProviders();

        // -----------------------------
        // 🔹 Repositories
        // -----------------------------
        services.AddScoped<IUnitOfWork, UnitOfWork>();
        services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
        services.AddScoped<IApplicationUserRepository, ApplicationUserRepository>();
        services.AddScoped<IAttendanceRecordRepository, AttendanceRecordRepository>();
        services.AddScoped<IDepartmentRepository, DepartmentRepository>();
        services.AddScoped<IEmployeeDocumentRepository, EmployeeDocumentRepository>();
        services.AddScoped<IEmployeeRepository, EmployeeRepository>();
        services.AddScoped<IJobTitleRepository, JobTitleRepository>();
        services.AddScoped<ILeaveRequestRepository, LeaveRequestRepository>();
        services.AddScoped<ILeaveTypeRepository, LeaveTypeRepository>();
        services.AddScoped<IPayslipDetailRepository, PayslipDetailRepository>();
        services.AddScoped<IPayslipRepository, PayslipRepository>();
        services.AddScoped<ISalaryComponentRepository, SalaryComponentRepository>();

        // -----------------------------
        // 🔹 Services
        // -----------------------------
        services.AddScoped<IAttendanceRecordServices, AttendanceRecordServices>();
        services.AddScoped<IDepartmentServices, DepartmentServices>();
        services.AddScoped<IEmployeeDocumentServices, EmployeeDocumentServices>();
        services.AddScoped<IEmployeeServices, EmployeeServices>();
        services.AddScoped<IJobTitleServices, JobTitleServices>();
        services.AddScoped<ILeaveRequestServices, LeaveRequestServices>();
        services.AddScoped<ILeaveTypeServices, LeaveTypeServices>();
        services.AddScoped<IPayslipDetailServices, PayslipDetailServices>();
        services.AddScoped<IPayslipServices, PayslipServices>();
        services.AddScoped<ISalaryComponentServices, SalaryComponentServices>();

        return services;
    }
}
