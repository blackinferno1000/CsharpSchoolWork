using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE21
{
    interface IPosition
    {
        int X { get; }
        int Y { get; }
        void ChangeXPosition(int x);
        void ChangeYPosition(int y);
        void ChangePosition(int x, int y);
    }
}
