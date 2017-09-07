using System;
using System.Collections.Generic;
using System.Text;

namespace DataGround.Storage.Interfaces
{
    interface IRepository
    {
        bool Add(string key, string value);
        bool Delete(string key);
        string Get(string key);
        bool Update(string key, string value);
    }
}
