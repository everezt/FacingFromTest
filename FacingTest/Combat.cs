using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacingTest
{
    public class Combat
    {
        bool IsInRange(int[] xOff, int[] yOff, Navigation.Location attLoc, Navigation.Location defLoc)
        {
            if (xOff.Length != yOff.Length)
            {
                throw new Exception("Arrays are not the same lenght!");
            }

            for (int i = 0; i < xOff.Length; i++)
            {
                if (defLoc.X + xOff[i] == attLoc.X && defLoc.Y + yOff[i] == attLoc.Y)
                {
                    return true;
                }
            }

            return false;
        }


        public Navigation.Direction GetDirection(Npc attacker, Npc defender)
        {


            if (defender.Facing == Navigation.Facing.NorthWest)
            {
                // X: -1 Y = 0 |X: -2 Y = 0 |X: 1 Y = 0 |X: 2 Y = 0 |
                // Sides
                int[] xOffsets = { 1, 2, -1, -2 };
                int[] yOffsets = { 0, 0, 0, 0 };

                if (IsInRange(xOffsets, yOffsets, attacker.Location, defender.Location))
                {
                    return Navigation.Direction.Side;
                }

                // X: 0 Y = -1 |X: 0 Y = -2 |X: -1 Y = -1 |X: -2 Y = -2 |X: 1 Y = -1 |X: 2 Y = -2 |
                // Front
                xOffsets = new int[] { 0, 0, -1, -2, 1, 2 };
                yOffsets = new int[] { -1, -2, -1, -2, -1, -2 };

                if (IsInRange(xOffsets, yOffsets, attacker.Location, defender.Location))
                {
                    return Navigation.Direction.Front;
                }

                // X: -1 Y = 1 |X: -2 Y = 2 |X: 0 Y = 1 |X: 0 Y = 2 |X: 1 Y = 1 |X: 2 Y = 2 |
                // Back
                xOffsets = new int[] { -1, -2, 0, 0, 1, 2 };
                yOffsets = new int[] { 1, 2, 1, 2, 1, 2 };

                if (IsInRange(xOffsets, yOffsets, attacker.Location, defender.Location))
                {
                    return Navigation.Direction.Back;
                }
            }

            if (defender.Facing == Navigation.Facing.SouthWest)
            {
                // X: -1 Y = 0 |X: -2 Y = 0 |X: 1 Y = 0 |X: 2 Y = 0 |
                // Sides
                int[] xOffsets = { 1, 2, -1, -2 };
                int[] yOffsets = { 0, 0, 0, 0 };

                if (IsInRange(xOffsets, yOffsets, attacker.Location, defender.Location))
                {
                    return Navigation.Direction.Side;
                }

                // X: 0 Y = -1 |X: 0 Y = -2 |X: -1 Y = -1 |X: -2 Y = -2 |X: 1 Y = -1 |X: 2 Y = -2 |
                // Back
                xOffsets = new int[] { 0, 0, -1, -2, 1, 2 };
                yOffsets = new int[] { -1, -2, -1, -2, -1, -2 };

                if (IsInRange(xOffsets, yOffsets, attacker.Location, defender.Location))
                {
                    return Navigation.Direction.Back;
                }

                // X: -1 Y = 1 |X: -2 Y = 2 |X: 0 Y = 1 |X: 0 Y = 2 |X: 1 Y = 1 |X: 2 Y = 2 |
                // Front
                xOffsets = new int[] { -1, -2, 0, 0, 1, 2 };
                yOffsets = new int[] { 1, 2, 1, 2, 1, 2 };

                if (IsInRange(xOffsets, yOffsets, attacker.Location, defender.Location))
                {
                    return Navigation.Direction.Front;
                }
            }


            if (defender.Facing == Navigation.Facing.North)
            {
                // X: -1 Y = -1 |X: -2 Y = -2 |X: 1 Y = 1 |X: 2 Y = 2 |
                // sides
                int[] xOffsets = { -1, -2, 1, 2 };
                int[] yOffsets = { -1, -2, 1, 2 };

                if (IsInRange(xOffsets, yOffsets, attacker.Location, defender.Location))
                {
                    return Navigation.Direction.Side;
                }

                // X: 0 Y = -1 |X: 0 Y = -2 |X: 1 Y = -1 |X: 2 Y = -2 |X: 1 Y = 0 |X: 2 Y = 0 |
                // Front
                xOffsets = new int[] { 0, 0, 1, 2, 1, 2 };
                yOffsets = new int[] { -1, -2, -1, -2, 0, 0 };

                if (IsInRange(xOffsets, yOffsets, attacker.Location, defender.Location))
                {
                    return Navigation.Direction.Front;
                }

                // X: -1 Y = 0 |X: -2 Y = 0 |X: -1 Y = 1 |X: -2 Y = 2 |X: 0 Y = 1 |X: 0 Y = 2 |
                // Back
                xOffsets = new int[] { -1, -2, -1, -2, 0, 0};
                yOffsets = new int[] { 0, 0, 1, 2, 1, 2 };

                if (IsInRange(xOffsets, yOffsets, attacker.Location, defender.Location))
                {
                    return Navigation.Direction.Back;
                }

            }

            return Navigation.Direction.Generic;
        }
    }
}
