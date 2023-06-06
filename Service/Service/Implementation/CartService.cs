using AutoMapper;
using Domain.Entities;
using Repository.Repositories.Interface;
using Service.DTOs.Cart;
using Service.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Service.Implementation
{
    public class CartService : ICartService
    {
        private readonly ICartsRepository _repo;
        private readonly IMapper _mapper;

        public CartService(ICartsRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task CreateAsync(CartCreateAndUpdateDto cart)
        {
           await _repo.Create(_mapper.Map<Carts>(cart));
        }

        public async Task DeleteAsync(int id)
        {
            Carts carts = await _repo.Get(id);
            await _repo.Delete(carts);
        }

        public async Task<List<CartListDto>> GetAllAsync()
        {
            return _mapper.Map<List<CartListDto>>(await _repo.GetAll());
        }

        public async Task<List<CartListDto>> GetAllAsyncWithAuthor()
        {
            var data = _mapper.Map<List<CartListDto>>(await _repo.GetAllWithAuthor());
            return data;
        }

        public async Task<List<CartListDto>> SerachAsync(string? searchText)
        {
            List<Carts> searchDatas = new();
            if (searchText != null)
            {
                searchDatas = await _repo.FindAllAsync(m => m.Title.Contains(searchText) && m.Description.Contains(searchText));
            }
            else
            {
                searchDatas = await _repo.GetAll();
            }
            return _mapper.Map<List<CartListDto>>(searchDatas);

        }

        public async Task SoftDeleteAsync(int id)
        {
            Carts carts = await _repo.Get(id);
            await _repo.SoftDelete(carts);
        }

        public async Task UpdateAsync(int id, CartCreateAndUpdateDto cart)
        {
            var dbCart = await _repo.Get(id);
            _mapper.Map(cart, dbCart);
            await _repo.Update(dbCart);
        }
    }
}
