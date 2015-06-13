using StoreProject.UI.ConsoleApplication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StoreProject.ConsoleApplication.Tests
{
    class StringListUserInterface : IUserInterface
    {
        public StringListUserInterface()
        {
            Lines = new List<string>();
        }

        public void WriteLine(object value)
        {
            Lines.Add(value.ToString());
        }

        public List<string> Lines { get; set; }

        public void WriteLine(string formatString, params object[] values)
        {
            throw new NotImplementedException();
        }

        public string GetChoice()
        {
            throw new NotImplementedException();
        }

        public void WriteLine()
        {
            throw new NotImplementedException();
        }


        public void Clear()
        {
            throw new NotImplementedException();
        }
    }
}
