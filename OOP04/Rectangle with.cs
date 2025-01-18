using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP04
{
    internal class Rectangle
    {
        #region Filed
        public int Width { get; set; }
        public int Height { get; set; }

        #endregion

        #region Constructor
        public Rectangle()
        {
            Width = 0;
            Height = 0;
        }
        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }
        public Rectangle(int num)
        {
            Width = num;
            Height = num;
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"Width: {Width}, Height: {Height}";
        }
        #endregion

    }
}
