using System;
using System.IO;




namespace ConsoleApp1
{
    //class MyClass<T,R,Z> where T : class,new()
    //{

    //}

    class a : b
    {
        //public override void Print()
        //{
        //    base.Print();
        //}
        public new void Print()
        {
            // base.Print();
        }
    }
    class b : c
    {

    }
    public class c : IA, IB
    {
        void IA.Print()
        {
            throw new NotImplementedException();
        }
        void IB.Print()
        {
            throw new NotImplementedException();
        }

    }
    class Logger : IDisposable
    {
        public Logger()
        {

        }
        public FileStream FileStream { get; set; }
        public StreamWriter StreamWriter { get; set; }


        public Logger(string filename)
        {
            FileStream = new FileStream(filename, FileMode.Append);
            StreamWriter = new StreamWriter(FileStream);
        }


        public virtual void Log(string text) { }

        public void Dispose()
        {
            if (!isClosed)
            {
                StreamWriter.Close();
                isClosed = true;
            }
        }

        private bool isClosed = false;
        ~Logger()
        {
            if (!isClosed)
            {
                StreamWriter.Close();
                isClosed = true;
            }
        }
    }


    //interface IInterface
    //{
    //    private void Print()
    //    {
    //        Console.WriteLine("Hello");
    //    }
    //    void See()
    //    {
    //        Print();
    //    }
    //}


    public interface IA
    {
        public void Print();
    }
    public interface IB
    {
        public void Print();
    }
    class Person
    {
        // MyClass<Logger, int, int> MyClass = new MyClass<Logger, int, int>();
        //public Person(int age, string name, string surname) : this(name,surname) 
        //{
        //    Age = age; 

        //}


        //public Person(string name, string surname) : this(0) 
        //{ 
        //    Name = name;
        //    Surname = surname;
        //} 
        //public int Age { get; set; }
        //public string Name { get; set; }
        //public string Surname { get; set; }



        public readonly int Age = 10;
        const int a = 10;
        public Person()
        {
            Age = 10;
        }

        public void test()
        {
            //    Age = 10;// Error
        }
        public static string Name { get; set; } = "Farid";
        public static string Surname { get; set; }
        private int myVar;

        public int MyProperty
        {
            get { return myVar; }
            set
            {
                if (value > 0 && value < 100)
                {
                    myVar = value;
                }

            }
        }

        //public Person()
        //{
        //    Name = "fARID";
        ////    // при создание объекта
        ////    Console.WriteLine("при создание объекта");
        //}

        static Person()
        {
            // при первом обращение
            //  Age = 100;
            Console.WriteLine("при первом обращение");
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            c cc = new c();

            //   cc.See();




            //try
            //{

            //    throw new ArgumentException("My error");
            //} 
            //catch (ArgumentException e)
            //{
            //    // 
            //    Console.WriteLine("Exception => " + e.Message);
            //}
            //catch (NullReferenceException e)
            //{
            //    // new Object
            //    Console.WriteLine("Exception => " + e.Message);
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine("Exception => " + e.Message);
            //}finally
            //{

            //}






            //Console.WriteLine(Person.Age);
            //Console.WriteLine(Person.Age);
            //Console.WriteLine(Person.Age);
            //Console.WriteLine(Person.Age);
            //Console.WriteLine(Person.Age);
            //Person.Age = 10;
            //Person.Age = 10;
            //Person.Age = 10;
            //Person.Age = 10;
            //Person.Age = 10;
            //Person.Age = 10;
            //Person.Age = 10;
            //Person.Age = 10;


            // Person person1 = new Person();
            // Console.WriteLine(person1.Age);
            //Person person2 = new Person();
            //Person person3 = new Person();
            //Person person4 = new Person();
            //Person person5 = new Person();
            //Person person6 = new Person();
            //Person person7 = new Person();





















            // Person person = new Person() { Age = 10, Name = "Farid", Surname = "Abdullayev" };

            //Person person1 = new Person("Farid","Abdullayev");



            //using (Logger logger = new Logger("logger.txt")) // Dispose
            //{
            //    ///// работа с файлами
            //}

            //////////////////////////////////////////////////////////////////////




            // Logger logger = new Logger("logger.txt");

            ///////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////
            ///

            // logger.StreamWriter.Close();

            // logger.StreamWriter.Close();
        }
    }
}