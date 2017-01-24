using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CreationalPatterns.Singleton;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace CreationalPatterns.Tests
{
    [TestClass]
    public class SingletonTests
    {
        [TestMethod]
        public void GetIDs()
        {
            UniqueIdGenerator.Inst.Reset();
            for (int i = 1; i < 50; i++)
            {
                var fetchedId = UniqueIdGenerator.Inst.GetID();
                Assert.AreEqual( i, fetchedId );
            }
        }

        [TestMethod]
        public void MultiThreadGetIdFail()
        {
            UniqueIdGenerator.Inst.Reset();
            var tasks = new List<Task>();
            var ids = new List<int>();
            for (int i = 1; i < 50; i++)
            {
                tasks.Add( Task.Factory.StartNew( () => ids.Add( UniqueIdGenerator.Inst.GetID() ) ) );
            }

            Task.WaitAll( tasks.ToArray() );
            // break here and see the results.
            var toSort = ids.OrderBy( t => t ).ToArray(); // create new, sorted, list to sort
        }

        [TestMethod]
        public void MultiThreadGetIdThreadSafe()
        {
            ThreadSafeUniqueIdGenerator.Inst.Reset();
            var tasks = new List<Task>();
            var ids = new List<int>();
            for (int i = 1; i < 50; i++)
            {
                tasks.Add( Task.Factory.StartNew( () =>
                {
                    tasks.Add( Task.Factory.StartNew( () => ids.Add( ThreadSafeUniqueIdGenerator.Inst.GetID() ) ) );
                    
                } ) );
            }

            Task.WaitAll( tasks.ToArray() );
            // break here and see the results.
            var toSort = ids.OrderBy( t => t ).ToArray(); // create new, sorted, list to sort            
        }
    }
}
