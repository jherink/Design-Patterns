using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.Prototype
{
    // prototype is basically ICloneable in terms of exposed 
    // functionality.  IPrototype is just for example purposes here.
    public interface IPrototype : ICloneable { }

    public class ShapePrototypeFactory
    {
        /// <summary>
        /// Prototype object to use when creating a cloned ellipse.
        /// </summary>
        private Ellipse EllipsePrototype;

        /// <summary>
        /// Prototype object to use when creating a quadrilateral prototype.
        /// </summary>
        private Quadrilateral QuadrilateralPrototype;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="ellipse">The ellipse prototype.</param>
        /// <param name="quad">The quadrilateral prototype.</param>
        public ShapePrototypeFactory( Ellipse ellipse, Quadrilateral quad )
        {
            EllipsePrototype = ellipse;
            QuadrilateralPrototype = quad;
        }

        /// <summary>
        /// Create a circle.
        /// </summary>
        /// <param name="radius">The radius of the circle.</param>
        /// <returns>A new circle at the given radius</returns>
        public Ellipse CreateCircle( double radius )
        {
            // use the passed in ellipse prototype as a starting
            // point for creating the new circle.
            var clone = (Ellipse)EllipsePrototype.Clone();

            // It is a circle -> major & minor axis are the same.
            clone.MajorAxis = clone.MinorAxis = radius;

            return clone; // return the new ellipse.
        }

        /// <summary>
        /// Create a square.
        /// </summary>
        /// <param name="width">The width of the square.</param>
        /// <returns>A new square with the given height & width.</returns>
        public Quadrilateral CreateSquare( double width )
        {
            // use the passed in quadrilateral prototype as a starting
            // point for creating a new quadrilateral.
            var clone = (Quadrilateral)QuadrilateralPrototype.Clone();

            // It is a square -> height & width are the same.
            clone.Height = clone.Width = width;

            return clone; // return the new square.
        }

        /// <summary>
        /// Create an ellipse.
        /// </summary>
        /// <param name="majorAxis"></param>
        /// <param name="minorAxis"></param>
        /// <returns>Thew new ellipse with specified major minor axis.</returns>
        public Ellipse CreateEllipse( double majorAxis, double minorAxis )
        {
            var clone = (Ellipse)EllipsePrototype.Clone();
            clone.MinorAxis = minorAxis;
            clone.MajorAxis = majorAxis;

            return clone;
        }

        /// <summary>
        /// Create a rectangle.
        /// </summary>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <returns></returns>
        public Quadrilateral CreateRectangle( double width, double height )
        {
            var clone = (Quadrilateral)QuadrilateralPrototype.Clone();
            clone.Width = width;
            clone.Height = height;

            return clone;

        }
    }
}
