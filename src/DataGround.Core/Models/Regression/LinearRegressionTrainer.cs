using DataGround.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace DataGround.Core.Models
{
    public class LinearRegressionTrainer : ITrainerAsync<CartesianInput, LinearRegressionModel>
    {
        int _iterations;

        public LinearRegressionTrainer(int iterations)
        {
            _iterations = iterations;
        }

        public async Task<LinearRegressionModel> TrainAsync(CartesianInput input)
        {
            //Apply parameters
            //Process input and create model

            var avgX = input.Points.Average(p => p.X);
            var avgY = input.Points.Average(p => p.Y);

            var term = input.Points.Select(p => new Tuple<float, float>(p.X - avgX, p.Y - avgY));
            var slope = term.Sum(t => t.Item1 * t.Item2) / term.Select(t => (float)Math.Pow(t.Item1, 2)).Sum();

            var intercept = avgY - slope * avgX;

            return new LinearRegressionModel()
            {
                LinearParameters = new List<float>(){
                    slope,
                    intercept
                }
            };
        }

        public void Cancel()
        {
        }
    }
}
