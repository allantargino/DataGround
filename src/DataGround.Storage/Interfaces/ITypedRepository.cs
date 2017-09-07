using System;
using System.Collections.Generic;
using System.Text;

namespace DataGround.Storage.Interfaces
{
    interface ITypedRepository<TValue, TRepository, TSerializer>
        where TValue : class
        where TRepository : IRepository
        where TSerializer : ISerializer<TValue>
    {
        IStorageManager<TValue, TRepository, TSerializer> StorageManager { get; }

        bool Add(string key, TValue value);
        bool Delete(string key);
        TValue Get(string key);
        bool Update(string key, TValue value);
    }
}
