using System;
using System.Linq;

namespace TinyCrmConsole
{
   public class Program
    {
        //static int Errors = 0;  //Errors: Empty line, double id
        static void Main(string[] args)
        {
            //string path = "Product_List.csv";
            //try
            //{
            //    var reader = new StreamReader(path);

            //    if (reader == null) throw new Exception();  //File doesn't exist

            //    var i = 0;

            //    var product = new List<Product>(); //List of Product objects

            //    while (!reader.EndOfStream)
            //    {
            //        var line = reader.ReadLine();  //Read Line from Document

            //        if (string.IsNullOrWhiteSpace(line))  //check for empty line
            //        {
            //            Console.WriteLine("Empty line found.\n");
            //            Errors++;
            //            continue;
            //        }

            //        var newProduct = new Product();

            //        var values = line.Split(';');

            //        if (!product.Where(product => product.ProductId.Equals(values[0]))
            //                                              .Any())
            //        {
            //            if (string.IsNullOrWhiteSpace(values[0]))
            //            {
            //                Console.WriteLine("Product id is missing \n");
            //            }
            //            newProduct.ProductId = values[0];  //product id
            //            newProduct.Name = values[1];  //product name
            //            newProduct.Description = values[2];  //product description
            //            newProduct.Price = GetRandomPrice();  //product's price

            //            product.Add(newProduct); //add to list of objects

            //            i++;
            //        }
            //        else
            //        {
            //            Errors++;
            //            Console.WriteLine($"Double product ID found, at Document line {i + Errors}");
            //            Console.WriteLine();
            //        }
            //    }

            //    var k = 1;                    //products output
            //    foreach (var prod in product)
            //    {
            //        Console.WriteLine($"Product {k} id: {prod.ProductId}");
            //        Console.WriteLine($"Product {k} name: {prod.Name}");
            //        Console.WriteLine($"Product {k} description: {prod.Description}");
            //        Console.WriteLine($"Product {k} price: {prod.Price}");
            //        Console.WriteLine();

            //        k++;
            //    }

            //    var customer = new List<Customer>(); //Customer list

            //   // "dummy" customer1
            //   var customer1 = new Customer("123456789", "xaris");
            //    customer.Add(customer1);

            //   // "dummy" customer2
            //   var customer2 = new Customer("789456123", "julie");
            //    customer.Add(customer2);

            //    var order1 = new Order();
            //    var order2 = new Order();

            //    for (var s = 0; s < 10; s++)  // select 10 random products for orders
            //    {
            //        var random = new Random();
            //        var value = random.Next(1, product.Count());
            //        order1.ListOfProductsInOrder.Add(product.ElementAt(value));

            //        var val = random.Next(1, product.Count());
            //        order2.ListOfProductsInOrder.Add(product.ElementAt(val));
            //    }

            //    foreach (var item in order1.ListOfProductsInOrder)
            //    {
            //        Console.WriteLine($"Order 1 item's name: {item.Name} and price: {item.Price}");
            //        order1.TotalAmount += item.Price;
            //    }

            //    customer1.CustomerOrderList.Add(order1);  // add selected products to costumer1's order list                
            //    Console.WriteLine();

            //    foreach (var item in order2.ListOfProductsInOrder)
            //    {
            //        Console.WriteLine($"Order 2 item's name: {item.Name} and price: {item.Price}");
            //        order2.TotalAmount += item.Price;
            //    }

            //    customer2.CustomerOrderList.Add(order2); //add selected products to costumer2's order list
            //    Console.WriteLine();

            //    if (order1.TotalAmount < order2.TotalAmount)
            //    {
            //        Console.WriteLine($"Most valued costumer is {customer2.Firstname} " +
            //            $"with total sum: {order2.TotalAmount} \n");
            //    }
            //    else if (order1.TotalAmount > order2.TotalAmount)
            //    {
            //        Console.WriteLine($"Most valued costumer is {customer1.Firstname} " +
            //         $"with total sum: {order1.TotalAmount} \n");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"Both costumers are valued \n");
            //    }

            //    var bestselling = customer                                //Find Best selling products
            //                            .SelectMany(x => x.CustomerOrderList)
            //                            .SelectMany(y => y.ListOfProductsInOrder)
            //                            .GroupBy(k => k)
            //                            .Select(j => new { Element = j.Key, Counter = j.Count() })
            //                            .OrderByDescending(z => z.Counter)
            //                            .Distinct()
            //                            .Take(5)
            //                            .ToList();

            //    Console.WriteLine("Best selling products\n");
            //    foreach (var item in bestselling)
            //    {
            //        Console.WriteLine($"product's name: {item.Element.Name} " +
            //        $"product's id: {item.Element.ProductId} number of times: {item.Counter}");
            //    }

            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("file not found");
            //}

            //static decimal GetRandomPrice()
            //{
            //    var random = new Random();
            //    var value = Math.Round(random.NextDouble() * 100, 2);
            //    return (decimal)value;
            //}

            // insert new customer
            //var customerCreate = new CustomerCreateOptions
            //{
            //    Lastname = "Mpouras",
            //    Firstname = "xaris",
            //    Dob = new DateTime(1991, 5, 21),
            //    Email = "xaris@mail.com",
            //    VatNumber = "123456789"
            //};

            //var customer = new CustomerCrud();
            //customer.CreateCustomer(customerCreate);

            //// search customer
            //var customerSearchOpt = new CustomerSearchOptions
            //{
            //    Firstname = "xaris",
            //    Lastname = "Mpouras",
            //    VatNumber = "123456789",
            //    CreatedFrom = new DateTime(2020, 5, 1),
            //    CreatedTo = new DateTime(2020, 7, 20),
            //    CustomerId = 2
            //};

            //try
            //{
            //    var customerToFind = customer.SearchCustomer(customerSearchOpt);

            //    Console.WriteLine($"customer name {customerToFind.Firstname} and surname {customerToFind.Lastname}");

            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Couldn't find specified customer.");
            //    var tinyCrmDbContext = new TinyCrmDbContext();
            //    var customersList = tinyCrmDbContext.Set<Customer>()
            //                                        .Where(n => n.CustomerId <= 500)
            //                                        .ToList();
            //}

            //// insert new product
            //var productCreate = new ProductCreateOptions
            //{
            //    Name = "loumidis",
            //    Description = "ellinikos kafes",
            //    Price = 1.23M,
            //    ProductCategory = "Kafes"
            //};

            //var product = new ProductCrud();
            //product.CreateProduct(productCreate);

            //// search product
            //var productSearchOpt = new ProductSearchOptions
            //{
            //    ProductId = 1,
            //    Categories = "Kafes",
            //    PriceFrom = 1.1M,
            //    PriceTo = 2M
            //};

            //try
            //{
            //    var productToFind = product.SearchProduct(productSearchOpt);

            //    Console.WriteLine($"product name {productToFind.Name} and price {productToFind.Price}");

            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Couldn't find specified product.");
            //    var tinyCrmDbContext = new TinyCrmDbContext();
            //    var productsList = tinyCrmDbContext.Set<Product>()
            //                                        .Where(n => n.ProductId <= 500)
            //                                        .ToList();
            //}

            //------------------------------------------------------------------//

            var context = new TinyCrmDbContext();

            IProductService productService = new ProductService(context);
            ICustomerService customerService = new CustomerService(context);
            IOrderService orderService = new OrderService(context, customerService, productService);

            //---------ICustomerService---------------------------------------//

            //var customer = customerService.CreateCustomer(new CustomerCreateOptions()
            //{
            //    FirstName = "tassos",
            //    LastName = "mpouras",
            //    Email = "tassos@mail.com",
            //    VatNumber = "789456456",
            //    Dob = DateTimeOffset.Parse("1993, 02, 26")
            //});
            //var customer2 = customerService.GetCustomerById(2);
            //Console.WriteLine($"{customer2.FirstName}");
            //var test = customerService.UpdateCustomer(new CustomerUpdateOptions()
            //{
            //    LastName = "Konstantopoulou"
            //}, 2);
            //Console.WriteLine($"{test}");
            //var customer3 = customerService.SearchCustomer(new CustomerSearchOptions()
            //{
            //    FirstName = "xaris"
            //}).SingleOrDefault();
            //Console.WriteLine($"{customer3.FirstName}");

            //-------------IProductService-------------------------------//

            //var product = productService.CreateProduct(new ProductCreateOptions()
            //{
            //    Name = "Loumidis",
            //    Description = "papa",
            //    Category = ProductCategory.Coffee,
            //    Price = 1.2M
            //});
            //var product2 = productService.GetProductById(1);
            //Console.WriteLine($"{product2.Name}");
            //var product3 = productService.SearchProducts(new ProductSearchOptions()
            //{
            //    PriceFrom = 800M
            //}).SingleOrDefault();
            //Console.WriteLine($"{product3.Name}");
            //var update = productService.UpdateProduct(new ProductUpdateOptions()
            //{
            //    Description = "Papagalos"
            //}, 3);
            //Console.WriteLine($"{update}");

            //-------------IOrderService---------------------------------//

            //var order = orderService.CreateOrder(new OrderCreateOptions()
            //{
            //    CustomerId = 2,
            //    DeliveryAddress = "Kalamata",
            //    ProductIds = { 1 }
            //});
            //Console.WriteLine($"{order.TotalAmount}");
            //var order2 = orderService.GetOrderById(1);            
            //foreach (var item in order2.OrderProducts)
            //{
            //    Console.WriteLine($"{item.ProductId}");
            //    var product = productService.GetProductById(item.ProductId);
            //    Console.WriteLine(product.Name);
            //}
            //var order3 = orderService.SearchOrder(new OrderSearchOptions()
            //{
            //    DeliveryAddress = "Aris"
            //}).SingleOrDefault();
            //Console.WriteLine(order3.OrderId);
            //orderService.UpdateOrder(new OrderUpdateOptions()
            //{
            //    DeliveryAddress = "Iatropoulou 1"
            //}, 2);
        }
    }
}
