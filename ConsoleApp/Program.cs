// Müşterilerimiz : 


using Business;
using DataAccess;
using DataAccess.EntityFramework;
using Entities;


int number = 0;


//Customer customer1 = new RealCustomer();
//customer1.Name = "Enes Zeren";
//Customer customer2 = new CompanyCustomer();
//customer2.Name = "Nevotek";


//List<Customer> customers = new List<Customer>();
//AddCustomer(customer1, customers);
//AddCustomer(customer2, customers);
//void AddCustomer(Customer customer, List<Customer> customers)
//{
//    customers.Add(customer);
//}

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





//IProductService productManager = new ProductManager();

//var product = new Product { CategoryId = 2,ProductId = 4,ProductName = "Computer",UnitPrice  = 1000, UnitsInStock = 3};
//productManager.AddProduct(product);



// var result = productManager.Get(p => p.ProductName == "Computer");

//Console.WriteLine($" ürün ismi: {result.ProductName}, fiyat: {result.UnitPrice}");




IProductService productService = new ProductManager(new EfProductDal());


var list = productService.GetAll();

foreach (var item in list)
{
    Console.WriteLine($"productName = {item.ProductName}");
}

Product entity = new Product { CategoryId = 3, ProductName = "Glass", UnitPrice = 4, UnitsInStock = 0 };

//productService.AddProduct(entity);

 list = productService.GetAll();

entity.UnitPrice = 12344;
Product entity2 = productService.Get(p => p.ProductName == "Glass");
Product entity3 = productService.Get(p => p.ProductName == "Glass");


foreach (var item in list)
{
    Console.WriteLine($"productName = {item.ProductName}, productPrice = {item.UnitPrice}");
}

