﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicQueuingMachine
{
    internal class CashierClass
    {
        private int x;
        public static string getNumberInqueue = "";
        public static Queue<string> CashierQueue;
        public CashierClass()
        {
            x = 1000;
            CashierQueue = new Queue<string>();
        }
        public string CashierGeneratedNumber(string CashierNumber)
        {
            x++;
            CashierNumber = CashierNumber + x.ToString();
            return CashierNumber;
        }
    }
}
