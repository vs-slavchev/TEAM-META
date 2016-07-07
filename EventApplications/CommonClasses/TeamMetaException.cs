using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonClasses
{
    public class TeamMetaException : Exception
    {
        public TeamMetaException(string message) : base(message) { }
    }
}
