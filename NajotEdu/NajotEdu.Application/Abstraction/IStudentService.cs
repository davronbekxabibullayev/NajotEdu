﻿using NajotEdu.Application.Models;

namespace NajotEdu.Application.Abstraction
{
    public interface IStudentService
    {
        Task<StudentViewModel> GetById(int Id);
        Task<IEnumerable<StudentViewModel>> GetAll();
        Task<int> Create(CreateStudentModel createStudentModel);
        Task<int> Update(UpdateStudentModel updateStudentModel);
        Task<int> Delete(int Id);
    }
}
