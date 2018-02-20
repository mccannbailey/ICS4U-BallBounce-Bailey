using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BallBounce_Bailey
{
    class Ball
    {
        public int x, y, size, xSpeed, ySpeed;
        Color Colour;

        public Ball(int _x, int _y, int _size, int _xSpeed, int _ySpeed, Color _colour)
        {
            x = _x;
            y = _y;
            size = _size;
            xSpeed = _xSpeed;
            ySpeed = _ySpeed;
            Colour = _colour;
        }
    }
}
