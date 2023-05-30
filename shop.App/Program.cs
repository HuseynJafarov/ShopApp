using Microsoft.EntityFrameworkCore;
using Repository.Data;
using Repository.Repositories.Implementation;
using Repository.Repositories.Interface;
using Service.Mappings;
using Service.Service.Implementation;
using Service.Service.Interface;

namespace shop.App
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddDbContextPool<AppDbContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
            });

            builder.Services.AddAutoMapper(typeof(MappingProfile));

            builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

            builder.Services.AddScoped<IAboutRepository, AboutRepository>();
            builder.Services.AddScoped<IAboutService, AboutService>();

            builder.Services.AddScoped<ICartsRepository, CartsRepository>();
            builder.Services.AddScoped<ICartService, CartService>();

            builder.Services.AddScoped<IContactRepository, ContactRepository>();
            builder.Services.AddScoped<IContactService, ContactService>();

            builder.Services.AddScoped<IEventsRepository, EventsRepository>();
            builder.Services.AddScoped<IEventService, EventService>();

            builder.Services.AddScoped<IHeroSlidersRepository, HeroSlidersRepository>();
            builder.Services.AddScoped<IHeroSliderService, HeroSliderService>();

            builder.Services.AddScoped<IServicesRepository, ServicesRepository>();
            builder.Services.AddScoped<IServicesService, ServicesService>();

            builder.Services.AddScoped<ISettingsRepository, SettingsRepository>();
            builder.Services.AddScoped<ISettingService, SettingService>();

            builder.Services.AddScoped<ISliderBoxsRepository, SliderBoxsRepository>();
            builder.Services.AddScoped<ISliderBoxService, SliderBoxService>();

            builder.Services.AddScoped<ISliderRepository, SliderRepository>();
            builder.Services.AddScoped<ISliderService, SliderService>();

            builder.Services.AddScoped<ISubscribeRepository, SubscribeRepository>();
            builder.Services.AddScoped<ISubscribeService, SubscribeService>();

            builder.Services.AddScoped<ITellUsRepository, TellUsRepository>();
            builder.Services.AddScoped<ITellusService, TellusService>();

            builder.Services.AddCors(options =>
            {
                options.AddPolicy(name: "mycors",
                    policy =>
                    {
                        policy.WithOrigins("http://localhost:3000")
                        .AllowAnyHeader()
                        .AllowAnyMethod();
                    });
            });


            var app = builder.Build();



            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }
            app.UseCors("mycors");

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}