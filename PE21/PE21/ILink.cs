using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE21
{
    interface ILink
    {
        string LinkAddress { get; }
        void ChangeLinkAddress(string linkAddress);
    }
}
