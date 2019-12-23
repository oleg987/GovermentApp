using System;

namespace GovermentApp
{
    // Entity
    class Employee : ICompositable
    {
        public virtual string Name { get; set; }

        public Employee(string name)
        {
            Name = name;
        }

        // Operation
        public virtual void GetDecree(string decree)
        {
            Console.WriteLine($"{Name} receive {decree}");
        }

        // Operation
        public bool IsCopmposite()
        {
            return false;
        }
    }
}
