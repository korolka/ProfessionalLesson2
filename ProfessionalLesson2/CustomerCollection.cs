namespace ProfessionalLesson2
{
    class CustomerCollection
    {
        Dictionary<string, string> customersAndCategory;

        public CustomerCollection()
        {
            customersAndCategory = new Dictionary<string, string>();
        }

        public void AddNewCustAndCatefory(string customerName, string categoryName)
        {
            customersAndCategory[customerName] = categoryName;
        }

        public void ShowCategory(string customerName)
        {
            Console.WriteLine($"Search category by customer name:  {customersAndCategory[customerName]}");
        }

        public void ShowCustomer(string categoryName)
        {
            if (customersAndCategory.ContainsValue(categoryName))
            {
                Console.WriteLine($"Search by category name: {categoryName}");
                foreach (var customerAndCategory in customersAndCategory)
                {
                    if (customerAndCategory.Value == categoryName)
                    {
                        Console.WriteLine($"Result: {customerAndCategory.Key}");
                    }
                }
                return;
            }
            else
            {
                Console.WriteLine($"Don`t exist {categoryName}");
            }
        }
    }
}
