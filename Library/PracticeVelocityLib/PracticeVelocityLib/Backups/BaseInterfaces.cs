using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeVelocityLib
{
    public interface IInterfaceMethods
    {
        void Add();
        void Sub();
        void Add(int num);
        void Sub(int num);
        void Loop();
    }

    public interface IEventFired
    {
        event EventHandler OnAddEvent;
        event EventHandler OnSubEvent;
    }
}
