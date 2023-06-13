using AutoMapper;
using Domain.Entities;
using Microsoft.AspNetCore.Http;
using Repository.Repositories.Implementation;
using Repository.Repositories.Interface;
using Service.DTOs.Cart;
using Service.Helpers;
using Service.Service.Interface;
using System.Text;

namespace Service.Service.Implementation
{
    public class CartService : ICartService
    {
        private readonly ICartsRepository _repo;
        private readonly IMapper _mapper;
        private readonly IAuthorRepository _authorRepo;

        public CartService(ICartsRepository repo, IMapper mapper, IAuthorRepository authorRepo)
        {
            _repo = repo;
            _mapper = mapper;
            _authorRepo = authorRepo;

        }

        public async Task CreateAsync(CartCreateAndUpdateDto cart)
        {
          

            if(cart.AuthorIds != null && cart.AuthorIds.Any())
            {
                var authors = await _authorRepo.FindAllAsync(a => cart.AuthorIds.Contains(a.Id));

                var mapCart = _mapper.Map<Carts>(cart);
                mapCart.Image = await cart.Photo.GetBytes();
                mapCart.CartAuthors = new List<CartAuthor>();

                foreach (var author in authors)
                {
                    var cartAuthor = new CartAuthor
                    {
                        Carts = mapCart,
                        Author = author
                    };
                    mapCart.CartAuthors.Add(cartAuthor);
                }

                await _repo.Create(mapCart);
            }
            else
            {
                throw new Exception("You must select at least one author.");
            }

            #region oldCreate
            //var mappedDatas = _mapper.Map<Carts>(cart);
            //mappedDatas.Image = await cart.Photo.GetBytes(); 
            //await _repo.Create(mappedDatas);
            #endregion
        }

        public async Task DeleteAsync(int id)
        {
            Carts carts = await _repo.Get(id);
            await _repo.Delete(carts);
        }

       

        public async Task<List<CartListDto>> GetAllAsync()
        {
            var dbData = await _repo.GetAllNew();
           
            //var newdata = dbData.Select(d=>new CartListDto
            //{
            //    Image = Convert.ToBase64String(d.Image)
            //}).ToList();
            var data = _mapper.Map<List<CartListDto>>(dbData);
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
            var existingCart = await _repo.Get(id);
            if (existingCart == null)
            {
                throw new Exception("Cart not found");
            }

            if (cart.AuthorIds != null && cart.AuthorIds.Any())
            {
                var authors = await _authorRepo.FindAllAsync(a => cart.AuthorIds.Contains(a.Id));

                existingCart.Title = cart.Title;
                existingCart.Description = cart.Description;
                existingCart.Image = await cart.Photo.GetBytes();

                // Remove existing cart authors
                existingCart.CartAuthors.Clear();

                foreach (var author in authors)
                {
                    var cartAuthor = new CartAuthor
                    {
                        Carts = existingCart,
                        Author = author
                    };
                    existingCart.CartAuthors.Add(cartAuthor);
                }

                await _repo.Update(existingCart);
            }
            else
            {
                throw new Exception("You must select at least one author.");
            }
        }
    }
}
