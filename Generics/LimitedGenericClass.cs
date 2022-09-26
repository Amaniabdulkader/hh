using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class LimitedGenericClass<T> where T : class,IStudent,new()
    {
        
        public void GenericMethod(T param1,T param2)
        {
            var param1Type=param1.GetType();
            var param2Type = param2.GetType();
            Console.WriteLine("the type of first parameter is "+ param1Type);
            Console.WriteLine("the type of Second  parameter is " + param1Type);
            
            var proprtiesInfo=param1.GetType().GetProperties();
            var proprtiesInfo2 = param2.GetType().GetProperties();

            foreach (var p in proprtiesInfo)
            {
                var value = p.GetValue(param1);// لجلب قيمة الخاصية اي الاسم
                Console.WriteLine($"{p.Name}: {value}"); 

            }
            foreach (var p in proprtiesInfo2)
            {
                var value = p.GetValue(param2);// لجلب قيمة الخاصية اي الاسم
                Console.WriteLine($"{p.Name}: {value}");

            }
        }
    }
}
