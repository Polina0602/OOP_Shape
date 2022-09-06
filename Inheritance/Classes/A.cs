using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Classes
{
    public class A
    {
        int a = 3;
        int b = 4;

        public virtual int GetNum()
        {
            Console.WriteLine(a);
            return b;
        }

        public virtual string GetString()
        {
            string str = "Hello";
            Console.WriteLine(str);
            return str;
        }
    }
}
