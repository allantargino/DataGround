using DataGround.Core.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace DataGround.Tests
{
    [TestClass]
    public class AccuracyTests
    {
        [TestMethod]
        public void Accuracy()
        {
            // obtem dados iniciais
            var points = new List<CartesianPoint>
            {
                new CartesianPoint(0, 0),
                new CartesianPoint(25, 25),
                new CartesianPoint(50, 50),
                new CartesianPoint(100, 100)
            };
            var input = new CartesianInput(points);

            // usando uma regressao linear pelo metodo dos minimos quadrados
            var trainer = new LinearRegressionTrainer(iterations: 5);

            // treina modelo
            var model = trainer.TrainAsync(input).Result;

            // usa um preditor
            var predictor = new LinearRegressionPredictor();
            predictor.Init(model);

            // calculando o output com os dados iniciais
            var output = predictor.ComputeAsync(input).Result;
        }
    }
}
