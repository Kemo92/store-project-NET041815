using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StoreProject.UI.ConsoleApplication
{
    class ConsoleUserInterface : IUserInterface
    {
        public void WriteLine()
        {
            Console.WriteLine();
        }

        public void WriteLine(object value)
        {
            Console.WriteLine(value);
        }

        public void WriteLine(string formatString, params object[] values)
        {
            Console.WriteLine(formatString, values);
        }

        public string GetChoice()
        {
            return Console.ReadLine().Trim().ToLower();
        }

        public void Clear()
        {
            Console.Clear();
        }
    }
}
