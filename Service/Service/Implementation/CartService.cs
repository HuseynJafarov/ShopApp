using AutoMapper;
using Domain.Entities;
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
        private readonly ICartAuthorRepository _cartAuthorRepo;

        public CartService(ICartAuthorRepository cartAuthorRepository
            ,ICartsRepository repo
            , IMapper mapper
            , IAuthorRepository authorRepo)
        {
            _repo = repo;
            _mapper = mapper;
            _authorRepo = authorRepo;
            _cartAuthorRepo = cartAuthorRepository;
        }

        public async Task CreateAsync(CartCreateAndUpdateDto cart)
        {

            if (cart.AuthorIds != null && cart.AuthorIds.Any())
            {
                var authors = await _authorRepo
                    .FindAllAsync(a => cart.AuthorIds
                    .Contains(a.Id));

                var mapCart = _mapper.Map<Carts>(cart);
                mapCart.Image = await cart.Photo.GetBytes();
                mapCart.CartAuthors = new List<CartAuthor>();

                foreach (var author in authors)
                {
                    var cartAuthor = new CartAuthor
                    {
                        Carts = mapCart,
                        AuthorId = author.Id
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
            Carts carts = await _repo.GetById(id);
            await _repo.Delete(carts);
        }

        public async Task<List<CartListDto>> GetAllAsync()
        {
            var dbData = await _repo.GetAllCartAuthor();

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
            Carts carts = await _repo.GetById(id);
            await _repo.SoftDelete(carts);
        }

        public async Task UpdateAsync(int id, CartCreateAndUpdateDto cart)
        {
            if (cart.AuthorIds != null && cart.AuthorIds.Any())
            {
                var authors = await _authorRepo
                    .FindAllAsync(a => cart.AuthorIds
                    .Contains(a.Id));

                var mapCart = _mapper.Map<Carts>(cart);
                mapCart.Id = id;
                mapCart.Image = await cart.Photo.GetBytes();
                mapCart.CartAuthors = new List<CartAuthor>();
                var cartAuthor1 = await _repo.GetByIdCartAuthor(id);

                await _cartAuthorRepo
                    .DeleteCartAuthor(cartAuthor1
                    .CartAuthors
                    .ToList());

                foreach (var author in authors)
                {
                        var cartAuthor = new CartAuthor
                        {
                            CartsId = id,
                            AuthorId = (await GetByIdAsync(author.Id)).Id
                        };
                        mapCart.CartAuthors.Add(cartAuthor);
                }
                _mapper.Map(cart, mapCart);
                await _repo.Update(mapCart);
            }
            else
            {
                throw new Exception("You must select at least one author.");
            }
        }

        public async Task<CartListDto> GetByIdAsync(int id)
        {
            var dbData = await _repo.GetByIdCartAuthor(id);

            var data = _mapper.Map<CartListDto>(dbData);
            return data;
        }
    }
}
