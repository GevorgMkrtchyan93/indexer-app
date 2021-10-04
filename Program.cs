using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerApp
{
    class Program
    {
      

        static void Main(string[] args)
        {
            DayOfWeek dayOfWeek = new DayOfWeek();

            foreach (string item in dayOfWeek)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }

       public class DayOfWeek : IEnumerable
        {
            private string[] _dayOfWeek = new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            public IEnumerator GetEnumerator()
            {
                return new DayOfWeekIEnumerator(_dayOfWeek);
            }
        }

        public class DayOfWeekIEnumerator : IEnumerator
        {
            private string[] _items;
            private int count = 0;

            public DayOfWeekIEnumerator(string[] items)
            {
                _items = items;
            }
            public object Current => _items[count++];

            public bool MoveNext()
            {
                return count < _items.Length;
            }

            public void Reset()
            {
                throw new NotImplementedException();
            }
        }
    }
}