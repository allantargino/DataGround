using DataGround.Storage.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataGround.Storage.Models
{
    class JsonSerializer<TValue> : ISerializer<TValue>
        where TValue : class
    {
        public TValue Deserialize(string value) => JsonConvert.DeserializeObject<TValue>(value);

        public string Serialize(TValue value) => JsonConvert.SerializeObject(value);

    }
}
