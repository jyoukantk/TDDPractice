using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TDDPractice.Tests
{
    [TestClass]
    public class FizzBuzzTest
    {
        FizzBuzz _fizzBuzz;

        [TestInitialize]
        public void Setup()
        {
            _fizzBuzz = new FizzBuzz();
        }

        [TestMethod]
        public void _3の倍数のときはFizz()
        {
            //var fizzBuzz = new FizzBuzz();
            Assert.AreEqual("Fizz", _fizzBuzz.ConvertString(3));
            Assert.AreEqual("Fizz", _fizzBuzz.ConvertString(6));
        }

        [TestMethod]
        public void _5の倍数のときはBuzz()
        {
            //var fizzBuzz = new FizzBuzz();
            Assert.AreEqual("Buzz", _fizzBuzz.ConvertString(5));
            Assert.AreEqual("Buzz", _fizzBuzz.ConvertString(10));
        }

        [TestMethod]
        public void それ以外の数値の場合は文字列に変換()
        {
            //var fizzBuzz = new FizzBuzz();
            Assert.AreEqual("1", _fizzBuzz.ConvertString(1));
        }

        //[TestMethod]
        //public void _2の場合は2()
        //{
        //    //var fizzBuzz = new FizzBuzz();
        //    Assert.AreEqual("2", _fizzBuzz.ConvertString(2));
        //}



        [TestMethod]
        public void _0以下の場合は例外()
        {
            Assert.ThrowsException<ArgumentException>(() =>
            {
                var fizzBuzz = new FizzBuzz();
                fizzBuzz.ConvertString(0);
            }, "0はNG");
            //try
            //{
            //    Assert.AreEqual("エラー", _fizzBuzz.ConvertString(0));
            //    Assert.Fail("例外が発生しない");
            //}
            //catch (Exception ex)
            //{

            //}
        }

        //[TestMethod]
        //public void TestSample()
        //{
        //    int i = 1;
        //    Assert.AreEqual(1, i);
        //}


    }
}
