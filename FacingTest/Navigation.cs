using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacingTest
{
    public static class Navigation
    {
        public enum Facing
        {
            North,
            NorthEast,
            East,
            SouthEast,
            South,
            SouthWest,
            West,
            NorthWest
        }

        public struct Location
        {
            public int X;
            public int Y;
        }

        public enum Direction
        {
            Front,
            Back,
            Side,
            Generic
        }
    }
}
