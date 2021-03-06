using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using Moghadara.Bll.ServiceAbstractions;
using Moghadara.Bll.Services;
using Moghadara.Dal.Repositories;
using Moghadara.Dal.RepositoryAbstractions;
using Moghadarate.Domain.Models;

namespace MoghadaraApi
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
            services.AddTransient<IServices<Fonctionnaire>, FonctionnaireService>();
            services.AddTransient<IRepository<Fonctionnaire>, FonctionnaireRepo>();
            services.AddTransient<IServices<Demande>, DemandeService>();
            services.AddTransient<IRepository<Demande>, DemandeRepo>();

            services.AddDbContext<MoghadaraateContext>(o =>
            {
                o.UseSqlServer("Server=localhost;Database=Moghadaraate;Trusted_Connection=True;");
            });
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "MoghadaraApi", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "MoghadaraApi v1"));
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
