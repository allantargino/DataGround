using DataGround.Storage.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataGround.Storage.Models
{
    class AzureTableTypedRepository<TValue> : ITypedRepository<TValue, AzureTableRepository, JsonSerializer<TValue>>
        where TValue : class
    {
        public IStorageManager<TValue, AzureTableRepository, JsonSerializer<TValue>> StorageManager { get; }

        public AzureTableTypedRepository()
        {
            var repository = new AzureTableRepository();
            var serializer = new JsonSerializer<TValue>();
            StorageManager = new StorageManager<TValue, AzureTableRepository, JsonSerializer<TValue>>(repository, serializer);
        }

        public bool Add(string key, TValue value) => StorageManager.Add(key, value);

        public bool Delete(string key) => StorageManager.Delete(key);

        public TValue Get(string key) => StorageManager.Get(key);

        public bool Update(string key, TValue value) => StorageManager.Update(key, value);
    }
}
