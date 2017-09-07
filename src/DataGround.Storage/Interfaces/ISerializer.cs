using System;
using System.Collections.Generic;
using System.Text;

namespace DataGround.Storage.Interfaces
{
    interface ISerializer<TValue>
    {
        string Serialize(TValue value);
        TValue Deserialize(string value);
    }
}
