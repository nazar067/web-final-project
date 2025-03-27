using Hotels.Models;
using Hotels.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SoapCore;
using CoreWCF;
using CoreWCF.Configuration;
using CoreWCF.Description;

namespace Hotels
{
    public class Startup
    {
        public IConfiguration Configuration { get; set; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {

            services.AddServiceModelServices()
                    .AddServiceModelMetadata();  // Добавляет CoreWCF
            services.AddSoapCore();
            services.AddSingleton<IHotelService, HotelService>();

            services.AddDbContext<HotelsContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddDbContext<IdentityContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("IdentityConnection")));
            services.AddIdentity<User, IdentityRole>()
                .AddEntityFrameworkStores<IdentityContext>()
                .AddDefaultTokenProviders();
            services.AddControllers();
            services.AddMvc();
            services.AddSession();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseServiceModel(serviceBuilder =>
            {
                serviceBuilder.AddService<HotelService>();
                serviceBuilder.AddServiceEndpoint<HotelService, IHotelService>(
                    new BasicHttpBinding(), "/HotelService.svc");


                var metadata = new ServiceMetadataBehavior { HttpGetEnabled = true };
                serviceBuilder.ConfigureServiceHostBase<HotelService>(host => host.Description.Behaviors.Add(metadata));
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        


            

        // Настройка SOAP-сервиса
        app.UseSoapEndpoint<IHotelService>("/HotelService.svc",
                new SoapEncoderOptions(),
                SoapSerializer.DataContractSerializer);
        }


    }
}
