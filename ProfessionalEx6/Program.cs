//Завдання 6

//Використовуючи клас SortedList, створіть невелику колекцію та виведіть на екран 
//    значення пар «ключ-значення» спочатку в алфавітному порядку, а потім у зворотному.


namespace ProfessionalEx6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyCollection collection = new MyCollection();
            collection.Add("Sasha", 59);
            collection.Add("Angelina", 58);
            collection.Add("Iryna", 39);
            collection.Add("Andrey", 30);
            collection.Add("Vlad", 22);

            collection.Show();
            collection.OrderByDescending();
            collection.Show();
        }
    }
}