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
            services.AddScoped<IAboutService, AboutService>();
            services.AddScoped<IAccountService, AccountService>();
            services.AddScoped<IAuthorService, AuthorService>();
            services.AddScoped<IBlogService, BlogService>();
            services.AddScoped<IBasketService, BasketService>();
            services.AddScoped<ICartService, CartService>();
            services.AddScoped<IContactService, ContactService>();
            services.AddScoped<IEventService, EventService>();
            services.AddScoped<ISliderBoxService, SliderBoxService>();
            services.AddScoped<ISliderService, SliderService>();
            services.AddScoped<ISubscribeService, SubscribeService>();
            services.AddScoped<ISettingService, SettingService>();
            services.AddScoped<IServicesService, ServicesService>();
            services.AddScoped<IStudentService, StudentService>();
            services.AddScoped<ITellusService, TellusService>();
            services.AddScoped<IEmailService, EmailService>();
            //services.AddHttpContextAccessor();

            return services;
        }
    }
}
