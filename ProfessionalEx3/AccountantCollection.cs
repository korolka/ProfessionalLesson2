using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfessionalEx3
{
    class AccountantCollection
    {
        Dictionary<int, double> dictionaryAccountant;
        SortedDictionary<int, double> sortedDictionaryAccountant;

        public AccountantCollection()
        {
            dictionaryAccountant = new Dictionary<int, double>();
            sortedDictionaryAccountant= new SortedDictionary<int, double>();    
        }

        public void AddToSortedDict(int key, double value)
        {
            sortedDictionaryAccountant[key] = value;
        }

        public void AddToDict(int key, double value)
        {
           dictionaryAccountant[key] = value;
        }

        public void ShowDictonary()
        {
            foreach(var dictionaryAccount in dictionaryAccountant)
            {
                Console.WriteLine($"personal account: {dictionaryAccount.Key} - cost:{dictionaryAccount.Value}");
            }

            foreach (var sortedDictionaryAccount in sortedDictionaryAccountant)
            {
                Console.WriteLine($"personal account: {sortedDictionaryAccount.Key} - cost:{sortedDictionaryAccount.Value}");
            }
        }

    }
}
