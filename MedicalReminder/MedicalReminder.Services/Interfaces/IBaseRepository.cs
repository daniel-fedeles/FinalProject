using System;
using System.Collections.Generic;

namespace MedicalReminder.Services.Interfaces
{
    public interface IBaseRepository<T>
    {
        T GetById(Guid id);
        IList<T> GetAll();
        T SaveUser(T item);
        void DeleteUserById(Guid id);
        void UpdateUser(Guid id, T user);
    }
}