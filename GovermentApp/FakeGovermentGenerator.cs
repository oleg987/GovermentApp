using System;
using System.Collections.Generic;

namespace GovermentApp
{
    class FakeGovermentGenerator
    {
        public static ICompositable GetGoverment()
        {
            ICompositable goverment = new Ministry("Goverment");

            string[] firstNames = { "John", "Mike", "Peter", "Bob", "Frank", "Alice", "Ann", "Jane", "Lilly", "Katrin" };
            string[] lastNames = { "Brown", "Cooper", "Merkury", "Adams", "Fox", "Williams", "Doe", "Douglas" };

            string[] ministriesNames = { "Transport", "Finance", "Science", "Energy" };

            Random r = new Random();

            for (int i = 0; i < 4; i++)
            {
                List<ICompositable> emps = new List<ICompositable>();

                for (int j = 0; j < 5; j++)
                {
                    Employee employee = new Employee(firstNames[r.Next(firstNames.Length)] + " " + lastNames[r.Next(lastNames.Length)]);
                    emps.Add(employee);
                }
                Ministry ministry = new Ministry($"Ministry Of {ministriesNames[i]}", emps);
                ((Ministry)goverment).Add(ministry);
            }

            return goverment;
        }
    }
}
