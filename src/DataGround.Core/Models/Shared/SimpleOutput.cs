using DataGround.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataGround.Core.Models
{
    public class SimpleOutput : IOutput
    {
        public IList<float> Result { get; private set; }

        public SimpleOutput()
        {
            Result = new List<float>();
        }
    }
}
