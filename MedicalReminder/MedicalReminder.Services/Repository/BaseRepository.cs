using System;
using System.Collections.Generic;
using MedicalReminder.Models;
using MedicalReminder.Services.Interfaces;

namespace MedicalReminder.Services.Repository
{
    public class BaseRepository<T>:IBaseRepository<T> where T : IDEntity
    {
        public T GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public IList<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public T SaveUser(T item)
        {
            throw new NotImplementedException();
        }

        public void DeleteUserById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void UpdateUser(Guid id, T user)
        {
            throw new NotImplementedException();
        }
    }
}