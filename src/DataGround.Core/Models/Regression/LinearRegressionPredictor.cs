using DataGround.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace DataGround.Core.Models
{
    public class LinearRegressionPredictor : IPredictorAsync<LinearRegressionModel, CartesianInput, SimpleOutput>
    {
        private float _slope;
        private float _intercept;

        public void Init(LinearRegressionModel model)
        {
            if (model == null) throw new ArgumentNullException(nameof(model));
            _slope = model.LinearParameters.ElementAt(0);
            _intercept = model.LinearParameters.ElementAt(1);
        }

        public async Task<SimpleOutput> ComputeAsync(CartesianInput input)
        {
            if (input == null) throw new ArgumentNullException(nameof(input));

            var output = new List<float>();
            foreach (var item in input.Points)
                output.Add(DoCalculation(item));

            return new SimpleOutput(output);
        }

        private float DoCalculation(CartesianPoint item)
        {
            return _intercept + _slope * item.X;
        }

    }
}
