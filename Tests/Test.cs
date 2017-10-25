using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WpfApp1;

namespace Tests
{
    [TestClass]
    public class Test
    {
        [TestMethod]
        public void PridictTest()
        {
            //Assemble
            var actual = Tesztelesre.Predict(1, 100, 1000);

            //act
            var expected = -800;

            //Assert

            Assert.AreEqual(expected, actual);

        }
    }
}
