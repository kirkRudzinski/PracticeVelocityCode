using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeVelocityLib.Global
{
    public static class GlobalMethods
    {
        public static int CheckFirstIfInConditions(int newNum, Dictionary<int, string> lst)
        {
            int retPos = -1;
            if (lst != null)
            {
                for (int i = 0; i < lst.Keys.Count; i++)
                {
                    if (newNum % lst.Keys.ElementAt(i) == 0)
                    {
                        retPos = lst.Keys.ElementAt(i);
                        i = lst.Keys.Count;
                    }
                }                
            }
            return retPos;
        }

        public static bool CheckIfInAllConditions(int newNum, Dictionary<int, string> lst)
        {            
            bool retBool = (lst != null)? (lst.Count >=0): false;            
            if (retBool)
            {
                for (int i = 0; i < lst.Keys.Count ; i++)
                {                    
                    if (newNum % lst.Keys.ElementAt(i) != 0)
                        retBool = false;

                }
            }           
            return retBool;
        }

        public static string GetCombinedStrFromList(Dictionary<int, string> lst)
        {
            string retStr = "";
            if ((lst != null)? (lst.Count >= 0): false)
            {              
                for (int i = 0; i < lst.Count; i++)
                {
                    retStr += lst[lst.Keys.ElementAt(i)] + " ";
                }
                if (retStr != "")
                {
                    retStr = retStr.Substring(0, retStr.Length - 1);
                }                               
            }
            return retStr;
        }

        public static void AddConditionalValue(int num, string msg, Dictionary<int, string> lst)
        {
            if (lst == null)
                lst = new Dictionary<int, string>();
            if (num != 0 && msg != "")
                lst.Add(num, msg);
        }

        public static bool RemoveConditionalValue(int num, Dictionary<int, string> lst)
        {                       
            return (lst != null) ? lst.Remove(num) : false; ;
        }
            

    }
}
