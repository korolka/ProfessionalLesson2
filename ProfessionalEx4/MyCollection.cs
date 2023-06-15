using System.Collections;
using System.Collections.Specialized;

namespace ProfessionalEx4
{
    class MyCollection
    {
        OrderedDictionary dictionar;

        public MyCollection()
        {
            dictionar = new OrderedDictionary(new InsensetiveCompare());
        }

        public void Add(object obj, object key)
        {
            dictionar[key] = obj;
        }

        public void Show()
        {
            foreach(DictionaryEntry entry in dictionar)
            {
                Console.WriteLine($"{entry.Key} - {entry.Value}");   
            }
        }

        class InsensetiveCompare : IEqualityComparer
        {
            readonly CaseInsensitiveComparer comparer = new CaseInsensitiveComparer();

            public int GetHashCode(object obj)
            {
                return obj.ToString().ToLowerInvariant().GetHashCode();
            }

            public new bool Equals(object x, object y)
            {
                return comparer.Compare(x, y) == 0;
            }
        }
    }
}
