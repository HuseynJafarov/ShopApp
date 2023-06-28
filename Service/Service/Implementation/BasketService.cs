using AutoMapper;
using Repository.Repositories.Interface;
using Service.DTOs.Basket;
using Service.Service.Interface;


namespace Service.Service.Implementation
{
    public class BasketService : IBasketService
    {
        private readonly IBasketRepository _basketRepo;
        private readonly IMapper _mapper;
        public BasketService(IBasketRepository basketRepository, IMapper mapper)
        {
            _basketRepo = basketRepository;
            _mapper = mapper;
        }

        public async Task AddBasketAsync(int id)
        {
           await _basketRepo.AddBasket(id);
        }

        public async Task DeleteBasketAsync(int id)
        {
            await _basketRepo.DeleteBasket(id);
        }

        public async Task DeleteItemBasketAsync(int id)
        {
            await _basketRepo.DeleteItemBasket(id);
        }

        public async Task<List<BasketCartListDto>> GetBasketCartsAsync()
        {
           var data = await _basketRepo.GetBasketCarts();
           var mapData = _mapper.Map<List<BasketCartListDto>>(data);
           return mapData;
        }

        public async Task<int> GetBasketCountAsync()
        {
            var data = await _basketRepo.GetBasketCount();
            return data;
        }
    }
}
