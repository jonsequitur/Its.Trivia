using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace Its.Trivia
{
    [TestClass, TestFixture]
    public class Exceptions
    {
        [Test, TestMethod, Owner("josequ")]
        public void What_is_returned()
        {
            Console.WriteLine(ReturnsWhat());
        }

        [Test, TestMethod, Owner("josequ")]
        public void What_is_thrown()
        {
            ThrowsWhat();
        }

        private void ThrowsWhat()
        {
            try
            {
                throw new Exception("one");
            }
            catch
            {
                throw new Exception("two");
            }
            finally
            {
                throw new Exception("three");
            }
        }
        
        private string ReturnsWhat()
        {
            string returnValue;
            try
            {
                throw new Exception("one");
            }
            catch
            {
                return "catch";
            }
            finally
            {
                returnValue = "finally";
            }

            return returnValue;
        }
    }
}