using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE21
{
    class Button : IPosition,ITextButton
    {
        private int x;
        private int y;
        private int width;
        private int height;
        private string text;

        public Button(string tx,int x,int y,int wid,int hei)
        {
            this.x = x;
            this.y = y;
            text = tx;
            width = wid;
            height = hei;
        }

        public int X { get { return x; } }
        public int Y { get { return y; } }
        public int ButtonWidth { get { return width; } }
        public int ButtonHeight { get { return height; } }
        public string ButtonText { get { return text; } }

        public void ChangeXPosition(int x)
        {
            this.x = x;
        }
        public void ChangeYPosition(int y)
        {
            this.y = y;
        }
        public void ChangePosition(int x,int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
