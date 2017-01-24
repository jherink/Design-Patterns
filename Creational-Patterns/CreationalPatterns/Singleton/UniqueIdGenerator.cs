using System;

namespace CreationalPatterns.Singleton
{
    public class UniqueIdGenerator
    {
        /// <summary>
        /// ID identifier assigned at creation time to show
        /// that "this" same object is being reused in all "Inst" calls.
        /// </summary>
        public readonly Guid ID = Guid.NewGuid();
        private int _currentID = 1; // private flag identifier.

        #region Singleton Implementation 

        // The private instance only this class is allowed access to.
        private static UniqueIdGenerator _inst;

        public static UniqueIdGenerator Inst
        {
            get
            {
                // check if one has been initialized.  If not create it before returning.
                if (_inst == null) _inst = new UniqueIdGenerator();
                return _inst;
            }
        }

        // a private constructor prevents creation outside of this class.
        private UniqueIdGenerator() { }

        #endregion

        public int GetID() { return _currentID++; } // return and increment

        public void Reset() { _currentID = 1; } // for demo purposes
    }

    public class ThreadSafeUniqueIdGenerator
    {
        public readonly Guid ID = Guid.NewGuid();
        private int _currentID = 1;
        private object _padlock = new object();

        #region Singleton Implementation 

        // The private instance only this class is allowed access to.
        private static ThreadSafeUniqueIdGenerator _inst;

        public static ThreadSafeUniqueIdGenerator Inst
        {
            get
            {
                // check if one has been initialized.  If not create it before returning.
                if (_inst == null) _inst = new ThreadSafeUniqueIdGenerator();
                return _inst;
            }
        }

        // a private constructor prevents creation outside of this class.
        private ThreadSafeUniqueIdGenerator() { }

        #endregion

        public int GetID()
        {
            var id = 0;
            lock (_padlock)
            { // acquire lock while modifying data.
                id = _currentID++;
                System.Threading.Monitor.PulseAll( _padlock );
            }
            return id;
        }

        public void Reset() {
            lock (_padlock)
            {
                _currentID = 1;
                System.Threading.Monitor.Pulse( _padlock );
            }
        } // for demo purposes
    }
}
