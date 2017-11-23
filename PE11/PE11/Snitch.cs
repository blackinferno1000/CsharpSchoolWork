using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE11
{
    class Snitch
    {
        private bool inBox;
        private bool isCaught;

        public bool InBox
        {
            get { return inBox; }
        }

        public bool IsCaught
        {
            get { return isCaught; }
        }

        public Snitch()
        {
            inBox = true;
            isCaught = false;
        }

        public void ReleaseFromBox()
        {
            Console.WriteLine("Snitch released");
            inBox = false;
        }

        public void CaughtBySeeker()
        {
            Console.WriteLine("Snitch caught");
            isCaught = true;
        }

        public void PlaceInBox()
        {
            Console.WriteLine("Snitch placed in box");
            inBox = true;
            isCaught = false;
        }
    }
}
