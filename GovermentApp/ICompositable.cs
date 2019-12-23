namespace GovermentApp
{
    public interface ICompositable
    {
        string Name { get; set; }

        void GetDecree(string decree);
        bool IsCopmposite();
    }
}
