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
             await _repo.Create(_mapper.Map<Student>(data));
        }

        public async Task DeleteAsync(int id)
        {
             await _repo.Delete(await _repo.Get(id));
        }

        public async Task<List<StudentListDto>> GetAllAsync()
        {
            return  _mapper.Map<List<StudentListDto>>(await _repo.GetAll());
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
            await _repo.SoftDelete(await _repo.Get(id));
        }

        public async Task UpdateAsync(int id, StudentCreateAndUpdateDto data)
        {
            Student dbStudent = await (_repo.Get(id));
            _mapper.Map(data, dbStudent);
            await _repo.Update(dbStudent);
        }
    }
}
