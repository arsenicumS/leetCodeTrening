using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;

namespace leetCodeTrening
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Easy easy = new Easy();
            Console.WriteLine(easy.IsValid("{(]}"));
        }
    }
}
