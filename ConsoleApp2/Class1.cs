using ConsoleApp3;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    [TestClass]
    class Class1
    {
        [TestMethod]
        public void test1()
        {
            Console.WriteLine("test111");
            Person p = new Person();

            Console.WriteLine(p.ToString());
            Console.WriteLine(p.ToString());
            Console.WriteLine(p.ToString());
        }
    }
}
