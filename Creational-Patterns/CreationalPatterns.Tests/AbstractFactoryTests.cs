using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CreationalPatterns.AbstractFactory;
using System.Windows.Forms;

namespace CreationalPatterns.Tests
{
    [TestClass]
    public class AbstractFactoryTests
    {
        [TestMethod]
        public void OpenTestForm()
        {
            using (var f = new ShapeFactoryTestForm())
            {
                f.ShowInTaskbar = false;
                f.ShowDialog();
            }
        }
    }
}
