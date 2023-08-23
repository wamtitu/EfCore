using Microsoft.EntityFrameworkCore;
using EFCORE.DATA;

shopContext newentry = new shopContext();
// newentry.Database.EnsureCreated();
// Console.WriteLine("Db created");

//adding customer to db
// newentry.AddCustomer();

//getting customers from db

// newentry.GetCustomers();

//adding customers together with orders
// newentry.AddcustomerWithOrder();

//getting customers with orders
newentry.GetCustomersWithOrders();