using System;
namespace omar
{
    class student
    {
        int age;
        int ssn;
        string name;

        public void personal(int Age , string Name,int SSN) {
            age = Age;
            ssn = SSN;
            name = Name;
        }
        public void detalies()
        {
            Console.WriteLine($"{age} - {name} - {ssn}");
        }
    }
    class program
    {
        static void Main(string[] arge)
        {
            //1
            Console.WriteLine(" enter  a number");
            int x=int.Parse(Console.ReadLine());
            int i;
            int y;
            for (i = 0;i<=12; i++) {
                y = x * i;
                Console.WriteLine($"{x} * {i}={y}");
            }
            //2
            Console.WriteLine("enter your age");
            int age = -1;
            do
            {
                age = int.Parse(Console.ReadLine());
            } while (age<0);
            //3

            student st = new student();
            st.personal( 20,"omar",995588);
            st.detalies();
        }
    }
}


        
