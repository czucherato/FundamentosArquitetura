using System;
using DemoDI.Cases;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace DemoDI
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            #region Lifecycle

            services.AddTransient<IOperacaoTransient, Operacao>();
            services.AddScoped<IOperacaoScoped, Operacao>();
            services.AddSingleton<IOperacaoSingleton, Operacao>();
            services.AddSingleton<IOperacaoSingletonInstance>(new Operacao(Guid.Empty));
            services.AddTransient<OperacaoService>();

            #endregion

            #region VidaReal

            services.AddScoped<IClienteService, ClienteService>();
            services.AddScoped<IClienteRepository, ClienteRepository>();

            #endregion

            #region Generics

            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

            #endregion

            #region MultiplasClasses

            services.AddTransient<ServiceA>();
            services.AddTransient<ServiceB>();
            services.AddTransient<ServiceC>();
            services.AddTransient<Func<string, IService>>(serviceProvider => key =>
            {
                switch (key)
                {
                    case "A":
                        return serviceProvider.GetService<ServiceA>();
                    case "B":
                        return serviceProvider.GetService<ServiceB>();
                    case "C":
                        return serviceProvider.GetService<ServiceC>();
                    default:
                        return null;
                }
            });

            #endregion
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World!");
            });
        }
    }
}
