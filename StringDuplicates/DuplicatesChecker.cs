using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringDuplicates
{
    internal class DuplicatesChecker
    {
        public static bool CheckForDuplicates(string data)
        {
            Hashtable hashtable = new Hashtable();

            int index = 0;

            foreach (char symbol in data)
            {
                try
                {
                    hashtable.Add(symbol, index);
                }
                catch
                {
                    Console.WriteLine($"An element with Key = {symbol} already exists.");
                    return true;
                }

                index++;
            }

            return false;
        }
    }
}
