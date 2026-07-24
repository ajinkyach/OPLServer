using Microsoft.Extensions.Options;

namespace OPLServer.IoC
{
    public class IoC
    {
        public static void Configure(IServiceCollection services)
        {
            try
            {
                //services.AddScoped<IAccountingService, AccountingService>();
                //services.AddScoped<IFinancialService, FinancialService>();
                //services.AddScoped<IAlertService, AlertService>();
                //services.AddScoped<IAuthService, AuthService>();
                //services.AddScoped<IBondService, BondService>();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
