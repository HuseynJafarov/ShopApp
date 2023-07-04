using Microsoft.Extensions.DependencyInjection;
using Repository.Repositories.Implementation;
using Repository.Repositories.Interface;


namespace Repository.Dependency
{
    public static class DependencyInjection
    {
        public static IServiceCollection RepositoryDescriptors(this IServiceCollection services)
        {
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped<IAboutRepository, AboutRepository>();
            services.AddScoped<IAuthorRepository, AuthorRepository>();
            services.AddScoped<IBasketRepository, BasketRepository>();
            services.AddScoped<IBlogRepository, BlogRepository>();
            services.AddScoped<ICartsRepository, CartsRepository>();
            services.AddScoped<ICartAuthorRepository, CartAuthorRepository>();
            services.AddScoped<IContactRepository, ContactRepository>();
            services.AddScoped<IEventsRepository, EventsRepository>();
            services.AddScoped<ISubscribeRepository, SubscribeRepository>();
            services.AddScoped<ISettingsRepository, SettingsRepository>();
            services.AddScoped<ISliderRepository, SliderRepository>();
            services.AddScoped<ISliderBoxsRepository, SliderBoxsRepository>();
            services.AddScoped<IServicesRepository, ServicesRepository>();
            services.AddScoped<IStudentRepository, StudentRepository>();
            services.AddScoped<ITellUsRepository, TellUsRepository>();

            return services;
        }

    }
}
