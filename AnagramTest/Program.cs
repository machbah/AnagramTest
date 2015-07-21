using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnagramTest
{
    class Program
    {
                
        static void Main(string[] args)
        {
            Dictionary<string, string> first = new Dictionary<string, string>();

            for (int i = 0; i < 100; i++)
            {
                first.Add(i.ToString(), i.ToString());
            }
        }
    }
}
