using System;

namespace GovermentApp
{
    // Client
    class President
    {
        public string Name { get; set; }
        public ICompositable Goverment { get; set; }

        public President(ICompositable goverment)
        {
            Name = "John Kennedy";
            Goverment = goverment;
        }

        public virtual void Decree(string decree)
        {
            if (SupremeConsil.GetConsil().Vote())
            {
                Goverment.GetDecree(decree);
            }
            else
            {
                Console.WriteLine($"Decree \'{decree}\' denied!");
            }
        }

        public virtual void AddToComposite(ICompositable item)
        {
            if (Goverment.IsCopmposite())
            {
                ((Ministry)Goverment).Add(item);
            }
        }

        public virtual void RemoveFromComposite(ICompositable item)
        {
            if (Goverment.IsCopmposite())
            {
                ((Ministry)Goverment).Remove(item);
            }
        }
    }
}
