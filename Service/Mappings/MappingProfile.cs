using AutoMapper;
using Domain.Entities;
using Service.DTOs.About;
using Service.DTOs.Account;
using Service.DTOs.Author;
using Service.DTOs.Cart;
using Service.DTOs.Contact;
using Service.DTOs.Event;
using Service.DTOs.HeroSlider;
using Service.DTOs.Services;
using Service.DTOs.Setting;
using Service.DTOs.Slider;
using Service.DTOs.SliderBox;
using Service.DTOs.Student;
using Service.DTOs.Subscribe;
using Service.DTOs.TellUs;


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
            CreateMap<Author, AuthorListDto>();
            CreateMap<AuthorCreateAndUpdateDto, Author>().ReverseMap();

            CreateMap<CartCreateAndUpdateDto, Carts>();
            CreateMap<Carts,CartListDto>();
            CreateMap<CartCreateAndUpdateDto,Carts>().ReverseMap();

            CreateMap<ContactCreateAndUpdateDto, Contact>();
            CreateMap<Contact, ContactListDto>();
            CreateMap<ContactCreateAndUpdateDto,Contact>().ReverseMap();

            CreateMap<EventCreateAndUpdateDto, Events>();
            CreateMap<Events,EventListDto>();
            CreateMap<EventCreateAndUpdateDto,Events>().ReverseMap();

            CreateMap<HeroSliderCreateAndUpdateDto, HeroSliders>();
            CreateMap<HeroSliders,HeroSliderListDto>();
            CreateMap<HeroSliderCreateAndUpdateDto, HeroSliders>().ReverseMap();

            CreateMap<ServicesCreateAndUpdateDto, Services>();
            CreateMap<Services, ServicesListDto>();
            CreateMap<ServicesCreateAndUpdateDto, Services>().ReverseMap();

            CreateMap<SettingCreateAndUpdateDto, Settings>();
            CreateMap<Settings, ServicesCreateAndUpdateDto>();
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
            CreateMap<Student, StudentListDto>();
            CreateMap<StudentCreateAndUpdateDto, Student>().ReverseMap();


            CreateMap<RegisterDto, AppUser>().ReverseMap();
        }
    }
}
