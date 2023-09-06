using Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Repository.Data;
using Repository.Repositories.Interface;
using System.IdentityModel.Tokens.Jwt;

namespace Repository.Repositories.Implementation
{
    public class BasketRepository : IBasketRepository
    {
        private readonly AppDbContext _context;
        private readonly IHttpContextAccessor _httpAccessor;

        public BasketRepository(IHttpContextAccessor accessor,AppDbContext context)
        {
            _context = context;
            _httpAccessor = accessor;
        }

        public async Task AddBasket(int id)
        {
            try
            {
                var userId = GetUser();

                var basket = await GetBasketUserId(userId);

                if (basket == null)
                {
                    basket = new Basket
                    {
                        AppUserId = userId
                    };

                    await _context.Basket.AddAsync(basket);
                    await _context.SaveChangesAsync();
                }

                var basketCart = _context.BasketCart
                    .FirstOrDefault(bc =>bc.CartId == id && bc.BasketId == basket.Id);

                if (basketCart != null)
                {
                    basketCart.Quantity++;
                }
                else
                {
                    basketCart = new BasketCart
                    {
                        CartId = id,
                        BasketId = basket.Id,
                        Quantity = 1
                    };

                    basket.BasketCart.Add(basketCart);
                }
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

                Console.WriteLine("Hata Mesajı: " + ex.Message);

                if (ex.InnerException != null)
                {
                    Console.WriteLine("Inner Exception: " + ex.InnerException.Message);
                }
            }
        }

        public async Task DeleteBasket(int id)
        {
            var userId = GetUser();

            var basket = await GetBasketUserId(userId);

            if (basket == null) throw new NullReferenceException();

            var basketCart = basket.BasketCart
                .FirstOrDefault(bc=> bc.CartId == id && bc.BasketId == basket.Id);

            if(basketCart == null) throw new NullReferenceException();

            basket.BasketCart.Remove(basketCart);

            await _context.SaveChangesAsync();
        }

        public async Task DeleteItemBasket(int id)
        {
            var userId = GetUser();

            var basket = await GetBasketUserId(userId);

            if (basket == null) throw new NullReferenceException();

            var basketCart = basket.BasketCart
                .FirstOrDefault(bc => bc.CartId == id && bc.BasketId == basket.Id);

            if (basketCart == null) throw new NullReferenceException();

            if(basketCart.Quantity > 1)
            {
                basketCart.Quantity--;
            }
            else
            {
                basket.BasketCart.Remove(basketCart);
            }   
            await _context.SaveChangesAsync();
        }

        public async Task<List<BasketCart>> GetBasketCarts()
        {
            var userId = GetUser();

            var basket = await GetBasketUserIdWithCart(userId);

            var basketCart = basket.BasketCart;

            return basketCart;
        }

        public async Task<int> GetBasketCount()
        {
            var userId = GetUser();

            var basket = await GetBasketUserIdWithCart(userId);

            var basketCart = basket.BasketCart;

            var uniqeCarts = basketCart.GroupBy(x => x.Id)
                .Select(x=> x.First())
                .ToList();

            var uniqeCartCount = uniqeCarts.Count();

            return uniqeCartCount;
        }


        private async Task<Basket> GetBasketUserId(string id)
        {
           var data = await _context.Basket
                .Include(x=> x.BasketCart)
                .FirstOrDefaultAsync(x=> x.AppUserId == id);

            return data;
        }

        private async Task<Basket> GetBasketUserIdWithCart(string id)
        {
            var data = await _context.Basket
                 .Include(x => x.BasketCart)
                 .ThenInclude(x=> x.Cart)
                 .FirstOrDefaultAsync(x => x.AppUserId == id);

            if(data == null) throw new NullReferenceException();

            return data;
        }

        private string GetUser()
        {
            var user = _httpAccessor.HttpContext.User;

            if (user == null) throw new NullReferenceException();

            var userId = user.FindFirst(JwtRegisteredClaimNames.UniqueName)?.Value;

            if (userId == null) throw new NullReferenceException();

            return userId;
        }
    }
}
