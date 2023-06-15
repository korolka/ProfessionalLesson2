//Завдання 3

//Декількома способами створіть колекцію, в якій можна зберігати тільки цілі та речові значення,
//    на кшталт «рахунок підприємства – доступна сума» відповідно.
namespace ProfessionalEx3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AccountantCollection accountantCollection = new AccountantCollection();
            accountantCollection.AddToDict(1241413122, 100000);
            accountantCollection.AddToSortedDict(1514152132, 350000);

            accountantCollection.ShowDictonary();
        }
    }
}