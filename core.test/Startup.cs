using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using core.test.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace core.test
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
            //主要提供了三种依赖注入的方式
            //services.AddTransient<IOperationTransient, Operation>(); //每次请求，都获取一个新的实例(同一个请求获取多次也会是不同的实例)
            //services.AddScoped<IMyDependency, MyDependency>();       //每次请求，都获取一个新的实例(同一个请求获取多次会得到相同的实例)       
            //services.AddSingleton<IOperationSingleton, Operation>(); //每次请求, 都获取同一个实例

           
            services.AddDbContext<Context>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));


            services.AddMvc();
            //添加redis
            services.AddDistributedRedisCache(options =>
            {
                options.Configuration = "localhost";

            });
        }

        public void Configure1(IApplicationBuilder app, IHostingEnvironment env) { 
        
        }
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {       

            if (env.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
/*                app.UseBrowserLink();
                app.UseDeveloperExceptionPage();*/
            }
            else
            {
                
            }

            //app.UseMiddleware<MiddleWareDemo>();

            app.UseStaticFiles();      

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
