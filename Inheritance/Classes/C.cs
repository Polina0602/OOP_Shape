using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Classes
{
    public class C : B
    {
        int a = 7;
        int b = 8;

        public override int GetNum() 
        {
            Console.WriteLine(base.GetNum() + a);
            return base.GetNum() + a;
            //Console.WriteLine(a);
            //return b;
        }
        public string GetString() 
        {
            string str = $"{base.GetString()} Nice to meet you!";
            Console.WriteLine(str);
            return str;
        }

    }
}
