using System;

namespace FinalExamN12
{
    class Program
    {
        static void Main(string[] args)
        {
            Adult a = new Adult("Behzad", "Joulaei");
            Child  c = new Child ("Gilles", "Esteve");
            IHuman[] h = new IHuman[2];
            h[0] = a;
            h[1] = c;
            for (int i= 0; i< 2; i++)
            {
                h[i].print();
            }
        }

        interface IHuman
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            void print();
        }
            public class Adult: IHuman
        {
            public Adult(string f, string l)
            {
                FirstName = f;
                LastName = l;
            }
            public string FirstName { get; set; }
            public string LastName { get; set; }

            public void print()
            {
                Console.WriteLine(FirstName + " " + LastName);
            }
        }
        public class Child: IHuman
        {
            public Child(string f, string l)
            {
                FirstName = f;
                LastName = l;
            }

            public string FirstName { get; set; }
            public string LastName { get; set; }
            public void print()
            {
                Console.WriteLine(FirstName + " " + LastName);
            }

        }

    }
}
