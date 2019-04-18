using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 objectOfclass1 = new Class1()
            {
                prop1 = 10,
                prop2 = "prop2"
            };

            Class2 objectOfclass2 = new Class2()
            {
                class1prop = objectOfclass1
            };

            Console.WriteLine("Result : objectOfclass2.class1prop.prop1:[{0}] - objectOfclass2.class1prop.prop2:[{1}]"
                , objectOfclass2.class1prop.prop1, objectOfclass2.class1prop.prop2);

            objectOfclass1.prop1 = 20;
            objectOfclass1.prop2 = "prop2AfterChange";

            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine("Changes : \n{ \n  objectOfclass1.prop1 = 20;\n  objectOfclass1.prop2 = \"prop2AfterChange\";\n}");
            Console.WriteLine("-----------------------------------------------------------------");

            Console.WriteLine("Result : objectOfclass2.class1prop.prop1:[{0}] - objectOfclass2.class1prop.prop1:[{1}]"
                , objectOfclass2.class1prop.prop1, objectOfclass2.class1prop.prop2);

            Console.ReadKey();
        }
    }
    class Class1
    {
        public int prop1 { get; set; }
        public string prop2 { get; set; }
    }
    class Class2
    {
        public Class1 class1prop { get; set; }
    }
       
}
