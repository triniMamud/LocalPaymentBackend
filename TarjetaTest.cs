using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TarjetasApp.Models;
using TarjetasApp.Helpers;

namespace TarjetasApp.UnitTest
{
    class TarjetaTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void IsTarjetaValid_ReturnsFalseIfOld()
        {
            //Arrange
            var tarjeta = new Tarjeta()
            {
                Vencimiento = DateTime.Today.AddDays(-1)
            };

            //Act
            var isValid = TarjetaHelpers.IsTarjetaValid(tarjeta);


            //Assert
            Assert.False(isValid);
        }
        
        [Test]
        public void AreTarjetasEqual_ReturnsTrueIfSameAttributes()
        {
            //Arrange
            var tarjeta1 = new Tarjeta()
            {
                Marca = Marca.PERE,
                Numero = "00000000",
                Titular = "Alex",
                Vencimiento = new DateTime(2021, 8, 25)
            };

            var tarjeta2 = new Tarjeta()
            {
                Marca = Marca.PERE,
                Numero = "00000000",
                Titular = "Alex",
                Vencimiento = new DateTime(2021, 8, 25)
            };

            //Act
            var areEqual = TarjetaHelpers.AreTarjetasEqual(tarjeta1, tarjeta2);

            //Assert
            Assert.True(areEqual);
        }
    }
}

