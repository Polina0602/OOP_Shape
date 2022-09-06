using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Classes
{
    public class B : A
    {
        int a = 5;
        int b = 6;

        public override int GetNum()
        {
            Console.WriteLine(a);
            return b;
        }

        public override string GetString()
        {
            string str = $"{base.GetString()}  my Friend!";
            Console.WriteLine(str);
            return str;
        }
    }
}
