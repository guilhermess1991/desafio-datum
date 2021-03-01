using Datum.Desafio.Domain.Services;
using Datum.Desafio.Infra.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.IO;
using System.Net.Http;
using System.Reflection;

namespace Datum.Desafio.Api_2
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
          
            services.AddScoped<ITaxaJurosService, TaxaJurosService>();
            services.AddScoped<IGithubService, GithubService>();

            services.AddTransient<HttpClient, HttpClient>();

            services.AddControllers();
            
            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
                {
                    Title = "WebAPI - Calcula Juros",
                    Description = "Projeto desenvolvido como desafio para seleção de pessoa Desenvolvedora .Net Core",
                    Contact = new Microsoft.OpenApi.Models.OpenApiContact
                    {
                        Name = "Guilherme Santos Souza",
                        Email = "guilhermesouza_ads@outlook.com",
                        Url = new Uri("https://www.linkedin.com/in/guilhermesouza-ads/")
                    },

                });
                
                var fileName = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var filePath = Path.Combine(AppContext.BaseDirectory, fileName);
                options.IncludeXmlComments(filePath);

            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {            
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Desafio Datum");
            });

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {                
                endpoints.MapControllers();
            });
        }
    }
}
