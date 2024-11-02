namespace BehavioralPatterns.Iterator.NextBookPage.interfaces
{
    public interface IIterator<T>
    {
        bool HasNext(); 
        T Next();
    }
}
