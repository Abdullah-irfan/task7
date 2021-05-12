using System;

namespace task6
{
    class Program
    {
        static void Main(string[] args)
        {
            OL.class1("Abdullah Irfan", "  Karur");
            OL.class1("Abbu", " trichy ", 28);
            Console.ReadKey();
            Details d = new Details();
            d.Get();
            Console.WriteLine("\nPress Enter Key to Exit..");
            Console.ReadLine();

        }
    }
    class OL
    {
        public static void class1(string Name, string Locaion)
        {
            Console.WriteLine("fullName:{0}{1}", Name , Locaion);
        }
        public static void class1(string Name, string Locaion,int age)//overloade
        { 
            Console.WriteLine("Deails:{0}{1}{2}", Name , Locaion, age);
        }
    }
    public class Users// Base Class
    {
        public string name = "Abbunu";
        public string location = "Trichy";
        public int age = 26;
        public virtual void Get()
        {
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Location: {0}", location);
        }
    }
    public class Details : Users
    {
        public override void Get()
        {
            base.Get();// udeing base keyword
            Console.WriteLine("Age: {0}", base.age);
        }
    }
   

}


