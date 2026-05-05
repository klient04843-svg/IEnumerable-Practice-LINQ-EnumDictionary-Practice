using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class DataContainer : EnumDictionary<ExampleTypes, ExampleClass>
    {
        public DataContainer() : base(() => new ExampleClass()) { }
    }
}
