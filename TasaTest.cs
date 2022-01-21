using System;
using NUnit.Framework;
using TarjetasApp.Helpers;
using TarjetasApp.Models;

namespace TarjetasApp.UnitTest
{
    public class TasaTest
    {
        private ITasaCalculator tasaCalculator;

        [SetUp]
        public void Setup()
        {
            tasaCalculator = new TasaCalculator();
        }

        [Test]
        public void CalcularTasaPorcentual()
        {
            //Arrange
            Marca marca = Marca.SQUA;
            DateTime dateTime = new DateTime(2021, 8, 25);

            //Act
            var rate = tasaCalculator.CalcularTasaPorcentual(marca, dateTime);

            //Assert
            Assert.AreEqual(252.625, rate);
        }

        [Test]
        public void CalcularTasaPorcentual()
        {
            //Arrange
            Marca marca = Marca.SCO;
            DateTime dateTime = new DateTime(2021, 8, 25);

            //Act
            var rate = tasaCalculator.CalcularTasaPorcentual(marca, dateTime);

            //Assert
            Assert.AreEqual(4.0, rate);
        }

        [Test]
        public void CalcularTasaPorcentual()
        {
            //            Arrange
            Marca marca = Marca.PERE;
            DateTime dateTime = new DateTime(2021, 8, 25);

            //                    Act
            var rate = tasaCalculator.CalcularTasaPorcentual(marca, dateTime);

            //                      Assert
            Assert.AreEqual(0.8, rate);
        }
    }
}