using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    abstract class EnumDictionary<TEnum, TValue> : IEnumerable<T>
        where TEnum : struct, Enum
    {
        private Dictionary<TEnum, TValue> _data;

        public TValue Get(TEnum key) => _data[key];

        public IEnumerator<TValue> GetEnumerator()
            => _data.Values.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator()
            => GetEnumerator();

        protected EnumDictionary(Func<TValue> factory)
        {
            _data = Enum.GetValues<TEnum>()
                .ToDictionary(key => key, _ => factory());
        }
    }
}
