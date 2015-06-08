using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankKata
{
    public interface IConsole
    {
        string Out { get;}

        void WriteLine(string str);
    }

    public class Console : IConsole
    {
        public string Out { get; set; }

        public void WriteLine(string str)
        {
            Out += str + Environment.NewLine;
        }
    }
}
