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
            services.AddScoped<ISubscribeRepository, SubscribeRepository>();
            services.AddScoped<ISettingsRepository, SettingsRepository>();
            services.AddScoped<ICartsRepository, CartsRepository>();
            services.AddScoped<ITellUsRepository, TellUsRepository>();
            services.AddScoped<IEventsRepository, EventsRepository>();
            services.AddScoped<ISliderBoxsRepository, SliderBoxsRepository>();
            services.AddScoped<IServicesRepository, ServicesRepository>();
            services.AddScoped<ICartAuthorRepository, CartAuthorRepository>();
            services.AddScoped<IBlogRepository, BlogRepository>();
            services.AddScoped<IStudentRepository, StudentRepository>();
            services.AddScoped<IContactRepository, ContactRepository>();
            services.AddScoped<IAuthorRepository, AuthorRepository>();
            services.AddScoped<IAboutRepository, AboutRepository>();

            return services;
        }

    }
}
