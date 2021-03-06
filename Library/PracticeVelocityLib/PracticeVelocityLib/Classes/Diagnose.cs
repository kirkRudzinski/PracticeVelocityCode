﻿using PracticeVelocityLib.Global;
using System;
using System.Collections.Generic;

namespace PracticeVelocityLib.Classes
{
    public class Diagnose : Event
    {
        public Dictionary<int, string> conditionalValAndMsg;

        public Diagnose(int minVal = Constants.DEFAULT_MIN_START, int maxVal = Constants.DEFAULT_MAX_START, int startVal = Constants.DEFAULT_MIN_START)
        {

            if (maxVal > minVal)
            {
                MinVal = minVal;
                MaxVal = maxVal;
            }
            else
            {
                MinVal = Constants.DEFAULT_MIN_START;
                MaxVal = Constants.DEFAULT_MAX_START;
            }
            Counter = (startVal >= MinVal && startVal <= MaxVal) ? startVal : MinVal;
            if (conditionalValAndMsg == null)
                conditionalValAndMsg = new Dictionary<int, string>();

            conditionalValAndMsg.Add(2, Constants.DEFAULT_DIAGNOSE_STR);
            conditionalValAndMsg.Add(7, Constants.DEFAULT_PATIENT_STR);
        }

        public override void Add()
        {
            if (Counter < MaxVal)
            {
                Counter++;
                CheckMessagesForEvent(Counter);
            }

        }

        public override void Sub()
        {

            if (Counter > MinVal)
            {
                Counter--;
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

        public override int GetMinVal()
        {
            return MinVal;
        }

        public override int GetMaxVal()
        {
            return MaxVal;
        }
        
        public override int GetCounter()
        {
            return Counter;
        }

        protected override void OnEventUpdate(EventBase e)
        {            
            LastMessage = e.Message;
            base.OnEventUpdate(e);
        } 

        public void Loop()
        {
            int startCount = Counter;
            for (var i = startCount; i++ < MaxVal; i++)
            {
                Add();
            }
        }

        public override string GetLastMessage()
        {
            return LastMessage;
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
