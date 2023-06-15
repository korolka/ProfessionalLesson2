//Завдання 4

//Створіть колекцію типу OrderedDictionary та реалізуйте у ній можливість порівняння значень.
namespace ProfessionalEx4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyCollection myCollection = new MyCollection();
            myCollection.Add("hello", "world");
            myCollection.Add("new word", "words");
            myCollection.Add("world", "hello");
            myCollection.Add("new word", "Words");
            myCollection.Add("hello", "World");

            myCollection.Show();
        }
    }
}