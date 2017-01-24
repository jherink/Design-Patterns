using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.AbstractFactory
{
    /// <summary>
    /// Interface for shape factories.
    /// </summary>
    public interface IShapeFactory
    {
        Shape CreateShape();
        Shape CreateShape( double radius ); // radius may be a misleading variable name...
        Shape CreateShape( double width, double height );
    }

    /// <summary>
    /// Factory for creating ellipses.
    /// </summary>
    public class EllipseFactory : IShapeFactory
    {
        public Shape CreateShape()
        {
            return CreateShape( 1 );
        }

        public Shape CreateShape( double radius )
        {
            return new Ellipse
            {
                MajorAxis = radius,
                MinorAxis = radius
            };
        }

        public Shape CreateShape( double width, double height )
        {

            return new Ellipse
            {
                Width = width,
                Height = height
            };
        }

    }

    /// <summary>
    /// Factory for creating quadrilaterals.
    /// </summary>
    public class QuadrilateralFactory : IShapeFactory
    {
        public Shape CreateShape()
        {
            return CreateShape( 1 );
        }

        public Shape CreateShape( double radius )
        {
            return CreateShape( radius, radius );
        }

        public Shape CreateShape( double width, double height )
        {
            return new Quadrilateral
            {
                Width = width,
                Height = height
            };
        }
    }
}
