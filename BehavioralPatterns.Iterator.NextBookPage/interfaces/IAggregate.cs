using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.Iterator.NextBookPage.interfaces
{
    public interface IAggregate<T>
    {
        IIterator<T> CreateIterator();
    }
}
