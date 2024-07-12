using Microsoft.AspNetCore.Builder;
using Microsoft.Identity.Web;
using Microsoft.OpenApi.Models;
using Microsoft.AspNetCore.Mvc;
using Asp.Versioning;
using Microsoft.Extensions.Options;
using Asp.Versioning.ApiExplorer;
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

            services.Scan(s => s
                .FromAssemblies(ProdQ.Infrastructure.AssemblyReference.assembly)
            );
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

            //services.AddApiExplorer(options =>
            //{
            //    options.GroupNameFormat = "'v'V";
            //    options.SubstituteApiVersionInUrl = true;
            //});

            // Add and configure API Explorer for versioning
            //services.AddEndpointsApiExplorer(options =>
            //{
            //    options.GroupNameFormat = "'v'V";
            //    options.SubstituteApiVersionInUrl = true;
            //});


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if(env.IsDevelopment())
            {
                //app.UseSwagger();
                //app.UseSwaggerUI();
            }
            else
            {
                
            }            

            app.UseHttpsRedirection();                        
            app.UseStaticFiles();
            app.UseRouting();

            //app.UseAuthentication();
            //app.Use(async (context, next) =>
            //{
            //    if (!context.User.Identity?.IsAuthenticated ?? false) //nullable and set default as false.
            //    {
            //        context.Response.StatusCode = 401;
            //        await context.Response.WriteAsync("Not Authenticated");
            //    }
            //    else await next();
            //});

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            // Enable middleware to serve generated Swagger as JSON endpoints
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "ProdQ API V1");
                c.SwaggerEndpoint("/swagger/v2/swagger.json", "ProdQ API V2");
            });

            //app.UseAuthorization();
            //app.MapControllers();
            //app.Run();
        }
    }
}
