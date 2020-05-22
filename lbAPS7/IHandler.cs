using System;
using System.Collections.Generic;
using System.Text;

namespace lbAPS7
{
    interface IHandler
    {
        IHandler SetNext(IHandler handler);

        float Handle(float request);
    }
}
