using DataGround.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataGround.Core.Models
{
    public class LinearRegressionModel : IModel
    {
        public IEnumerable<float> LinearParameters { get; set; }
    }
}
