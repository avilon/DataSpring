using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public abstract class Entity : IDataReader
    {
        public abstract void Read(string value);
    }
}
