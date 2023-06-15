using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfessionalEx6
{
    class MyCollection
    {
        SortedList<string, int> list;

        public MyCollection()
        {
            list = new SortedList<string, int>();
        }

        public void Add(string key, int value)
        {
            list[key] = value;

        }

        public void OrderByDescending()
        {
            list = new SortedList<string, int>(list,new DescendingComparer());
            Console.WriteLine("After descending");
        }


        public void Show()
        {
            foreach (var item in list)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
        }
    }

    class DescendingComparer : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            return Comparer<string>.Default.Compare(y, x);
        }
    }
}
