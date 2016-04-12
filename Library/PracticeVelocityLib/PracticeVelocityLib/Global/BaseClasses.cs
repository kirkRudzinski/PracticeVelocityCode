using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeVelocityLib.Global
{
    public class EventBase : EventArgs
    {
        private int _counter;
        private string _message;
        private const string DEFAULT_MSG = "The value of the number is: ";
        public EventBase(int num, string msg = DEFAULT_MSG)
        {
            _counter = num;
            _message = (msg != DEFAULT_MSG) ? msg : msg + num;
        }
        public int Counter
        {
            get { return _counter; }
        }
        public string Message
        {
            get { return _message; }
        }
    }

    public abstract class Event
    {
        public int Counter { get; set; }
        protected int MinVal { get; set; }
        protected int MaxVal { get; set; }
        protected string LastMessage { get; set; }
        public event EventHandler<EventBase> EventUpdated;

        public abstract void Add();
        public abstract void Sub();
        public abstract void Add(int num);
        public abstract void Sub(int num);
        public abstract string GetLastMessage();
        public abstract int GetMinVal();
        public abstract int GetMaxVal();
        public abstract int GetCounter();
        protected virtual void OnEventUpdate(EventBase e)
        {
            EventHandler<EventBase> handler = EventUpdated;
            if (handler != null)
                handler(this, e);
        }

    }    
}
