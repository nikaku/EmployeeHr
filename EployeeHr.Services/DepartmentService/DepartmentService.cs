using AutoMapper;
using Hr.BL.Dtos.Department;
using Hr.BL.Entities;
using Hr.BL.Interaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Hr.Services.DepartmentService
{
    public class DepartmentService : IDepartmentService
    {
        private IMapper _mapper;
        private IUnitOfWork _unitOfWork;

        public DepartmentService(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public GetDepartmentDto Add(CreateDepartmentDto createDepartmentDto)
        {
            var department = _mapper.Map<Department>(createDepartmentDto);
            var departmentInDb = _unitOfWork.DepartmentRepository.Add(department);
            _unitOfWork.SaveChanges();
            return _mapper.Map<GetDepartmentDto>(departmentInDb);
        }

        public void Delete(int id)
        {
            var department = _unitOfWork.DepartmentRepository.Get(id);
            if (department != null)
            {
                _unitOfWork.DepartmentRepository.Remove(department);
                _unitOfWork.SaveChanges();
            }
        }

        public GetDepartmentDto Get(int id)
        {
            var department = _unitOfWork.DepartmentRepository.Get(id);
            var departmentDto = _mapper.Map<GetDepartmentDto>(department);
            return departmentDto;
        }

        public IEnumerable<GetDepartmentDto> GetAll()
        {
            var departments = _unitOfWork.DepartmentRepository.GetAll();
            var departmentsDtos = _mapper.Map<IEnumerable<GetDepartmentDto>>(departments);
            return departmentsDtos;
        }

        public GetDepartmentDto Update(UpdateDepartmentDto updateDepartmentDto)
        {
            var department = _mapper.Map<Department>(updateDepartmentDto);

            var departmentInDb = _unitOfWork.DepartmentRepository.Get(updateDepartmentDto.Id);

            if (departmentInDb == null)
            {
                throw new Exception("Not Found");
            }

            departmentInDb.Fund = updateDepartmentDto.Fund;
            departmentInDb.CreateDate = DateTime.Now;
            departmentInDb.Area = updateDepartmentDto.Area;
            departmentInDb.Name = updateDepartmentDto.Name;
            departmentInDb.Order = updateDepartmentDto.Order;
            departmentInDb.DepartmentsAndBranches = department.DepartmentsAndBranches;

            _unitOfWork.DepartmentRepository.Update(departmentInDb);
            _unitOfWork.SaveChanges();
            return _mapper.Map<GetDepartmentDto>(departmentInDb);
        }
    }
}
