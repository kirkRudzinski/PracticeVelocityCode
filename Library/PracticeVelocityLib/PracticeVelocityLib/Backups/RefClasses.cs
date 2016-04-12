using PracticeVelocityLib.Global;
using System;
using System.Collections.Generic;

namespace PracticeVelocityLib
{     
    public class Register: Event
    {
        public Dictionary<int, string> conditionalValAndMsg;        

        public Register(int minVal, int maxVal, int startVal)
        {

            if (maxVal > minVal)
            {
                MinVal = minVal;
                MaxVal = maxVal;
            } else
            {
                MinVal = 0;
                MaxVal = 100;
            }
            Counter = (startVal >= MinVal && startVal <= MaxVal) ? startVal : MinVal;
            if (conditionalValAndMsg == null)
                conditionalValAndMsg = new Dictionary<int, string>();

            conditionalValAndMsg.Add(3, "Register");
            conditionalValAndMsg.Add(5, "Patient");
        }

        public override void Add()
        {
            if (Counter < MaxVal)
            {
                Counter += 1;
                CheckMessagesForEvent(Counter);                
            }
                
        }

        public override void Sub()
        {

            if (Counter > MinVal)
            {
                Counter -= 1;
                CheckMessagesForEvent(Counter);
            }            
        }

        public override void Add(int num)
        {
            if (Counter + num <= MaxVal)
            {
                Counter += num;
                CheckMessagesForEvent(Counter);
            }                
        }

        public override void Sub(int num)
        {
            if (Counter - num >= MinVal)
            {
                Counter -= num;
                CheckMessagesForEvent(Counter);
            }                
        }

        /*
        protected override void OnEventUpdate(EventBase e)
        {
            //Any register specific updates go here.
            Console.WriteLine("We got to event update in the child class");
            base.OnEventUpdate(e);
        } */

        public void Loop()
        {
            int startCount = Counter;
            for(var i = startCount; i++ < MaxVal; i++)
            {
                Add();
            }
        }                      

        private void CheckMessagesForEvent(int cntr)
        {            
            bool isInAll = GlobalMethods.CheckIfInAllConditions(cntr, conditionalValAndMsg); 
            int pos = -1;
            if (isInAll == false)
            {
                pos = GlobalMethods.CheckFirstIfInConditions(cntr, conditionalValAndMsg);
            }
            if (isInAll)
                OnEventUpdate(new EventBase(cntr, GlobalMethods.GetCombinedStrFromList(conditionalValAndMsg)));
            else if (pos != -1)
                OnEventUpdate(new EventBase(cntr, conditionalValAndMsg[pos]));
            else
                OnEventUpdate(new EventBase(cntr));

        }
    }

    
}
