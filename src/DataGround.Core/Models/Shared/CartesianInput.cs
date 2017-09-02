using DataGround.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataGround.Core.Models
{
    public class CartesianInput : IInput
    {
        public IEnumerable<CartesianPoint> Points { get; private set; }

        public CartesianInput(IEnumerable<CartesianPoint> points)
        {
            if (points == null)
                throw new ArgumentNullException(nameof(points));
            if (points.Where(p => p == null).Count() > 0)
                throw new ArgumentNullException("There is one or more null points");

            Points = points;
        }
    }
}
