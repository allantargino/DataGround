using System;
using System.Collections.Generic;
using System.Text;

namespace DataGround.Core.Models
{
    public class CartesianPoint
    {
        public CartesianPoint(float x, float y)
        {
            X = x;
            Y = y;
        }
        public float X { get; set; }
        public float Y { get; set; }
    }
}
