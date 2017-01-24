using System;
using System.Collections.Generic;

namespace CreationalPatterns.Factory
{
    /// <summary>
    /// Interface for identifiable objects.
    /// </summary>
    public interface IIdentifiable
    {
        int ID { get; set; }

    }

    public class IDFactory
    {
        public readonly Guid FactoryID = Guid.NewGuid();

        private HashSet<int> _ids = new HashSet<int>();

        private object _padlock = new object();

        #region Singleton Implementation

        private static IDFactory _inst = new IDFactory();

        public static IDFactory Inst { get { return _inst; } }

        protected IDFactory() { }

        #endregion

        public int GetID()
        {
            var id = -1;
            var rand = new Random();
            lock (_padlock)
            {
                do
                {
                    id = rand.Next( 1, 1000 );
                }
                while (_ids.Contains( id ));
                _ids.Add( id );

                System.Threading.Monitor.PulseAll( _padlock );
            }
            return id;
        }
    }

    /****
     * 
     * The below two factories exist to create new 
     * SomethingCoolA and SomethingCoolB objects depending on
     * the factory used.  
     * 
     * This example is to show the abstract factory used as a 
     * base class rather than an interface implementation.  
     * That is why there is a protected factory instance that references
     * the IDFactory.Inst value.
     * 
     * Otherwise the base functionality could be contracted in an interface 
     * similar to IShapeFactory used in the Abstract Factory example. 
     * 
     * 
     * *****/

    /// <summary>
    /// Base abstract class for identifiable factories.
    /// </summary>
    public abstract class IdentifiableSomethingsFactory
    {
        protected IDFactory FactoryInst = IDFactory.Inst;

        public abstract IIdentifiable Create();
    }

    /// <summary>
    /// Factory for creating SomethingCoolA identifiable objects.
    /// </summary>
    public class IdentifiableSomethingsFactoryA : IdentifiableSomethingsFactory
    {
        public override IIdentifiable Create()
        {
            return new SomethingCoolA() { ID = FactoryInst.GetID() };
        }
    }

    /// <summary>
    /// Factory for creating SomethingCoolB identifiable objects.
    /// </summary>
    public class IdentifiableSomethingsFactoryB : IdentifiableSomethingsFactory
    {
        public override IIdentifiable Create()
        {
            return new SomethingCoolB() { ID = FactoryInst.GetID() };
        }
    }
}
