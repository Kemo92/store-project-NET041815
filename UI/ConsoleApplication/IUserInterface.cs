using StoreProject.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StoreProject.UI.ConsoleApplication
{
    public interface IUserInterface
    {
        void WriteLine();

        void WriteLine(object value);

        void WriteLine(string formatString, params object[] values);

        string GetChoice();

        void Clear();
    }
}
