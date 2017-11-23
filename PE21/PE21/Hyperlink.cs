using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE21
{
    class Hyperlink:IPosition,ILink
    {
        private int x;
        private int y;
        private string link;
        private string text;

        public Hyperlink(string tx,string lin,int x,int y)
        {
            this.x = x;
            this.y = y;
            link = lin;
            text = tx;
        }

        public int X { get { return x; } }
        public int Y { get { return y; } }
        public string LinkAddress { get { return link; } }

        public void ChangeLinkAddress(string add)
        {
            link = add;
        }

        public void ChangeXPosition(int x)
        {
            this.x = x;
        }
        public void ChangeYPosition(int y)
        {
            this.y = y;
        }
        public void ChangePosition(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
