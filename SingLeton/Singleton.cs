using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingLeton
{
    internal class Singleton
    {
        private static int counter=0;//  مشتركة في كل instances
        private Singleton()
        {
            counter++;
            Console.WriteLine("An Instance has been created");
            Console.WriteLine("num of available instances are"+counter);
        }
        private static Singleton myInstance=null;
        public static Singleton GetInstance
        {
            get {
                if(myInstance==null)
                    myInstance=new Singleton();
                return myInstance;
            }
        }
        public void ShowMessage(string message) 
        { 
            Console.WriteLine(message);
        
        }
    }
}
