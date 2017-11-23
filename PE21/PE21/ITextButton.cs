using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE21
{
    interface ITextButton
    {
        int ButtonWidth { get; }
        int ButtonHeight { get; }
        string ButtonText { get; }
    }
}
