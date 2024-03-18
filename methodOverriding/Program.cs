using System;

namespace methodOverriding
{
    public class Human
    {
        public virtual void Eats()
        {
            Console.WriteLine("Eating is a comman human need.");
        }

        //we addeed virtual keyword so we can override this methods
        public virtual void Walks()
        {
            Console.WriteLine("Humans can walk.");
        }

        public class Student : Human
        {
            public override void Walks()
            {
                Console.WriteLine("Students walk to their school.");
            }

            public override void Eats()
            {
                Console.WriteLine("Students like to eat pizza and pastas these days.");
            }
        }

        class Test
        {
            public static void Main()
            {
              Human h1 = new Human();
                h1.Walks();
                h1.Eats();

                Student student = new Student();
                student.Walks();
                student.Eats();

                Console.ReadKey();
            }
        }
    }


}
