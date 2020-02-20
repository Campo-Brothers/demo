using System;
using FakeItEasy;
using FluentAssertions;
using ImagicleLibrary.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        private ILoggerFactory _loggerFactory;
        [SetUp]
        public void Setup()
        {
            _loggerFactory = A.Fake<ILoggerFactory>();
            int a = 0;
        }

        [Test]
        public void IfFunziona_then_deveUscire1() => A.CallTo(() => _loggerFactory.GetLogger()).Returns(null);
    }
}
