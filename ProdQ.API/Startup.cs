using Microsoft.AspNetCore.Builder;
using Microsoft.Identity.Web;
using Microsoft.OpenApi.Models;
using Microsoft.AspNetCore.Mvc;
using Asp.Versioning;
using Microsoft.Extensions.Options;
using Asp.Versioning.ApiExplorer;
using MediatR;
//using Microsoft.AspNetCore.Mvc.Versioning;
namespace ProdQ.API
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)         
        {
            Configuration = configuration;
        }

        // Adding Services
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddEndpointsApiExplorer();
            
            //services.AddSwaggerGen();            
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Product-Quotation Ver 1.0", Version = "v1" });
                c.SwaggerDoc("v2", new OpenApiInfo { Title = "Product-Quotation Ver 2.0", Version = "v2" });
            });

            //Adding References from Infrastructure
            services.Scan(s => s
                .FromAssemblies(ProdQ.Infrastructure.AssemblyReference.Assembly)
                .AddClasses(false)
                .AsImplementedInterfaces()
                .WithScopedLifetime()
            );

            //MediaTR setting from ProdQ Application project.
            services.AddMediatR(ProdQ.Applicaton.AssemblyReference.Assembly);//

            //AutoMapper setting from ProdQ Application project.
            services.AddAutoMapper(ProdQ.Applicaton.AssemblyReference.Assembly);

            services.AddMicrosoftIdentityWebApiAuthentication(Configuration); //authorization

            services.AddApiVersioning(options =>
            {
                // In case the param did not put what version, it will always assume that it's using a default version
                options.AssumeDefaultVersionWhenUnspecified = true;

                // Default version settings
                options.DefaultApiVersion = new ApiVersion(1, 0); // default version
                //options.DefaultApiVersion = ApiVersion.Default; // or this default version

                // Setting report versions
                options.ReportApiVersions = true;

                // Tell API version to read if the version is specified within URL, header, parameters
                options.ApiVersionReader = ApiVersionReader.Combine(
                    new QueryStringApiVersionReader(parameterName: "api-version"), // Read like "api/?api-version=1/getUser"
                    new HeaderApiVersionReader(headerName: "api-version"), // Read like "api/getUser", header: Name: api-version, Value: 1
                    new UrlSegmentApiVersionReader() // Will read within the URL like "api/v1/getUser"
                );
            }).AddApiExplorer(ApiExplorerOptions =>
            {                
                ApiExplorerOptions.GroupNameFormat = "'v'V";
                ApiExplorerOptions.SubstituteApiVersionInUrl = true;                
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {            
            app.UseHttpsRedirection();                        
            app.UseStaticFiles();
            app.UseRouting();         

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            // Enable Swagger middleware to serve generated Swagger as JSON endpoints
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "ProdQ API V1");
                c.SwaggerEndpoint("/swagger/v2/swagger.json", "ProdQ API V2");
            });            
        }
    }
}
