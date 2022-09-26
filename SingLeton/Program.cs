namespace SingLeton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // the problem 
            /*  Singleton firstInstance= new Singleton();
              firstInstance.ShowMessage("first message");

              Singleton secondInstance = new Singleton();
              firstInstance.ShowMessage("second message");*/

            //// the Singleton Pattren 
            ///
            // you should prevent taking an instance from your class(make the constructor as private)
            // 
            var s = Singleton.GetInstance;
            s.ShowMessage("first message");

            var z = Singleton.GetInstance;
            z.ShowMessage("second message");


        }
    }
}