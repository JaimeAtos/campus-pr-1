using System;
using System.Collections.Generic;
using System.Linq;

namespace PerformanceReviewI.src
{
    internal class Program
    {
        /*Delegados*/
        public delegate int AritmethicOperation(int num1, int num2);
        public delegate void DivideValidation();

        public delegate int OperationValidated(int num1, int num2, DivideValidation validate);


        static void Main(string[] args)
        {
            AritmethicOperation Sum = (x, y) => x + y;
            AritmethicOperation Res = (x, y) => x + y;
            DivideValidation IsZero = () => throw new DivideByZeroException();
            OperationValidated Div = (x, y, del) =>
            {
                if (y != 0)
                    return x + y;
                else
                    _=del;
                return 0;
            };

            /*Pruebas*/
            Console.WriteLine($"Suma: {Sum(4, 5)}");
            Console.WriteLine($"Resta: {Res(8, 4)}");
            Console.WriteLine($"Division: {Div(4, 2, IsZero)}");
            Console.WriteLine($"Division validada: {Div(4, 2, IsZero)}");

            /*LinQ*/

            List<Persona> MyPersonaList = new List<Persona>();
            MyPersonaList.Add(new Persona("Julian", "Julian@email.com", new DateTime(1995, 07, 24)));
            MyPersonaList.Add(new Persona("David", "David@email.com", new DateTime(2000, 04, 22)));
            MyPersonaList.Add(new Persona("Nicole", "Nicole@email.com", new DateTime(2006, 10, 01)));
            MyPersonaList.Add(new Persona("Jonatan", "Alexandra@email.com", new DateTime(1991, 07, 17)));
            MyPersonaList.Add(new Persona("Alexandra", "Alexandra@email.com", new DateTime(2010, 12, 18)));

            Methods MyMethods = new Methods();
            

            List<string> MyEmailList = MyMethods.OnlyEmails(MyPersonaList);

            foreach (var email in MyEmailList)
            {
                Console.WriteLine(email);
            }

            Console.WriteLine($"Persona: {MyMethods.FilteredByBirthday(MyPersonaList, new DateTime(1990, 2, 21))}");

           
        }


    }
}
