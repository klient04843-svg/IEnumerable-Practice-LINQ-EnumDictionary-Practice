using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    enum ExampleTypes
    {
        One,
        Two,
        Three,
        Four,
        Five,
        Six

    }

    internal class ExampleClass
    {
        const int DefaultValue = 10;

        public int Value { get; private set; }

        public void Change(int value)
        {
            Value += value;
        }

        public ExampleClass() 
        {
            Value = DefaultValue;
        }

    }
}
