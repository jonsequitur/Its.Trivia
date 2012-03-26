using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace Its.Trivia
{
    [TestClass, TestFixture]
    public class WhoDoesTheCompilerChoose
    {
        [Test, TestMethod, Owner("josequ")]
        public void Generic_overloads()
        {
            Please.ChooseMe(new Option());
            Please.ChooseMe(new Option<string>());
        }

        [Test, TestMethod, Owner("josequ")]
        public void Optional_versus_params()
        {
            Please.ChooseMe();
        }
    }

    public static class Please
    {
        public static void ChooseMe<T>(T option)
        {
            Console.WriteLine("ChooseMe<T>");
        }

        public static void ChooseMe<T>(Option<T> option)
        {
            Console.WriteLine("ChooseMe<Option<T>>");
        }

        public static void ChooseMe(object option)
        {
            Console.WriteLine("ChooseMe(object option)");
        }

        public static void ChooseMe(bool really = true)
        {
            Console.WriteLine("ChooseMe(bool really = true)");
        }

        public static void ChooseMe(params string[] options)
        {
            Console.WriteLine("ChooseMe(params string[] options)");
        }
    }

    public class Option
    {
    }

    public class Option<T> : Option
    {
    }
}