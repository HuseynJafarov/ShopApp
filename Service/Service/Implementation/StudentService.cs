using AutoMapper;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Repository.Repositories.Interface;
using Service.DTOs.Student;
using Service.Helpers;
using Service.Service.Interface;

namespace Service.Service.Implementation
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _repo;
        private readonly IMapper _mapper;
        private readonly ICartsRepository _cartsRepository;

        public StudentService(IStudentRepository studentRepository,
            IMapper mapper,
            ICartsRepository cartsRepository)
        {
            _repo = studentRepository;
            _mapper = mapper;
            _cartsRepository = cartsRepository;
        }

        public async Task CreateAsync(StudentCreateAndUpdateDto data)
        {
            var cart = await _cartsRepository
            .FindAllAsync(a =>
            a.Id == data.CartsId);

            var mapStudent = _mapper
                .Map<Student>(data);

            mapStudent.Image = await
                data.Photo.GetBytes();

            await _repo.Create(mapStudent);
        }

        public async Task DeleteAsync(int id)
        {
             await _repo.Delete(await _repo.GetById(id));
        }

        public async Task<List<StudentListDto>> GetAllAsync()
        {
            return  _mapper.Map<List<StudentListDto>>(await _repo.GetAllWithCart());
        }

        public async Task<StudentListDto> GetByIdAsync(int id)
        {
            return _mapper.Map<StudentListDto>(await _repo.GetByIdWithCart(id));
        }

        public async Task<List<StudentListDto>> SerachAsync(string? searchText)
        {
            List<Student> searchDatas = new();
            if (searchText != null)
            {
                searchDatas = await _repo.FindAllAsync(x => x.FullName.Contains(searchText)
                               && x.Info.Contains(searchText));
            }
            else
            {
                searchDatas = await _repo.GetAll();
            }

            return _mapper.Map<List<StudentListDto>>(searchDatas);
        }

        public async Task SoftDeleteAsync(int id)
        {
            await _repo.SoftDelete(await _repo.GetById(id));
        }

        public async Task UpdateAsync(int id, StudentCreateAndUpdateDto data)
        {
            Student dbStudent = await _repo.GetById(id);
            _mapper.Map(data, dbStudent);
            await _repo.Update(dbStudent);
        }
    }
}
