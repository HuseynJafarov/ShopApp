using AutoMapper;
using Domain.Entities;
using Repository.Repositories.Interface;
using Service.DTOs.Contact;
using Service.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Service.Implementation
{
    public class ContactService : IContactService
    {
        private readonly IContactRepository _repo;
        private readonly IMapper _mapper;

        public ContactService(IContactRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task CreateAsync(ContactCreateAndUpdateDto contact)
        {
            await _repo.Create(_mapper.Map<Contact>(contact));
        }

        public async Task DeleteAsync(int id)
        {
            Contact contact = await _repo.GetById(id);
            await _repo.Delete(contact);
        }

        public async Task<List<ContactListDto>> GetAllAsync()
        {
            return _mapper.Map<List<ContactListDto>>(await _repo.GetAll());
        }

        public async Task<List<ContactListDto>> SerachAsync(string? searchText)
        {
            List<Contact> searchDatas = new();
            if (searchText != null)
            {
                searchDatas = await _repo.FindAllAsync(m => m.Title.Contains(searchText) && m.Email.Contains(searchText) && m.Phone.Contains(searchText));
            }
            else
            {
                searchDatas = await _repo.GetAll();
            }


            return _mapper.Map<List<ContactListDto>>(searchDatas);
        }

        public async Task SoftDeleteAsync(int id)
        {
            Contact contact = await _repo.GetById(id);
            await _repo.SoftDelete(contact);
        }

        public async Task UpdateAsync(int id, ContactCreateAndUpdateDto contact)
        {
            var dbContact = await _repo.GetById(id);
            _mapper.Map(contact, dbContact);
            await _repo.Update(dbContact);
        }
    }
}
