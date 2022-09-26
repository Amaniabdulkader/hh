using System.Drawing;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            //old non-generic way
            Console.WriteLine("Hello, World!");
            bool result = Equlater.AreEqual(10, 20);
            bool result1 = Equlater.AreEqual(10.5, 20.5);
            bool result2 = Equlater.AreEqual("AB", "AB");

            // new generic way
            bool isGenericResult = GenericEqulator.AreEqual<double>(10.3,30.1);


            ////////Generic Class///////////
            ///
            var first = new GenericClass<int>(10, "ten", "from 1 to 10");
           // Console.WriteLine($"{first.Item}: {first.Name} - {first.Description}");

            var second = new GenericClass<Myclass>(new Myclass(), "ten", "from 1 to 10");

            /////////limited Generic class /////////
            ///
            var genericClass = new LimitedGenericClass<ElementaryStudent>();
            //var genericClass = new LimitedGenericClass<SecondaryStudent>();// will throw error becaus of the need of the parameterless constructor
            /*var firstStudent = new ElementaryStudent()
            {
                age = 10,
                FullName = "Ahmad AboHomied",
            };
            var ScondStudent = new ElementaryStudent()
            {
                age = 8,
                FullName = "Samer AdoSamra",
            };
            genericClass.GenericMethod(firstStudent, ScondStudent);*/



        }
    }
    public class Myclass
    {
        public int MyProperty { get; set; }
    }
    public interface IStudent
    {

    }
    public class ElementaryStudent : IStudent
    {
       
        public int age { get; set; }
        public string FullName { get; set; }

    }
    public class SecondaryStudent : IStudent
    {
        public SecondaryStudent(int y){
}

    }
}