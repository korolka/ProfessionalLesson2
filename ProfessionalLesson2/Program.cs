//Завдання 2

//Створіть колекцію, до якої можна додавати покупців та категорію придбаної ними продукції. 
//    З колекції можна отримувати категорії товарів, які купив покупець або за категорією визначити покупців.
namespace ProfessionalLesson2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerCollection customerCollection = new CustomerCollection();
            customerCollection.AddNewCustAndCatefory("Vlad", "fishing buyer");
            customerCollection.AddNewCustAndCatefory("Andrey", "vehicle buyer");
            customerCollection.AddNewCustAndCatefory("Angelina", "Garden weapon buyer");
            customerCollection.AddNewCustAndCatefory("Sasha", "fishing buyer");
            customerCollection.AddNewCustAndCatefory("Iryna", "beuty buyer");

            customerCollection.ShowCustomer("vehicle buyer");
            customerCollection.ShowCustomer("fishing buyer");

            customerCollection.ShowCategory("Angelina");
        }
    }
}