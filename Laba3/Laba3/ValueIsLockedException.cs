using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba3
{
    internal class ValueIsLockedException : Exception
    {
        public ValueIsLockedException(string msg) : base(msg) { }
    }
}
