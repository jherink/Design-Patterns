using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CreationalPatterns.Builder;
using System.Collections.Generic;
using System.Linq;

namespace CreationalPatterns.Tests
{
    [TestClass]
    public class BuilderTests
    {
        [TestMethod]
        public void SimpleSequenceTest()
        {
            var sequence = new EvenNumberSequenceBuilder();
            sequence.Add( 0 );
            sequence.Add( 2 );
            sequence.Add( 4 );
            sequence.Add( 6 );
            sequence.Add( 3 );


            AssertSequenceContains( sequence, 0, 2, 4, 6 );
        }

        [TestMethod]
        public void UnorderdSequenceTest()
        {
            var sequence = new EvenNumberSequenceBuilder();
            sequence.Add( 5 );
            sequence.Add( 11 );
            sequence.Add( 2 );
            sequence.Add( 4 );
            sequence.Add( 7 );

            AssertSequenceContains( sequence, 2, 4, 6, 10 );
        }

        private void AssertSequenceContains( EvenNumberSequenceBuilder sequence, params int[] orderedContents )
        {
            var s = sequence.GetSequence();
            Assert.AreEqual( orderedContents.Length, s.Count() );
            for (int i = 0; i < orderedContents.Length; i++)
            {
                Assert.AreEqual( orderedContents[i], s.ElementAt(i));
            }
        }
    }
}
