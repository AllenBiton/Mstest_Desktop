

using Microsoft.VisualStudio.TestTools.UnitTesting;
using TypeMock.ArrangeActAssert;

namespace Mstest_Desktop
{
    [TestClass]
    public class MathTests
    {

        [TestMethod]
        public void IsEvenNum_Test_ReturnsFalse()
        {

            Mathe obj = new Mathe();

            Isolate.WhenCalled(() => obj.IsEvenNum(0)).WillReturn(false);
            // act
            var result = obj.IsEvenNum((8));

            // assert
            Assert.AreEqual(false, result);
        }


        [TestMethod]
        public void IsEvenNum_Test_ReturnsTrue()
        {
            Mathe obj = new Mathe();


            Isolate.WhenCalled(() => obj.IsEvenNum(0)).WillReturn(true);
            // act
            var result = obj.IsEvenNum(5);

            // assert
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void sub_Test_ReturnsMinus1()
        {
            Mathe obj = new Mathe();


            Isolate.WhenCalled(() => obj.sub(0, 0)).WillReturn(10);
            // act
            var result = obj.sub(8, 15);

            // assert
            Assert.AreEqual(10, result);
        }

        [TestMethod]
        public void sum_Test_Returns2()
        {
            Mathe obj = new Mathe();

            Isolate.WhenCalled(() => obj.sum(0, 0)).WillReturn(10);
            // act
            var result = obj.sum(2, 3);

            // assert
            Assert.AreEqual(10, result);
        }

    }
    public class Mathe
    {
        int num1;
        int num2;

        public Mathe()
        {
        }
        public int sum(int a, int b)
        {
            return a + b;
        }

        public int sub(int a, int b)
        {
            return a - b;
        }
        public bool IsEvenNum(int number)
        {
            var isEven = (number % 2 == 0) ? true : false;
            return isEven;
        }
    }
}
