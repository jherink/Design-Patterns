using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.Builder
{
    /****
     * 
     * Please note this is a VERY simple example of a builder.
     * A more realistic application would be something that 
     * builds a formatted document like XML, HTML, or one that 
     * helps build strings like .NETs StringBuilder class.
     * 
     * */

    /// <summary>
    /// Class for building even numbered sequences.
    /// </summary>
    public class EvenNumberSequenceBuilder 
    {
        // The sequence.  Use an array to emphasize builder functionality.
        private int[] _sequence = new int[0];

        private int Length { get { return _sequence.Length; } }

        /// <summary>
        /// Add a number to the sequence.
        /// </summary>
        /// <param name="n"></param>
        public void Add( int n )
        {
            // The business logic used when building the sequence 
            // is that it ensures that _sequence is the appropriate size
            // and that it n is even. If it isn't then it makes it even.
            // It also checks to see if the number is in the sequence and it
            // will sort the new sequence once added.

            if (n % 2 != 0)
            {
                n += (n % 2) - 2;
            }
            if (!_sequence.Contains( n ))
            {
                EnsureSequenceSize( Length + 1 );
                _sequence[Length - 1] = n;
                _sequence = _sequence.OrderBy( t => t ).ToArray();
            }
        }

        /// <summary>
        /// Get the generated sequence.  A "final product" of the builder.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<int> GetSequence() { return _sequence.Select( t => t ); }

        private void EnsureSequenceSize( int newSize )
        {
            if (Length <= newSize)
            {
                Array.Resize( ref _sequence, newSize );
            }
        }

    }
}
