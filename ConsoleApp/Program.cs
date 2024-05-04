// Müşterilerimiz : 


using Business;
using DataAccess;
using Entities;


int number = 0;


Customer customer1 = new RealCustomer();
customer1.Name = "Enes Zeren";
Customer customer2 = new CompanyCustomer();
customer2.Name = "Nevotek";


List<Customer> customers = new List<Customer>();
AddCustomer(customer1, customers);
AddCustomer(customer2, customers);
void AddCustomer(Customer customer, List<Customer> customers)
{
    customers.Add(customer);
}

//ProductDal productDal1 = new ProductDal();
//Console.WriteLine($"{productDal1.GetProduct(p=> p.ProductId == 3).UnitPrice}");


//List<RealCustomer> realCustomers = new List<RealCustomer>();
//void AddRealCustomer(RealCustomer realCustomer,List<RealCustomer> realCustomers)
//{
//    //
//    // .....
//    //
//    realCustomers.Add(realCustomer);
//}

//List<CompanyCustomer> companyCustomer = new List<CompanyCustomer>();
//void AddCompanyCustomer(CompanyCustomer companyCustomer,List<CompanyCustomer> companyCustomers)
//{
//    companyCustomers.Add(companyCustomer);
//}

//// SOLID O: Open/Closed 





//foreach (Customer customer in customers)
//{
//    Console.WriteLine($"Customer name: {customer.Name}");
//}





IProductService productManager = new ProductManager();

var product = new Product { CategoryId = 2,ProductId = 4,ProductName = "Computer",UnitPrice  = 1000, UnitsInStock = 3};
productManager.AddProduct(product);


GetByid(5)
 var result = productManager.Get(p => p.ProductName == "Computer");

Console.WriteLine($" ürün ismi: {result.ProductName}, fiyat: {result.UnitPrice}");




