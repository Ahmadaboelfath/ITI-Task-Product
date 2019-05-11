using ITI.Product.Task.BackendApi.Core;
using ITI.Product.Task.BackendApi.Models;
using ITI.Product.Task.BackendApi.Persistence;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Swashbuckle.AspNetCore.Swagger;
using System;
using System.IO;
using System.Reflection;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.OpenApi.Models;

namespace ITI.Product.Task.BackendApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        readonly string MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc(setupAction =>
            {
                setupAction.OutputFormatters.Add(new XmlDataContractSerializerOutputFormatter());
                setupAction.InputFormatters.Add(new XmlDataContractSerializerInputFormatter());
            }).SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            services.AddDbContext<ProductDbContext>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            // Adding CORS service to allow connection between front-end and API
            services.AddCors(options => options.AddPolicy(MyAllowSpecificOrigins,
                builder =>
                {
                    builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();

                }));

            

            // Register the Swagger generator, defining 1 or more Swagger documents
            services.AddSwaggerGen(setupAction =>
            {
                setupAction.SwaggerDoc(
                    "ProductOpenApiSpecification",
                    new OpenApiInfo()
                    {
                        Title = "Product API",
                        Version = "1"
                    });
            });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env,
            ILoggerFactory loggerFactory, ProductDbContext productDbContext)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler(appbuilder =>
                {
                    appbuilder.Run(async context =>
                    {
                        context.Response.StatusCode = 500;
                        await context.Response.WriteAsync("An unexpected fault happened. Try again later");
                    });
                });
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            //Configuring the automapper
            AutoMapper.Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<ProductUpdateDto, Core.Domain.Product>();
            });

            app.UseHttpsRedirection();


            app.UseCors(options => options.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());

            //Enable the middleware to serve generated swagger as a JSON Endpoint
            app.UseSwagger();

            //Adding Swagger Ui
            app.UseSwaggerUI(setupAction =>
            {
                setupAction.SwaggerEndpoint("/swagger/ProductOpenApiSpecification/swagger.json", "Product API");
                setupAction.RoutePrefix = string.Empty;
            });

            app.UseMvc();

            productDbContext.EnsureSeedDataForContext();

          

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.), 
            // specifying the Swagger JSON endpoint.

            //app.UseSwaggerUI(c =>
            //{
            //    c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            //    c.RoutePrefix = string.Empty;
            //});

        }
    }
}
