using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TarjetasApp.Helpers;
using TarjetasApp.Models;

namespace TarjetasApp.UnitTest
{
    class TransactionTest
    {
        public void Setup()
        {
        }

        [Test]
        public void IsTransactionValid_TrueFor99()
        {
            //Arrange
            var amount = 99;

            //Act
            var isValid = TransactionHelpers.IsTransactionValid(amount);

            //Assert
            Assert.IsTrue(isValid);
        }
    }
}
