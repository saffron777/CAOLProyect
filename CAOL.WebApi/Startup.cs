using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using CAOL.Core.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using MySql.Data.EntityFrameworkCore.Extensions;
using MySql.Data.EntityFrameworkCore.Infraestructure;
using Swashbuckle.AspNetCore.Swagger;
using CAOL.Core.Repository.Contracts;
using CAOL.Core.Repository.Repositories;
using CAOL.Core.Modules.Desempenho.Interface;
using CAOL.Core.Modules.Desempenho.Implementations;

namespace CAOL.WebApi
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
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            var connection = Configuration.GetConnectionString("caolContext");
            services.AddDbContext<CaolContext>
               (options => options.UseMySQL(connection));
            services.AddEntityFrameworkMySQL();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();


            services.AddScoped<DbContext, CaolContext>();
            services.AddScoped<ICao_clienteRepository, Cao_clienteRepository>();
            services.AddScoped<ICao_faturaRepository, Cao_faturaRepository>();
            services.AddScoped<ICao_osRepository, Cao_osRepository>();
            services.AddScoped<ICao_salarioRepository, Cao_salarioRepository>();
            services.AddScoped<ICao_sistemaRepository, Cao_sistemaRepository>();
            services.AddScoped<ICao_usuarioRepository, Cao_usuarioRepository>();
            services.AddScoped<IPermissao_sistemaRepository, Permissao_sistemaRepository>();
            services.AddScoped<IDesempenhoService, DesempenhoService>();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info { Title = "CAOL WebAPI", Version = "v1" });
            });

            services.Configure<MvcOptions>(options =>
            {
                //mvc options
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();

            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/CAOL.WebApi/swagger/v1/swagger.json", "CAOL WebAPI");
            });
        }
    }
}
