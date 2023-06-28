using Microsoft.Extensions.DependencyInjection;
using Service.Mappings;
using Service.Service.Implementation;
using Service.Service.Interface;


namespace Service.Helpers.Dependency
{
    public static class DependencyInjection
    {
        public static IServiceCollection ServiceDescriptors(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(MappingProfile));
            services.AddScoped<IBlogService, BlogService>();
            services.AddScoped<IAboutService, AboutService>();
            services.AddScoped<IEventService, EventService>();
            services.AddScoped<IAuthorService, AuthorService>();
            services.AddScoped<IServicesService, ServicesService>();
            services.AddScoped<ICartService, CartService>();
            services.AddScoped<ISettingService, SettingService>();
            services.AddScoped<IContactService, ContactService>();
            services.AddScoped<IAccountService, AccountService>();
            services.AddScoped<ISliderBoxService, SliderBoxService>();
            services.AddScoped<ISliderService, SliderService>();
            services.AddScoped<ISubscribeService, SubscribeService>();
            services.AddScoped<ITellusService, TellusService>();
            services.AddScoped<IStudentService, StudentService>();
            //services.AddHttpContextAccessor();

            return services;
        }
    }
}
