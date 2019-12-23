using System;
using System.Collections.Generic;

namespace GovermentApp
{
    // Composite
    class Ministry : ICompositable
    {
        public virtual string Name { get; set; }
        public List<ICompositable> Composits { get; set; }

        public Ministry(string name, List<ICompositable> composits = null)
        {
            Name = name;

            if (composits == null)
            {
                Composits = new List<ICompositable>();
            }
            else
            {
                Composits = composits;
            }
        }

        // Operation
        public virtual void GetDecree(string decree)
        {
            Console.WriteLine($"{Name} receive {decree}!");
            foreach (ICompositable item in Composits)
            {
                item.GetDecree(decree);
            }
        }

        // Operation
        public bool IsCopmposite()
        {
            return true;
        }

        public void Add(ICompositable item)
        {
            Composits.Add(item);
        }

        public void Remove(ICompositable item)
        {
            Composits.Remove(item);
        }
    }
}
