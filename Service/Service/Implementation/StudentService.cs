using AutoMapper;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Repository.Repositories.Interface;
using Service.DTOs.Student;
using Service.Service.Interface;

namespace Service.Service.Implementation
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _repo;
        private readonly IMapper _mapper;

        public StudentService(IStudentRepository studentRepository, IMapper mapper)
        {
            _repo = studentRepository;
            _mapper = mapper;
        }

        public async Task CreateAsync(StudentCreateAndUpdateDto data)
        {
            return await _repo.Create(_mapper.Map<Student>(data));
        }

        public async Task DeleteAsync(int id)
        {
            return await _repo.Delete(await _repo.Get(id));
        }

        public Task<List<StudentListDto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<List<StudentListDto>> SerachAsync(string? searchText)
        {
            throw new NotImplementedException();
        }

        public Task SoftDeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(int id, StudentCreateAndUpdateDto data)
        {
            throw new NotImplementedException();
        }
    }
}
