using AutoMapper;
using Domain.Entities;
using Service.DTOs.About;
using Service.DTOs.Author;
using Service.DTOs.Blog;
using Service.DTOs.Cart;
using Service.DTOs.Contact;
using Service.DTOs.Event;
using Service.DTOs.Services;
using Service.DTOs.Setting;
using Service.DTOs.Slider;
using Service.DTOs.SliderBox;
using Service.DTOs.Student;
using Service.DTOs.Subscribe;
using Service.DTOs.TellUs;
using Services.DTOs.Account;

namespace Service.Mappings
{
    public class MappingProfile :Profile
    {
        public MappingProfile()
        {
            CreateMap<AboutCreateAndUpdateDto, About>();
            CreateMap<About, AboutListDto>();
            CreateMap<AboutCreateAndUpdateDto, About>().ReverseMap();

            CreateMap<AuthorCreateAndUpdateDto, Author>();
            CreateMap<Author, AuthorListDto>()
                .ForMember(dest => dest.BlogTitle, opt => opt.MapFrom(src => src.Blog.Title))
                .ForMember(dest => dest.CartsTitle, opt => opt
                        .MapFrom(src => src.CartAuthors.Where(m => m.AuthorId == src.Id).Select(d => d.Carts.Title)))
                .ForMember(dest => dest.Image, opt => opt
                        .MapFrom(src => Convert.ToBase64String(src.Image)));
            CreateMap<AuthorCreateAndUpdateDto, Author>().ReverseMap();

            CreateMap<BlogCreateAndUpdateDto, Blog>();
            CreateMap<Blog, BlogListDto>()
                .ForMember(dest => dest.AuthorName, opt => opt.MapFrom(src => src.Author.Name))
                .ForMember(dest => dest.Image, opt => opt.MapFrom(src => Convert.ToBase64String(src.Image)));
            CreateMap<BlogCreateAndUpdateDto, Blog>().ReverseMap();

            CreateMap<CartCreateAndUpdateDto, Carts>();
            CreateMap<Carts, CartListDto>()
                .ForMember(dest => dest.AuthorName, opt => opt
                        .MapFrom(src => src.CartAuthors.Where(m => m.CartsId == src.Id).Select(d => d.Author.Name)))
                .ForMember(dest => dest.StudentFullName, opt => opt
                        .MapFrom(src => src.Students.Select(d => d.FullName)))
                .ForMember(dest => dest.Image, opt => opt.MapFrom(src => Convert.ToBase64String(src.Image)));
            CreateMap<CartCreateAndUpdateDto, Carts>().ReverseMap();

            CreateMap<ContactCreateAndUpdateDto, Contact>();
            CreateMap<Contact, ContactListDto>();
            CreateMap<ContactCreateAndUpdateDto,Contact>().ReverseMap();

            CreateMap<EventCreateAndUpdateDto, Events>();
            CreateMap<Events,EventListDto>();
            CreateMap<EventCreateAndUpdateDto,Events>().ReverseMap();
        
            CreateMap<ServicesCreateAndUpdateDto, Domain.Entities.Services>();
            CreateMap<Domain.Entities.Services, ServicesListDto>();
            CreateMap<ServicesCreateAndUpdateDto, Domain.Entities.Services>().ReverseMap();

            CreateMap<SettingCreateAndUpdateDto, Settings>();
            CreateMap<Settings, SettingListDto>();
            CreateMap<SettingCreateAndUpdateDto, Settings>().ReverseMap();

            CreateMap<SliderCreateAndUpdateDto, Slider>();
            CreateMap<Slider, SliderListDto>();
            CreateMap<SliderCreateAndUpdateDto, Slider>().ReverseMap();

            CreateMap<SliderBoxCreateAndUpdateDto, SliderBoxs>();
            CreateMap<SliderBoxs, SliderBoxListDto>();
            CreateMap<SliderBoxCreateAndUpdateDto, SliderBoxs>().ReverseMap();

            CreateMap<SubscribeCreateAndUpdateDto, Subscribe>();
            CreateMap<Subscribe, SubscribeListDto>();
            CreateMap<SubscribeCreateAndUpdateDto, Subscribe>().ReverseMap();

            CreateMap<TellUsCreateAndUpdateDto, TellUs>();
            CreateMap<TellUs, TellusListDto>();
            CreateMap<TellUsCreateAndUpdateDto, TellUs>().ReverseMap();

            CreateMap<StudentCreateAndUpdateDto, Student>();
            CreateMap<Student, StudentListDto>()
                .ForMember(dest => dest.CartTitle, opt => opt.MapFrom(src => src.Carts.Title))
                .ForMember(dest => dest.Image, opt => opt.MapFrom(src => Convert.ToBase64String(src.Image)));
            
            CreateMap<StudentCreateAndUpdateDto, Student>().ReverseMap();


            CreateMap<RegisterDto, AppUser>();
            CreateMap<AppUser, UserDto>();

        }
    }
}
