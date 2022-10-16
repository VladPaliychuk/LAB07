using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4
{
    internal class Smartphone : IToVisit, IToCall
    {
        #region BoolMethods
        bool LetterContains(string str)
        {
            for(int i = 0; i < str.Length; i++)
            {
                if (Char.IsLetter(str[i])) { return true; }
            }
            return false;
        }
        bool NumContains(string str)
        {
            for(int i=0; i < str.Length; i++)
            {
                if (Char.IsNumber(str[i])) { return true; }
            }
            return false;
        }
        #endregion

        string info;
        public Smartphone(string info)
        {
            this.info = info;
        }
        public string Call(string number)
        {
            if (LetterContains(number) == true)
            {
                throw new ArgumentException("Invalid number");
            }
            else
            {
                return "Calling..." + number;
            }
        }

        public string Visit(string web)
        {
            if(NumContains(web) == true)
            {
                throw new ArgumentException("Invalid URL");
            }
            else
            {
                return "Browsing..." + web;
            }
        }
    }
}
