using CreationalPatterns.Factory;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.Tests
{
    [TestClass]
    public class IDFactoryTests
    {
        [TestMethod]
        public void GetIds()
        {
            var idA = IDFactory.Inst.GetID();
            var idB = IDFactory.Inst.GetID();
            Assert.AreNotEqual( idA, idB );
        }

        [TestMethod]
        public void FactoryAvsFactoryB()
        {
            var factoryA = new IdentifiableSomethingsFactoryA();
            var factoryB = new IdentifiableSomethingsFactoryB();
            var objA = factoryA.Create();
            var objB = factoryB.Create();

            Assert.AreNotSame( objA.GetType(), objB.GetType() );
            Assert.AreNotSame( objA.ID, objB.ID );
            
        }
    }
}
