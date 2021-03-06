using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практика_6
{
    interface IIndexableSeries : IIndexable, ISeries
    {
        double this[int index] { get; }
        double GetCurrent();
        bool MoveNext();
        void Reset();

    }
}
