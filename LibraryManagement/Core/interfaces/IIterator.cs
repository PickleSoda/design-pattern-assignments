namespace LibraryManagement.Core.Interfaces
{
    public interface IIterator<T>
    {
        bool HasNext();
        T Next();
    }
}
