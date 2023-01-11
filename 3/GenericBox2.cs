using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    public class GenericBox2<T>
    {
        public T Value { get; set; }

        public GenericBox2(T value)
        {
            Value = value;
        }

        public override string ToString()
        {
            return Value.GetType().FullName + $": {Value}";
        }
    }
}
