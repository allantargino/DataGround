using DataGround.Storage.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataGround.Storage.Models
{
    class StorageManager<TValue, TRepository, TSerializer> : IStorageManager<TValue, TRepository,TSerializer>
        where TValue : class
        where TRepository : IRepository
        where TSerializer : ISerializer<TValue>
    {

        public TRepository Repository { get; }

        public TSerializer Serializer { get; }


        public StorageManager(TRepository repository, TSerializer serializer)
        {
            Repository = repository;
            Serializer = serializer;
        }

        public bool Add(string key, TValue value)
        {
            var strValue = Serializer.Serialize(value);
            return Repository.Add(key, strValue);
        }

        public bool Delete(string key)
        {
            return Repository.Delete(key);
        }

        public TValue Get(string key)
        {
            var strValue = Repository.Get(key);
            return Serializer.Deserialize(strValue);
        }

        public bool Update(string key, TValue value)
        {
            var strValue = Serializer.Serialize(value);
            return Repository.Update(key, strValue);
        }
    }
}
