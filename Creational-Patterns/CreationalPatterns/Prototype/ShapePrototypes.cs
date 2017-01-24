using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.Prototype
{
    /// <summary>
    /// Abstract class for shapes.
    /// </summary>
    public abstract class Shape : IPrototype
    {
        /// <summary>
        /// Something that will be cloned.
        /// </summary>
        public int UniqueSomethingIWantCloned { get; set; }

        /// <summary>
        /// The height of the shape.
        /// </summary>
        public double Height { get; set; }

        /// <summary>
        /// The width of the shape.
        /// </summary>
        public double Width { get; set; }

        /// <summary>
        /// Constructor.
        /// </summary>
        public Shape() { }
        
        /// <summary>
        /// Clone the current shape.
        /// </summary>
        /// <returns>A deeply-cloned shape.</returns>
        public object Clone()
        {
            // All members are primitive types.  This is all that is required for a deep clone.
            return MemberwiseClone();
        }
    }


    /// <summary>
    /// Class representing an ellipse.
    /// </summary>
    public class Ellipse : Shape
    {
        /// <summary>
        /// The ellipse minor axis (y-axis).
        /// </summary>
        public double MinorAxis { get { return Width / 2; } set { Width = value * 2; } }

        /// <summary>
        /// The ellipse major axis (x-axis).
        /// </summary>
        public double MajorAxis { get { return Height / 2; } set { Height = value * 2; } }
        
    }

    /// <summary>
    /// Class representing a quadrilateral.
    /// </summary>
    public class Quadrilateral : Shape
    {   
    }
}
