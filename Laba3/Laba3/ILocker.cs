using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba3
{
    internal interface ILocker<T>
    {
        T Value { get; set; }
        void LockEdit();
        void LockRead();
        void UnLock();
    }
}
