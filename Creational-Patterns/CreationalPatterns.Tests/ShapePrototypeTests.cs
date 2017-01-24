using CreationalPatterns.Prototype;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.Tests
{
    [TestClass]
    public class ShapePrototypeTests
    {
        [TestMethod]
        public void PrototypeWithFactoryTest()
        {
            var sourceEllipse = new Ellipse()
            {
                UniqueSomethingIWantCloned = 35,
                Width = 10,
                Height = 10
            };
            var sourceQuad = new Quadrilateral()
            {
                UniqueSomethingIWantCloned = 333,
                Width = 20,
                Height = 20
            };
            var prototypeFactory = new ShapePrototypeFactory( sourceEllipse, sourceQuad );

            var prototypedEllipse = prototypeFactory.CreateCircle( 3 );

            Assert.AreEqual( sourceEllipse.UniqueSomethingIWantCloned, 
                             prototypedEllipse.UniqueSomethingIWantCloned );

            Assert.AreNotEqual( sourceEllipse.MinorAxis, prototypedEllipse.MinorAxis );
            Assert.AreNotEqual( sourceEllipse.MajorAxis, prototypedEllipse.MajorAxis );

            var prototypedQuad = prototypeFactory.CreateRectangle( 22, 44 );

            Assert.AreEqual( sourceQuad.UniqueSomethingIWantCloned, 
                             prototypedQuad.UniqueSomethingIWantCloned );

            Assert.AreNotEqual( sourceQuad.Width, prototypedQuad.Width );
            Assert.AreNotEqual( sourceQuad.Height, prototypedQuad.Height );
        }

        [TestMethod]
        public void PrototypeNoFactory()
        {
            var sourceEllipse = new Ellipse()
            {
                UniqueSomethingIWantCloned = 35,
                Width = 10,
                Height = 10
            };

            var prototypedEllipse = sourceEllipse.Clone() as Ellipse;
            prototypedEllipse.Height = prototypedEllipse.Width = 3;

            Assert.AreEqual( sourceEllipse.UniqueSomethingIWantCloned,
                             prototypedEllipse.UniqueSomethingIWantCloned );

            Assert.AreNotEqual( sourceEllipse.MinorAxis, prototypedEllipse.MinorAxis );
            Assert.AreNotEqual( sourceEllipse.MajorAxis, prototypedEllipse.MajorAxis );
        }
    }
}
