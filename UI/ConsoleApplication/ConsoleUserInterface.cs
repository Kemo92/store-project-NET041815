using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StoreProject.UI.ConsoleApplication
{
    class ConsoleUserInterface : IUserInterface
    {
        public void WriteLine(object value)
        {
            Console.WriteLine(value);
        }
    }
}
