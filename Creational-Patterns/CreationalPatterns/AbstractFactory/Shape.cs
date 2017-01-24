using System.Drawing;

namespace CreationalPatterns.AbstractFactory
{
    public abstract class Shape
    {
        public int Sides { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }

        public Shape() { }

        public Shape( int sides )
        {
            Sides = sides;
        }

        public abstract void Draw( Graphics g );
    }

    public class Ellipse : Shape
    {
        public double MajorAxis { get { return Width / 2; } set { Width = value * 2; } }

        public double MinorAxis { get { return Height / 2; } set { Height = value * 2; } }

        public Ellipse() : base( 0 ) { }

        public override void Draw( Graphics g )
        {
            g.FillEllipse( Brushes.Black, new Rectangle( (int)MajorAxis, (int)MinorAxis, (int)Width, (int)Height ) );
        }
    }

    public class Quadrilateral : Shape
    {
        public Quadrilateral() : base( 4 ) { }

        public override void Draw( Graphics g )
        {
            g.FillRectangle( Brushes.Black, new Rectangle( (int)(Width / 2), (int)(Height / 2), (int)Width, (int)Height ) );
        }
    }

}
