using System;

namespace GovermentApp
{
    class Program
    {
        static void Main(string[] args)
        {
            President president = new President(FakeGovermentGenerator.GetGoverment());

            
            while (true)
            {
                Console.WriteLine("Enter decree:");
                string input = Console.ReadLine();
                                
                switch (input)
                {
                    case "1":
                        president.Decree("Up");
                        goto end;                        
                    case "2":
                        president.Decree("Down");
                        goto end;
                    default:
                        Console.Clear();
                        Console.WriteLine("Enter correct num");                        
                        break;
                }
            }
        end:
            Console.ReadLine();
        }
    }
}
