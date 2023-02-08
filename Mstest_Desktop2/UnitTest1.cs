using Microsoft.VisualStudio.TestTools.UnitTesting;

using System;

using TypeMock.ArrangeActAssert;

namespace Mstest_Desktop2
{
    [TestClass]
    public class MathTests
    {

        [TestMethod]
        public void IsEvenNum_Test_ReturnsTrue()
        {

            Mathe obj = new Mathe();

            Isolate.WhenCalled(() => obj.IsEvenNum(0)).WillReturn(true);
            // act
            var result = obj.IsEvenNum((8));

            // assert
            Assert.AreEqual(true, result);
        }

    }
    public class Mathe
    {
        int num1;
        int num2;

        public Mathe()
        {
        }
        public bool IsEvenNum(int number)
        {
            var isEven = (number % 2 == 0) ? true : false;
            return isEven;
        }
    }
}
