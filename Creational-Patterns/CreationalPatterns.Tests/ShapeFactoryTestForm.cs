using CreationalPatterns.AbstractFactory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreationalPatterns.Tests
{
    public partial class ShapeFactoryTestForm : Form
    {
        public IShapeFactory Maker = new QuadrilateralFactory();

        public ShapeFactoryTestForm()
        {
            InitializeComponent();
            pictureBox1.Image = new Bitmap( pictureBox1.Width, pictureBox1.Height );
        }

        private void btnGenShape_Click( object sender, EventArgs e )
        {
            var shape = Maker.CreateShape( pictureBox1.Width / 2, pictureBox1.Height / 2 );
            using (var g = Graphics.FromImage( pictureBox1.Image ))
            {

                g.Clear( Color.White );
                shape.Draw( g );
                pictureBox1.Refresh();
            }
            
        }

        private void btnQuadirlateral_CheckedChanged( object sender, EventArgs e )
        {
            if (btnQuadirlateral.Checked)
            {
                Maker = new QuadrilateralFactory();
            }
        }

        private void btnEllipse_CheckedChanged( object sender, EventArgs e )
        {
            if (btnEllipse.Checked)
            {
                Maker = new EllipseFactory();
            }
        }
    }
}
