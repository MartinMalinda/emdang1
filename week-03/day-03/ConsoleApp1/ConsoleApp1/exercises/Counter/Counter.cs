using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Counter
    {
        private int defaultValue = 0;
        public int Value { get; set; } //= 0   predefined value > due to "default value" above   // default property

        public Counter()        // default constructor
        {
            Value = defaultValue;
        }

        public Counter(int value)       // overloaded constructor
        {
            Value = value;
            defaultValue = value;
        }

        public void Add()       // default method > increasing by one
        {
            Value++;
        }

        public void Add(int newValue)       // overloaded method > increasing by specified number
        {
            Value = Value + newValue;
        }

        public string Get()
        {
            return Value.ToString();        // conversion of int to string
        }

        public void Reset()
        {
            Value = defaultValue;
        }
    }
}
