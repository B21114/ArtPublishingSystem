using APS.DBS.Infrastructure;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Identity;
using APS.Web.MVC.DataBaseContext;
using APS.Dbs.Domain.Entities.Identity;
using System.Reflection;
using MediatR;
using APS.DBS.Domain;
using AutoMapper;
using APS.DBS.Domain.Entities.Identity;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace APS.Web.MVC
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
            // Добавляем контекст ContentContex в качестве сервиса в приложение.
            services.AddDbContext<IContentDbContext, ContentDbContext>(options => options.UseInMemoryDatabase("MyDataBase"));

            // Добавляем контекст PersonContex в качестве сервиса в приложение.
            services.AddDbContext<IPersonDbContext, PersonDbContext>(options => options.UseInMemoryDatabase("MyDataBase"));

            // Добавляем контекст FileContext в качестве сервиса в приложение.
            services.AddDbContext<IFileDbContext, FileDbContext>(options => options.UseInMemoryDatabase("MyDataBase"));

            // Сервис временной базы данных в памяти компьютера.
            services.AddDbContext<ApplicationContext>(option => option.UseInMemoryDatabase("MyDataBase"));

            // Сервис для начальной установки конфигурации.
            services.AddIdentity<User, Role>().AddEntityFrameworkStores<ApplicationContext>();

            // Сервис представляющий заголовки содержимого и тело сущности HTTP.
            services.AddHttpContextAccessor();

            // Сервис помогающий реализовать паттер Mediator(Посредник).
            services.AddMediatR(Assembly.GetExecutingAssembly());

            // Получаем строку подключения из файла конфигурации.
            string connection = Configuration.GetConnectionString("DefaultConnection");

            // Получение типов.
            var assemblies = new Assembly[]
            {
                typeof(APS.CMS.Application.Bootstrap.ServiceCollectionExtensions).Assembly,
                typeof(APS.UIS.RegistrationUser.RegistrationUserRequest).Assembly,
                typeof(APS.UIS.RegistrationUser.RegistrationUserRequestHandler).Assembly,
                typeof(APS.UIS.RegistrationUser.RegistrationUserResponse).Assembly,
                typeof(APS.UIS.RegistrationUser.RegistrationUserValidator).Assembly,
                typeof(APS.UIS.LoginUser.LoginUserRequest).Assembly,
                typeof(APS.UIS.LoginUser.LoginUserRequestHandler).Assembly,
                typeof(APS.UIS.LoginUser.LoginUserResponse).Assembly
            };

            // Сервис позволяющий проецировать одну модель на другую.
            services.AddAutoMapper(assemblies);

            // Сервис сканирует сборки и добавляет в контейнер реализации обработчиков.
            services.AddMediatR(assemblies);

            // Сервис 
            services.AddTransient<IFileDbContext, FileDbContext>();

            // Добавляются все сервисы MVC.
            services.AddMvc();

            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(options => options.LoginPath = new Microsoft.AspNetCore.Http.PathString("Account/LogIn"));

            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
